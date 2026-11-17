using MercadinhoBrasil.Modelos;
using Npgsql;

namespace MercadinhoBrasil.Dados;

public class ProdutoDados
{
    // ---------------------------------------------------------
    // CREATE - cadastra um produto novo
    // ---------------------------------------------------------
    public void Inserir(Produto produto)
    {
        string sql = "INSERT INTO produtos (nome, categoria, preco, quantidade) "
                   + "VALUES (@nome, @categoria, @preco, @quantidade)";

        using (NpgsqlConnection conexao = Conexao.AbrirConexao())
        {
            using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexao))
            {
                comando.Parameters.AddWithValue("@nome", produto.Nome);
                comando.Parameters.AddWithValue("@categoria", produto.Categoria);
                comando.Parameters.AddWithValue("@preco", produto.Preco);
                comando.Parameters.AddWithValue("@quantidade", produto.Quantidade);

                comando.ExecuteNonQuery();
            }
        }
    }

    // ---------------------------------------------------------
    // READ - devolve todos os produtos, em ordem alfabética
    // ---------------------------------------------------------
    public List<Produto> Listar()
    {
        return Buscar("");
    }

    // ---------------------------------------------------------
    // READ - devolve os produtos que têm o texto no nome
    // ---------------------------------------------------------
    public List<Produto> Buscar(string texto)
    {
        List<Produto> lista = new List<Produto>();

        string sql = "SELECT id, nome, categoria, preco, quantidade "
                   + "FROM produtos "
                   + "WHERE nome ILIKE @texto "
                   + "ORDER BY nome";

        using (NpgsqlConnection conexao = Conexao.AbrirConexao())
        {
            using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexao))
            {
                comando.Parameters.AddWithValue("@texto", "%" + texto + "%");

                using (NpgsqlDataReader leitor = comando.ExecuteReader())
                {
                    while (leitor.Read())
                    {
                        Produto produto = MontarProduto(leitor);

                        lista.Add(produto);
                    }
                }
            }
        }

        return lista;
    }

    // ---------------------------------------------------------
    // READ - devolve um produto pelo id (ou null se não existir)
    // ---------------------------------------------------------
    public Produto BuscarPorId(int id)
    {
        string sql = "SELECT id, nome, categoria, preco, quantidade "
                   + "FROM produtos "
                   + "WHERE id = @id";

        using (NpgsqlConnection conexao = Conexao.AbrirConexao())
        {
            using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexao))
            {
                comando.Parameters.AddWithValue("@id", id);

                using (NpgsqlDataReader leitor = comando.ExecuteReader())
                {
                    if (leitor.Read())
                    {
                        return MontarProduto(leitor);
                    }

                    return null;
                }
            }
        }
    }

    private Produto MontarProduto(NpgsqlDataReader leitor)
    {
        string nome = leitor.GetString(1);
        string categoria = leitor.GetString(2);
        decimal preco = leitor.GetDecimal(3);
        int quantidade = leitor.GetInt32(4);

        Produto produto = new Produto(nome, categoria, preco, quantidade);
        produto.Id = leitor.GetInt32(0);

        return produto;
    }

    // ---------------------------------------------------------
    // UPDATE - altera um produto que já existe
    // ---------------------------------------------------------
    public void Atualizar(Produto produto)
    {
        string sql = "UPDATE produtos "
                   + "SET nome = @nome, categoria = @categoria, "
                   + "    preco = @preco, quantidade = @quantidade "
                   + "WHERE id = @id";

        using (NpgsqlConnection conexao = Conexao.AbrirConexao())
        {
            using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexao))
            {
                comando.Parameters.AddWithValue("@nome", produto.Nome);
                comando.Parameters.AddWithValue("@categoria", produto.Categoria);
                comando.Parameters.AddWithValue("@preco", produto.Preco);
                comando.Parameters.AddWithValue("@quantidade", produto.Quantidade);
                comando.Parameters.AddWithValue("@id", produto.Id);

                comando.ExecuteNonQuery();
            }
        }
    }

    // ---------------------------------------------------------
    // DELETE - apaga um produto pelo id
    // ---------------------------------------------------------
    public void Excluir(int id)
    {
        string sql = "DELETE FROM produtos WHERE id = @id";

        using (NpgsqlConnection conexao = Conexao.AbrirConexao())
        {
            using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexao))
            {
                comando.Parameters.AddWithValue("@id", id);

                comando.ExecuteNonQuery();
            }
        }
    }
}
