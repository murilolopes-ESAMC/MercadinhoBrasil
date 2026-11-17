using MercadinhoBrasil.Dados;

namespace MercadinhoBrasil.Telas;

public partial class FormPrincipal : Form
{
    private Form telaAtual = null;

    private bool arrastando = false;
    private Point posicaoDoClique;

    private Color corMenu = Color.Green;
    private Color corMenuSelecionado = Color.DarkGreen;

    public FormPrincipal()
    {
        InitializeComponent();
    }

    private void FormPrincipal_Load(object sender, EventArgs e)
    {
        string erro = Conexao.TestarConexao();

        if (erro != "")
        {
            MessageBox.Show(
                "Não foi possível conectar no banco de dados.\n\n"
                + "Confira se o PostgreSQL está ligado e se o script da pasta \"banco\" já foi executado.\n\n"
                + "Detalhe do erro: " + erro,
                "Mercadinho Brasil",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }

    // ---------------------------------------------------------
    // Abre uma tela dentro do painel do meio
    // ---------------------------------------------------------
    private void AbrirTela(Form novaTela, Button botaoDoMenu)
    {
        if (telaAtual != null)
        {
            telaAtual.Close();
        }

        telaAtual = novaTela;

        novaTela.TopLevel = false;
        novaTela.FormBorderStyle = FormBorderStyle.None;
        novaTela.Dock = DockStyle.Fill;

        pnlInicio.Visible = false;
        pnlConteudo.Controls.Add(novaTela);
        novaTela.Show();

        DestacarBotao(botaoDoMenu);
    }

    private void DestacarBotao(Button botaoDoMenu)
    {
        btnInicio.BackColor = corMenu;
        btnProdutos.BackColor = corMenu;
        btnVender.BackColor = corMenu;
        btnEstoque.BackColor = corMenu;
        btnRelatorios.BackColor = corMenu;

        botaoDoMenu.BackColor = corMenuSelecionado;
    }

    // ---------------------------------------------------------
    // Botões do menu (os cartões grandes do início usam os mesmos métodos)
    // ---------------------------------------------------------
    private void btnInicio_Click(object sender, EventArgs e)
    {
        if (telaAtual != null)
        {
            telaAtual.Close();
            telaAtual = null;
        }

        pnlInicio.Visible = true;
        DestacarBotao(btnInicio);
    }

    private void btnProdutos_Click(object sender, EventArgs e)
    {
        AbrirTela(new FormProdutos(), btnProdutos);
    }

    private void btnVender_Click(object sender, EventArgs e)
    {
        AbrirTela(new FormVender(), btnVender);
    }

    private void btnEstoque_Click(object sender, EventArgs e)
    {
        AbrirTela(new FormEstoque(), btnEstoque);
    }

    private void btnRelatorios_Click(object sender, EventArgs e)
    {
        AbrirTela(new FormRelatorios(), btnRelatorios);
    }

    private void btnSair_Click(object sender, EventArgs e)
    {
        DialogResult resposta = MessageBox.Show(
            "Deseja mesmo sair do sistema?",
            "Mercadinho Brasil",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (resposta == DialogResult.Yes)
        {
            Application.Exit();
        }
    }

    // ---------------------------------------------------------
    // Botões da barra de cima (minimizar e fechar)
    // ---------------------------------------------------------
    private void btnMinimizar_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }

    private void btnFechar_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    // ---------------------------------------------------------
    // Arrastar a janela segurando na barra de cima.
    // ---------------------------------------------------------
    private void pnlTopo_MouseDown(object sender, MouseEventArgs e)
    {
        arrastando = true;
        posicaoDoClique = e.Location;
    }

    private void pnlTopo_MouseMove(object sender, MouseEventArgs e)
    {
        if (arrastando == true)
        {
            int novoX = Location.X + e.X - posicaoDoClique.X;
            int novoY = Location.Y + e.Y - posicaoDoClique.Y;

            Location = new Point(novoX, novoY);
        }
    }

    private void pnlTopo_MouseUp(object sender, MouseEventArgs e)
    {
        arrastando = false;
    }
}
