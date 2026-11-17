using MercadinhoBrasil.Dados;
using MercadinhoBrasil.Modelos;
using Npgsql;

namespace MercadinhoBrasil.Telas;

public partial class FormEstoque : Form
{
    private ProdutoDados produtoDados = new ProdutoDados();

    private int idSelecionado = 0;

    public FormEstoque()
    {
        InitializeComponent();
    }

    private void FormEstoque_Load(object sender, EventArgs e)
    {
        Estilo.ArrumarGrade(dgvEstoque);

        dgvEstoque.Columns.Add("Id", "Código");
        dgvEstoque.Columns.Add("Nome", "Produto");
        dgvEstoque.Columns.Add("Categoria", "Categoria");
        dgvEstoque.Columns.Add("Quantidade", "Quantidade");
        dgvEstoque.Columns.Add("Valor", "Valor total");
        dgvEstoque.Columns.Add("Situacao", "Situação");
        dgvEstoque.Columns["Nome"].FillWeight = 220;

        CarregarEstoque();
    }

    private void CarregarEstoque()
    {
        try
        {
            List<Produto> produtos = produtoDados.Listar();

            dgvEstoque.Rows.Clear();

            int totalDeItens = 0;
            decimal valorTotal = 0;
            int produtosComEstoqueBaixo = 0;

            foreach (Produto produto in produtos)
            {
                totalDeItens = totalDeItens + produto.Quantidade;
                valorTotal = valorTotal + produto.ValorEmEstoque;

                if (produto.EstoqueBaixo == true)
                {
                    produtosComEstoqueBaixo = produtosComEstoqueBaixo + 1;
                }

                if (chkEstoqueBaixo.Checked == true && produto.EstoqueBaixo == false)
                {
                    continue;
                }

                string situacao = "OK";

                if (produto.Quantidade == 0)
                {
                    situacao = "SEM ESTOQUE";
                }
                else if (produto.EstoqueBaixo == true)
                {
                    situacao = "Estoque baixo";
                }

                int posicao = dgvEstoque.Rows.Add(
                    produto.Id,
                    produto.Nome,
                    produto.Categoria,
                    produto.Quantidade,
                    produto.ValorEmEstoque.ToString("C2"),
                    situacao);

                if (produto.EstoqueBaixo == true)
                {
                    dgvEstoque.Rows[posicao].DefaultCellStyle.BackColor = Color.FromArgb(255, 220, 220);
                }
            }

            dgvEstoque.ClearSelection();

            lblTotalProdutos.Text = produtos.Count.ToString();
            lblTotalItens.Text = totalDeItens.ToString();
            lblValorEstoque.Text = valorTotal.ToString("C2");
            lblEstoqueBaixo.Text = produtosComEstoqueBaixo.ToString();

            idSelecionado = 0;
            lblSelecionado.Text = "Produto selecionado: (clique em um produto da lista)";
        }
        catch (Exception erro)
        {
            MessageBox.Show("Erro ao carregar o estoque: " + erro.Message, "Estoque",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void chkEstoqueBaixo_CheckedChanged(object sender, EventArgs e)
    {
        CarregarEstoque();
    }

    private void dgvEstoque_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
        {
            return;
        }

        DataGridViewRow linha = dgvEstoque.Rows[e.RowIndex];

        idSelecionado = Convert.ToInt32(linha.Cells["Id"].Value);
        lblSelecionado.Text = "Produto selecionado: " + linha.Cells["Nome"].Value.ToString();
    }

    // ---------------------------------------------------------
    // Botão "Adicionar ao estoque": entrada de mercadoria
    // ---------------------------------------------------------
    private void btnAdicionarEstoque_Click(object sender, EventArgs e)
    {
        if (idSelecionado == 0)
        {
            MessageBox.Show("Clique em um produto da lista primeiro.", "Estoque",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        int quantidade = Convert.ToInt32(nudEntrada.Value);

        try
        {
            Produto produto = produtoDados.BuscarPorId(idSelecionado);

            if (produto == null)
            {
                MessageBox.Show("Este produto não existe mais no cadastro.", "Estoque",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CarregarEstoque();
                return;
            }

            produto.AdicionarEstoque(quantidade);
            produtoDados.Atualizar(produto);

            MessageBox.Show("Entrada registrada! Foram adicionadas " + quantidade + " unidades.", "Estoque",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            nudEntrada.Value = 1;
            CarregarEstoque();
        }
        catch (ArgumentException erro)
        {
            MessageBox.Show(erro.Message, "Estoque",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (NpgsqlException erro)
        {
            MessageBox.Show("Erro no banco de dados ao dar entrada no estoque: " + erro.Message, "Estoque",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception erro)
        {
            MessageBox.Show("Erro inesperado ao dar entrada no estoque: " + erro.Message, "Estoque",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
