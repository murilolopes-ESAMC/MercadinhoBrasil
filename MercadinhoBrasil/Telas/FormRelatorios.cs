using MercadinhoBrasil.Dados;
using MercadinhoBrasil.Modelos;

namespace MercadinhoBrasil.Telas;

public partial class FormRelatorios : Form
{
    private VendaDados vendaDados = new VendaDados();

    public FormRelatorios()
    {
        InitializeComponent();
    }

    private void FormRelatorios_Load(object sender, EventArgs e)
    {
        Estilo.ArrumarGrade(dgvVendas);
        Estilo.ArrumarGrade(dgvItens);

        dgvVendas.Columns.Add("Id", "Nº");
        dgvVendas.Columns.Add("Data", "Data e hora");
        dgvVendas.Columns.Add("Pagamento", "Pagamento");
        dgvVendas.Columns.Add("Total", "Total");
        dgvVendas.Columns["Id"].FillWeight = 40;
        dgvVendas.Columns["Data"].FillWeight = 130;

        dgvItens.Columns.Add("Produto", "Produto");
        dgvItens.Columns.Add("Quantidade", "Qtd");
        dgvItens.Columns.Add("Subtotal", "Subtotal");
        dgvItens.Columns["Produto"].FillWeight = 200;
        dgvItens.Columns["Quantidade"].FillWeight = 50;

        cmbPagamento.SelectedIndex = 0;

        MostrarEsteMes();
    }

    // ---------------------------------------------------------
    // Busca as vendas no banco usando os filtros escolhidos
    // ---------------------------------------------------------
    private void CarregarVendas()
    {
        try
        {
            List<Venda> vendas = vendaDados.Listar(dtpInicio.Value, dtpFim.Value, cmbPagamento.Text);

            dgvVendas.Rows.Clear();
            dgvItens.Rows.Clear();
            lblItens.Text = "Itens da venda (clique em uma venda)";

            decimal totalVendido = 0;

            foreach (Venda venda in vendas)
            {
                dgvVendas.Rows.Add(
                    venda.Id,
                    venda.DataVenda.ToString("dd/MM/yyyy HH:mm"),
                    venda.FormaPagamento,
                    venda.ValorTotal.ToString("C2"));

                totalVendido = totalVendido + venda.ValorTotal;
            }

            dgvVendas.ClearSelection();

            lblQuantidadeVendas.Text = vendas.Count.ToString();
            lblTotalVendido.Text = totalVendido.ToString("C2");

            if (vendas.Count > 0)
            {
                decimal media = totalVendido / vendas.Count;
                lblMedia.Text = media.ToString("C2");
            }
            else
            {
                lblMedia.Text = "R$ 0,00";
            }
        }
        catch (Exception erro)
        {
            MessageBox.Show("Erro ao carregar as vendas: " + erro.Message, "Relatórios",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void MostrarEsteMes()
    {
        DateTime hoje = DateTime.Today;

        dtpInicio.Value = new DateTime(hoje.Year, hoje.Month, 1);
        dtpFim.Value = hoje;

        CarregarVendas();
    }

    // ---------------------------------------------------------
    // Botões dos filtros
    // ---------------------------------------------------------
    private void btnFiltrar_Click(object sender, EventArgs e)
    {
        CarregarVendas();
    }

    private void btnHoje_Click(object sender, EventArgs e)
    {
        dtpInicio.Value = DateTime.Today;
        dtpFim.Value = DateTime.Today;

        CarregarVendas();
    }

    private void btnEsteMes_Click(object sender, EventArgs e)
    {
        MostrarEsteMes();
    }

    // ---------------------------------------------------------
    // Quando clica em uma venda, mostra os produtos dela ao lado
    // ---------------------------------------------------------
    private void dgvVendas_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
        {
            return;
        }

        int idDaVenda = Convert.ToInt32(dgvVendas.Rows[e.RowIndex].Cells["Id"].Value);

        try
        {
            List<ItemVenda> itens = vendaDados.ListarItens(idDaVenda);

            dgvItens.Rows.Clear();

            foreach (ItemVenda item in itens)
            {
                dgvItens.Rows.Add(
                    item.NomeProduto,
                    item.Quantidade,
                    item.Subtotal.ToString("C2"));
            }

            dgvItens.ClearSelection();
            lblItens.Text = "Itens da venda nº " + idDaVenda;
        }
        catch (Exception erro)
        {
            MessageBox.Show("Erro ao carregar os itens da venda: " + erro.Message, "Relatórios",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
