using MercadinhoBrasil.Dados;
using MercadinhoBrasil.Modelos;
using Npgsql;

namespace MercadinhoBrasil.Telas;

public partial class FormVender : Form
{
    private ProdutoDados produtoDados = new ProdutoDados();
    private VendaDados vendaDados = new VendaDados();

    private Venda vendaAtual = new Venda();

    public FormVender()
    {
        InitializeComponent();
    }

    private void FormVender_Load(object sender, EventArgs e)
    {
        Estilo.ArrumarGrade(dgvCarrinho);

        dgvCarrinho.Columns.Add("Produto", "Produto");
        dgvCarrinho.Columns.Add("Quantidade", "Quantidade");
        dgvCarrinho.Columns.Add("Preco", "Preço unitário");
        dgvCarrinho.Columns.Add("Subtotal", "Subtotal");
        dgvCarrinho.Columns["Produto"].FillWeight = 250;

        cmbPagamento.SelectedIndex = 0;

        CarregarProdutos();
        AtualizarCarrinho();
    }

    private void CarregarProdutos()
    {
        try
        {
            List<Produto> produtos = produtoDados.Listar();

            cmbProduto.Items.Clear();

            foreach (Produto produto in produtos)
            {
                cmbProduto.Items.Add(produto);
            }

            cmbProduto.SelectedIndex = -1;
            lblPreco.Text = "R$ 0,00";
            lblEstoque.Text = "0";
        }
        catch (Exception erro)
        {
            MessageBox.Show("Erro ao carregar os produtos: " + erro.Message, "Vender",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cmbProduto.SelectedItem == null)
        {
            return;
        }

        Produto produto = (Produto)cmbProduto.SelectedItem;

        lblPreco.Text = produto.Preco.ToString("C2");
        lblEstoque.Text = produto.Quantidade.ToString();
        nudQuantidade.Value = 1;
    }

    // ---------------------------------------------------------
    // Botão "Adicionar": coloca o produto escolhido no carrinho
    // ---------------------------------------------------------
    private void btnAdicionar_Click(object sender, EventArgs e)
    {
        if (cmbProduto.SelectedItem == null)
        {
            MessageBox.Show("Escolha um produto.", "Vender",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        Produto produto = (Produto)cmbProduto.SelectedItem;
        int quantidade = Convert.ToInt32(nudQuantidade.Value);

        try
        {
            vendaAtual.AdicionarItem(produto, quantidade);

            AtualizarCarrinho();
            nudQuantidade.Value = 1;
        }
        catch (EstoqueInsuficienteException erro)
        {
            MessageBox.Show(erro.Message, "Vender",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (ArgumentException erro)
        {
            MessageBox.Show(erro.Message, "Vender",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void AtualizarCarrinho()
    {
        dgvCarrinho.Rows.Clear();

        foreach (ItemVenda item in vendaAtual.Itens)
        {
            dgvCarrinho.Rows.Add(
                item.NomeProduto,
                item.Quantidade,
                item.PrecoUnitario.ToString("C2"),
                item.Subtotal.ToString("C2"));
        }

        dgvCarrinho.ClearSelection();
        lblTotal.Text = vendaAtual.ValorTotal.ToString("C2");
    }

    private void btnRemover_Click(object sender, EventArgs e)
    {
        if (dgvCarrinho.SelectedRows.Count == 0)
        {
            MessageBox.Show("Clique em um item do carrinho primeiro.", "Vender",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        int posicao = dgvCarrinho.SelectedRows[0].Index;
        vendaAtual.RemoverItem(posicao);

        AtualizarCarrinho();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        if (vendaAtual.Itens.Count == 0)
        {
            return;
        }

        DialogResult resposta = MessageBox.Show(
            "Deseja cancelar esta venda e esvaziar o carrinho?",
            "Vender",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (resposta == DialogResult.Yes)
        {
            vendaAtual = new Venda();
            AtualizarCarrinho();
        }
    }

    // ---------------------------------------------------------
    // Botão "Finalizar venda": grava a venda no banco
    // ---------------------------------------------------------
    private void btnFinalizar_Click(object sender, EventArgs e)
    {
        if (vendaAtual.Itens.Count == 0)
        {
            MessageBox.Show("O carrinho está vazio.", "Vender",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        vendaAtual.DataVenda = DateTime.Now;
        vendaAtual.FormaPagamento = cmbPagamento.Text;

        DialogResult resposta = MessageBox.Show(
            "Confirmar a venda?\n\n"
            + "Total: " + vendaAtual.ValorTotal.ToString("C2") + "\n"
            + "Pagamento: " + vendaAtual.FormaPagamento,
            "Vender",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (resposta == DialogResult.No)
        {
            return;
        }

        try
        {
            vendaDados.Salvar(vendaAtual);

            MessageBox.Show("Venda realizada com sucesso!", "Vender",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            vendaAtual = new Venda();
            AtualizarCarrinho();
            CarregarProdutos();
        }
        catch (NpgsqlException erro)
        {
            MessageBox.Show("Erro no banco de dados ao gravar a venda: " + erro.Message, "Vender",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception erro)
        {
            MessageBox.Show("Erro inesperado ao gravar a venda: " + erro.Message, "Vender",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
