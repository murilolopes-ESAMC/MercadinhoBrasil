using MercadinhoBrasil.Dados;
using MercadinhoBrasil.Modelos;
using Npgsql;

namespace MercadinhoBrasil.Telas;

public partial class FormProdutos : Form
{
    private ProdutoDados produtoDados = new ProdutoDados();

    private int idSelecionado = 0;

    public FormProdutos()
    {
        InitializeComponent();
    }

    private void FormProdutos_Load(object sender, EventArgs e)
    {
        Estilo.ArrumarGrade(dgvProdutos);

        dgvProdutos.Columns.Add("Id", "Código");
        dgvProdutos.Columns.Add("Nome", "Nome");
        dgvProdutos.Columns.Add("Categoria", "Categoria");
        dgvProdutos.Columns.Add("Preco", "Preço");
        dgvProdutos.Columns.Add("Quantidade", "Quantidade");

        dgvProdutos.Columns["Nome"].FillWeight = 250;

        CarregarProdutos("");
        LimparCampos();
    }

    // ---------------------------------------------------------
    // READ - busca os produtos no banco e mostra na tabela
    // ---------------------------------------------------------
    private void CarregarProdutos(string textoDaBusca)
    {
        try
        {
            List<Produto> produtos = produtoDados.Buscar(textoDaBusca);

            dgvProdutos.Rows.Clear();

            foreach (Produto produto in produtos)
            {
                dgvProdutos.Rows.Add(
                    produto.Id,
                    produto.Nome,
                    produto.Categoria,
                    produto.Preco.ToString("C2"),
                    produto.Quantidade);
            }

            dgvProdutos.ClearSelection();
        }
        catch (Exception erro)
        {
            MessageBox.Show("Erro ao carregar os produtos: " + erro.Message, "Produtos",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LimparCampos()
    {
        idSelecionado = 0;

        txtNome.Text = "";
        cmbCategoria.SelectedIndex = -1;
        cmbCategoria.Text = "";
        txtPreco.Text = "";
        nudQuantidade.Value = 0;

        lblModo.Text = "Cadastrando um produto novo";
        btnExcluir.Enabled = false;
        dgvProdutos.ClearSelection();
        txtNome.Focus();
    }

    // ---------------------------------------------------------
    // Quando clica em uma linha da tabela, joga os dados nos campos
    // ---------------------------------------------------------
    private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
        {
            return;
        }

        DataGridViewRow linha = dgvProdutos.Rows[e.RowIndex];

        idSelecionado = Convert.ToInt32(linha.Cells["Id"].Value);
        txtNome.Text = linha.Cells["Nome"].Value.ToString();
        cmbCategoria.Text = linha.Cells["Categoria"].Value.ToString();

        string precoDaTabela = linha.Cells["Preco"].Value.ToString();
        txtPreco.Text = precoDaTabela.Replace("R$", "").Trim();

        nudQuantidade.Value = Convert.ToInt32(linha.Cells["Quantidade"].Value);

        lblModo.Text = "Alterando o produto de código " + idSelecionado;
        btnExcluir.Enabled = true;
    }

    // ---------------------------------------------------------
    // CREATE e UPDATE - botão Salvar
    // ---------------------------------------------------------
    private void btnSalvar_Click(object sender, EventArgs e)
    {
        int quantidade = Convert.ToInt32(nudQuantidade.Value);

        try
        {
            decimal preco = decimal.Parse(txtPreco.Text);

            Produto produto = new Produto(txtNome.Text, cmbCategoria.Text, preco, quantidade);
            produto.Id = idSelecionado;

            if (idSelecionado == 0)
            {
                produtoDados.Inserir(produto);
                MessageBox.Show("Produto cadastrado com sucesso!", "Produtos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                produtoDados.Atualizar(produto);
                MessageBox.Show("Produto alterado com sucesso!", "Produtos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtBuscar.Text = "";
            CarregarProdutos("");
            LimparCampos();
        }
        catch (ArgumentException erro)
        {
            MessageBox.Show(erro.Message, "Produtos",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (NpgsqlException erro)
        {
            MessageBox.Show("Erro no banco de dados ao salvar o produto: " + erro.Message, "Produtos",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception erro)
        {
            MessageBox.Show("Erro inesperado ao salvar o produto: " + erro.Message, "Produtos",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // ---------------------------------------------------------
    // DELETE - botão Excluir
    // ---------------------------------------------------------
    private void btnExcluir_Click(object sender, EventArgs e)
    {
        if (idSelecionado == 0)
        {
            MessageBox.Show("Clique em um produto da lista primeiro.", "Produtos",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        DialogResult resposta = MessageBox.Show(
            "Deseja mesmo excluir o produto \"" + txtNome.Text + "\"?",
            "Produtos",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (resposta == DialogResult.No)
        {
            return;
        }

        produtoDados.Excluir(idSelecionado);

        MessageBox.Show("Produto excluído com sucesso!", "Produtos",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

        CarregarProdutos(txtBuscar.Text);
        LimparCampos();
    }

    private void btnNovo_Click(object sender, EventArgs e)
    {
        LimparCampos();
    }

    // ---------------------------------------------------------
    // Busca por nome
    // ---------------------------------------------------------
    private void btnBuscar_Click(object sender, EventArgs e)
    {
        CarregarProdutos(txtBuscar.Text.Trim());
    }

    private void btnMostrarTodos_Click(object sender, EventArgs e)
    {
        txtBuscar.Text = "";
        CarregarProdutos("");
    }
}
