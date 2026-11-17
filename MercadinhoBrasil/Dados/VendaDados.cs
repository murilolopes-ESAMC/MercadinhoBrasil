using MercadinhoBrasil.Modelos;
using Npgsql;

namespace MercadinhoBrasil.Dados;

public class VendaDados
{
    // ---------------------------------------------------------
    // Grava uma venda completa no banco
    // ---------------------------------------------------------
    public void Salvar(Venda venda)
    {
        using (NpgsqlConnection conexao = Conexao.AbrirConexao())
        {
            NpgsqlTransaction transacao = conexao.BeginTransaction();

            try
            {
                string sqlVenda = "INSERT INTO vendas (data_venda, forma_pagamento, valor_total) "
                                + "VALUES (@data, @pagamento, @total) "
                                + "RETURNING id";

                int idDaVenda;

                using (NpgsqlCommand comando = new NpgsqlCommand(sqlVenda, conexao, transacao))
                {
                    comando.Parameters.AddWithValue("@data", venda.DataVenda);
                    comando.Parameters.AddWithValue("@pagamento", venda.FormaPagamento);
                    comando.Parameters.AddWithValue("@total", venda.ValorTotal);

                    idDaVenda = Convert.ToInt32(comando.ExecuteScalar());
                }

                foreach (ItemVenda item in venda.Itens)
                {
                    string sqlItem = "INSERT INTO itens_venda (venda_id, produto_id, quantidade, preco_unitario) "
                                   + "VALUES (@venda, @produto, @quantidade, @preco)";

                    using (NpgsqlCommand comando = new NpgsqlCommand(sqlItem, conexao, transacao))
                    {
                        comando.Parameters.AddWithValue("@venda", idDaVenda);
                        comando.Parameters.AddWithValue("@produto", item.ProdutoId);
                        comando.Parameters.AddWithValue("@quantidade", item.Quantidade);
                        comando.Parameters.AddWithValue("@preco", item.PrecoUnitario);

                        comando.ExecuteNonQuery();
                    }

                    string sqlEstoque = "UPDATE produtos "
                                      + "SET quantidade = quantidade - @quantidade "
                                      + "WHERE id = @produto";

                    using (NpgsqlCommand comando = new NpgsqlCommand(sqlEstoque, conexao, transacao))
                    {
                        comando.Parameters.AddWithValue("@quantidade", item.Quantidade);
                        comando.Parameters.AddWithValue("@produto", item.ProdutoId);

                        comando.ExecuteNonQuery();
                    }
                }

                transacao.Commit();
            }
            catch
            {
                transacao.Rollback();
                throw;
            }
        }
    }

    // ---------------------------------------------------------
    // Devolve as vendas feitas entre duas datas.
    // ---------------------------------------------------------
    public List<Venda> Listar(DateTime dataInicial, DateTime dataFinal, string formaPagamento)
    {
        List<Venda> lista = new List<Venda>();

        DateTime inicio = dataInicial.Date;
        DateTime fim = dataFinal.Date.AddDays(1);

        string sql = "SELECT id, data_venda, forma_pagamento, valor_total "
                   + "FROM vendas "
                   + "WHERE data_venda >= @inicio AND data_venda < @fim ";

        if (formaPagamento != "Todas")
        {
            sql = sql + "AND forma_pagamento = @pagamento ";
        }

        sql = sql + "ORDER BY data_venda DESC";

        using (NpgsqlConnection conexao = Conexao.AbrirConexao())
        {
            using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexao))
            {
                comando.Parameters.AddWithValue("@inicio", inicio);
                comando.Parameters.AddWithValue("@fim", fim);

                if (formaPagamento != "Todas")
                {
                    comando.Parameters.AddWithValue("@pagamento", formaPagamento);
                }

                using (NpgsqlDataReader leitor = comando.ExecuteReader())
                {
                    while (leitor.Read())
                    {
                        int id = leitor.GetInt32(0);
                        DateTime dataVenda = leitor.GetDateTime(1);
                        string pagamento = leitor.GetString(2);
                        decimal valorTotal = leitor.GetDecimal(3);

                        Venda venda = new Venda(id, dataVenda, pagamento, valorTotal);

                        lista.Add(venda);
                    }
                }
            }
        }

        return lista;
    }

    // ---------------------------------------------------------
    // Devolve os itens (produtos) de uma venda.
    // ---------------------------------------------------------
    public List<ItemVenda> ListarItens(int idDaVenda)
    {
        List<ItemVenda> lista = new List<ItemVenda>();

        string sql = "SELECT i.produto_id, p.nome, i.quantidade, i.preco_unitario "
                   + "FROM itens_venda i "
                   + "JOIN produtos p ON p.id = i.produto_id "
                   + "WHERE i.venda_id = @venda "
                   + "ORDER BY p.nome";

        using (NpgsqlConnection conexao = Conexao.AbrirConexao())
        {
            using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexao))
            {
                comando.Parameters.AddWithValue("@venda", idDaVenda);

                using (NpgsqlDataReader leitor = comando.ExecuteReader())
                {
                    while (leitor.Read())
                    {
                        int produtoId = leitor.GetInt32(0);
                        string nomeProduto = leitor.GetString(1);
                        int quantidade = leitor.GetInt32(2);
                        decimal precoUnitario = leitor.GetDecimal(3);

                        ItemVenda item = new ItemVenda(produtoId, nomeProduto, quantidade, precoUnitario);

                        lista.Add(item);
                    }
                }
            }
        }

        return lista;
    }
}
