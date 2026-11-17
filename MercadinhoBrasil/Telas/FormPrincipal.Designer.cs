namespace MercadinhoBrasil.Telas;

partial class FormPrincipal
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        pnlTopo = new Panel();
        lblTituloJanela = new Label();
        btnMinimizar = new Button();
        btnFechar = new Button();
        pnlMenu = new Panel();
        lblLogo = new Label();
        btnInicio = new Button();
        btnProdutos = new Button();
        btnVender = new Button();
        btnEstoque = new Button();
        btnRelatorios = new Button();
        btnSair = new Button();
        pnlConteudo = new Panel();
        pnlInicio = new Panel();
        lblBemVindo = new Label();
        lblEscolha = new Label();
        btnCartaoProdutos = new Button();
        btnCartaoVender = new Button();
        btnCartaoEstoque = new Button();
        btnCartaoRelatorios = new Button();
        lblRodape = new Label();
        pnlTopo.SuspendLayout();
        pnlMenu.SuspendLayout();
        pnlConteudo.SuspendLayout();
        pnlInicio.SuspendLayout();
        SuspendLayout();
        //
        // pnlTopo
        //
        pnlTopo.BackColor = Color.Navy;
        pnlTopo.Controls.Add(lblTituloJanela);
        pnlTopo.Controls.Add(btnMinimizar);
        pnlTopo.Controls.Add(btnFechar);
        pnlTopo.Dock = DockStyle.Top;
        pnlTopo.Location = new Point(0, 0);
        pnlTopo.Name = "pnlTopo";
        pnlTopo.Size = new Size(1100, 40);
        pnlTopo.TabIndex = 0;
        pnlTopo.MouseDown += pnlTopo_MouseDown;
        pnlTopo.MouseMove += pnlTopo_MouseMove;
        pnlTopo.MouseUp += pnlTopo_MouseUp;
        //
        // lblTituloJanela
        //
        lblTituloJanela.AutoSize = true;
        lblTituloJanela.Font = new Font("Times New Roman", 11F, FontStyle.Italic);
        lblTituloJanela.ForeColor = Color.White;
        lblTituloJanela.Location = new Point(12, 10);
        lblTituloJanela.Name = "lblTituloJanela";
        lblTituloJanela.Size = new Size(260, 19);
        lblTituloJanela.TabIndex = 0;
        lblTituloJanela.Text = "Mercadinho Brasil - Sistema de Mercado";
        lblTituloJanela.MouseDown += pnlTopo_MouseDown;
        lblTituloJanela.MouseMove += pnlTopo_MouseMove;
        lblTituloJanela.MouseUp += pnlTopo_MouseUp;
        //
        // btnMinimizar
        //
        btnMinimizar.Dock = DockStyle.Right;
        btnMinimizar.FlatAppearance.BorderSize = 0;
        btnMinimizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 110, 55);
        btnMinimizar.FlatStyle = FlatStyle.Flat;
        btnMinimizar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnMinimizar.ForeColor = Color.White;
        btnMinimizar.Location = new Point(1004, 0);
        btnMinimizar.Name = "btnMinimizar";
        btnMinimizar.Size = new Size(48, 40);
        btnMinimizar.TabIndex = 1;
        btnMinimizar.Text = "_";
        btnMinimizar.UseVisualStyleBackColor = false;
        btnMinimizar.Click += btnMinimizar_Click;
        //
        // btnFechar
        //
        btnFechar.Dock = DockStyle.Right;
        btnFechar.FlatAppearance.BorderSize = 0;
        btnFechar.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 50, 50);
        btnFechar.FlatStyle = FlatStyle.Flat;
        btnFechar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnFechar.ForeColor = Color.White;
        btnFechar.Location = new Point(1052, 0);
        btnFechar.Name = "btnFechar";
        btnFechar.Size = new Size(48, 40);
        btnFechar.TabIndex = 2;
        btnFechar.Text = "X";
        btnFechar.UseVisualStyleBackColor = false;
        btnFechar.Click += btnFechar_Click;
        //
        // pnlMenu
        //
        pnlMenu.BackColor = Color.Green;
        pnlMenu.Controls.Add(lblLogo);
        pnlMenu.Controls.Add(btnInicio);
        pnlMenu.Controls.Add(btnProdutos);
        pnlMenu.Controls.Add(btnVender);
        pnlMenu.Controls.Add(btnEstoque);
        pnlMenu.Controls.Add(btnRelatorios);
        pnlMenu.Controls.Add(btnSair);
        pnlMenu.Dock = DockStyle.Left;
        pnlMenu.Location = new Point(0, 40);
        pnlMenu.Name = "pnlMenu";
        pnlMenu.Size = new Size(210, 660);
        pnlMenu.TabIndex = 1;
        //
        // lblLogo
        //
        lblLogo.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
        lblLogo.ForeColor = Color.Yellow;
        lblLogo.Location = new Point(0, 15);
        lblLogo.Name = "lblLogo";
        lblLogo.Size = new Size(210, 80);
        lblLogo.TabIndex = 0;
        lblLogo.Text = "Mercadinho\r\nBrasil";
        lblLogo.TextAlign = ContentAlignment.MiddleCenter;
        //
        // btnInicio
        //
        btnInicio.BackColor = Color.DarkGreen;
        btnInicio.FlatAppearance.BorderSize = 0;
        btnInicio.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
        btnInicio.FlatStyle = FlatStyle.Flat;
        btnInicio.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
        btnInicio.ForeColor = Color.White;
        btnInicio.Location = new Point(0, 120);
        btnInicio.Name = "btnInicio";
        btnInicio.Padding = new Padding(20, 0, 0, 0);
        btnInicio.Size = new Size(210, 52);
        btnInicio.TabIndex = 1;
        btnInicio.Text = "Início";
        btnInicio.TextAlign = ContentAlignment.MiddleLeft;
        btnInicio.UseVisualStyleBackColor = false;
        btnInicio.Click += btnInicio_Click;
        //
        // btnProdutos
        //
        btnProdutos.BackColor = Color.Green;
        btnProdutos.FlatAppearance.BorderSize = 0;
        btnProdutos.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
        btnProdutos.FlatStyle = FlatStyle.Flat;
        btnProdutos.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
        btnProdutos.ForeColor = Color.White;
        btnProdutos.Location = new Point(0, 172);
        btnProdutos.Name = "btnProdutos";
        btnProdutos.Padding = new Padding(20, 0, 0, 0);
        btnProdutos.Size = new Size(210, 52);
        btnProdutos.TabIndex = 2;
        btnProdutos.Text = "Produtos";
        btnProdutos.TextAlign = ContentAlignment.MiddleLeft;
        btnProdutos.UseVisualStyleBackColor = false;
        btnProdutos.Click += btnProdutos_Click;
        //
        // btnVender
        //
        btnVender.BackColor = Color.Green;
        btnVender.FlatAppearance.BorderSize = 0;
        btnVender.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
        btnVender.FlatStyle = FlatStyle.Flat;
        btnVender.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
        btnVender.ForeColor = Color.White;
        btnVender.Location = new Point(0, 224);
        btnVender.Name = "btnVender";
        btnVender.Padding = new Padding(20, 0, 0, 0);
        btnVender.Size = new Size(210, 52);
        btnVender.TabIndex = 3;
        btnVender.Text = "Vender";
        btnVender.TextAlign = ContentAlignment.MiddleLeft;
        btnVender.UseVisualStyleBackColor = false;
        btnVender.Click += btnVender_Click;
        //
        // btnEstoque
        //
        btnEstoque.BackColor = Color.Green;
        btnEstoque.FlatAppearance.BorderSize = 0;
        btnEstoque.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
        btnEstoque.FlatStyle = FlatStyle.Flat;
        btnEstoque.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
        btnEstoque.ForeColor = Color.White;
        btnEstoque.Location = new Point(0, 276);
        btnEstoque.Name = "btnEstoque";
        btnEstoque.Padding = new Padding(20, 0, 0, 0);
        btnEstoque.Size = new Size(210, 52);
        btnEstoque.TabIndex = 4;
        btnEstoque.Text = "Estoque";
        btnEstoque.TextAlign = ContentAlignment.MiddleLeft;
        btnEstoque.UseVisualStyleBackColor = false;
        btnEstoque.Click += btnEstoque_Click;
        //
        // btnRelatorios
        //
        btnRelatorios.BackColor = Color.Green;
        btnRelatorios.FlatAppearance.BorderSize = 0;
        btnRelatorios.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
        btnRelatorios.FlatStyle = FlatStyle.Flat;
        btnRelatorios.Font = new Font("Arial", 11F, FontStyle.Bold);
        btnRelatorios.ForeColor = Color.White;
        btnRelatorios.Location = new Point(0, 328);
        btnRelatorios.Name = "btnRelatorios";
        btnRelatorios.Padding = new Padding(20, 0, 0, 0);
        btnRelatorios.Size = new Size(210, 52);
        btnRelatorios.TabIndex = 5;
        btnRelatorios.Text = "Relatórios";
        btnRelatorios.TextAlign = ContentAlignment.MiddleLeft;
        btnRelatorios.UseVisualStyleBackColor = false;
        btnRelatorios.Click += btnRelatorios_Click;
        //
        // btnSair
        //
        btnSair.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnSair.BackColor = Color.Red;
        btnSair.FlatAppearance.BorderSize = 0;
        btnSair.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
        btnSair.FlatStyle = FlatStyle.Flat;
        btnSair.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
        btnSair.ForeColor = Color.White;
        btnSair.Location = new Point(0, 608);
        btnSair.Name = "btnSair";
        btnSair.Padding = new Padding(20, 0, 0, 0);
        btnSair.Size = new Size(210, 52);
        btnSair.TabIndex = 6;
        btnSair.Text = "Sair";
        btnSair.TextAlign = ContentAlignment.MiddleLeft;
        btnSair.UseVisualStyleBackColor = false;
        btnSair.Click += btnSair_Click;
        //
        // pnlConteudo
        //
        pnlConteudo.BackColor = SystemColors.Control;
        pnlConteudo.Controls.Add(pnlInicio);
        pnlConteudo.Dock = DockStyle.Fill;
        pnlConteudo.Location = new Point(210, 40);
        pnlConteudo.Name = "pnlConteudo";
        pnlConteudo.Size = new Size(890, 660);
        pnlConteudo.TabIndex = 2;
        //
        // pnlInicio
        //
        pnlInicio.Controls.Add(lblBemVindo);
        pnlInicio.Controls.Add(lblEscolha);
        pnlInicio.Controls.Add(btnCartaoProdutos);
        pnlInicio.Controls.Add(btnCartaoVender);
        pnlInicio.Controls.Add(btnCartaoEstoque);
        pnlInicio.Controls.Add(btnCartaoRelatorios);
        pnlInicio.Controls.Add(lblRodape);
        pnlInicio.Dock = DockStyle.Fill;
        pnlInicio.Location = new Point(0, 0);
        pnlInicio.Name = "pnlInicio";
        pnlInicio.Size = new Size(890, 660);
        pnlInicio.TabIndex = 0;
        //
        // lblBemVindo
        //
        lblBemVindo.AutoSize = true;
        lblBemVindo.Font = new Font("Arial", 20F, FontStyle.Bold);
        lblBemVindo.ForeColor = Color.Blue;
        lblBemVindo.Location = new Point(38, 30);
        lblBemVindo.Name = "lblBemVindo";
        lblBemVindo.Size = new Size(520, 41);
        lblBemVindo.TabIndex = 0;
        lblBemVindo.Text = "Bem-vindo ao Mercadinho Brasil!";
        //
        // lblEscolha
        //
        lblEscolha.AutoSize = true;
        lblEscolha.Font = new Font("Times New Roman", 11F);
        lblEscolha.ForeColor = Color.Black;
        lblEscolha.Location = new Point(42, 80);
        lblEscolha.Name = "lblEscolha";
        lblEscolha.Size = new Size(300, 21);
        lblEscolha.TabIndex = 1;
        lblEscolha.Text = "Escolha uma das opções abaixo para começar:";
        //
        // btnCartaoProdutos
        //
        btnCartaoProdutos.BackColor = Color.Red;
        btnCartaoProdutos.Cursor = Cursors.Hand;
        btnCartaoProdutos.FlatAppearance.BorderSize = 0;
        btnCartaoProdutos.FlatStyle = FlatStyle.Flat;
        btnCartaoProdutos.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
        btnCartaoProdutos.ForeColor = Color.White;
        btnCartaoProdutos.Location = new Point(42, 135);
        btnCartaoProdutos.Name = "btnCartaoProdutos";
        btnCartaoProdutos.Size = new Size(390, 200);
        btnCartaoProdutos.TabIndex = 2;
        btnCartaoProdutos.Text = "PRODUTOS\r\n\r\nCadastrar, alterar e excluir";
        btnCartaoProdutos.UseVisualStyleBackColor = false;
        btnCartaoProdutos.Click += btnProdutos_Click;
        //
        // btnCartaoVender
        //
        btnCartaoVender.BackColor = Color.Blue;
        btnCartaoVender.Cursor = Cursors.Hand;
        btnCartaoVender.FlatAppearance.BorderSize = 0;
        btnCartaoVender.FlatStyle = FlatStyle.Flat;
        btnCartaoVender.Font = new Font("Arial", 14F, FontStyle.Bold);
        btnCartaoVender.ForeColor = Color.White;
        btnCartaoVender.Location = new Point(458, 142);
        btnCartaoVender.Name = "btnCartaoVender";
        btnCartaoVender.Size = new Size(390, 200);
        btnCartaoVender.TabIndex = 3;
        btnCartaoVender.Text = "VENDER\r\n\r\nPassar produtos no caixa";
        btnCartaoVender.UseVisualStyleBackColor = false;
        btnCartaoVender.Click += btnVender_Click;
        //
        // btnCartaoEstoque
        //
        btnCartaoEstoque.BackColor = Color.Yellow;
        btnCartaoEstoque.Cursor = Cursors.Hand;
        btnCartaoEstoque.FlatAppearance.BorderSize = 0;
        btnCartaoEstoque.FlatStyle = FlatStyle.Flat;
        btnCartaoEstoque.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
        btnCartaoEstoque.ForeColor = Color.White;
        btnCartaoEstoque.Location = new Point(42, 361);
        btnCartaoEstoque.Name = "btnCartaoEstoque";
        btnCartaoEstoque.Size = new Size(390, 200);
        btnCartaoEstoque.TabIndex = 4;
        btnCartaoEstoque.Text = "ESTOQUE\r\n\r\nVer quantidades e dar entrada";
        btnCartaoEstoque.UseVisualStyleBackColor = false;
        btnCartaoEstoque.Click += btnEstoque_Click;
        //
        // btnCartaoRelatorios
        //
        btnCartaoRelatorios.BackColor = Color.Purple;
        btnCartaoRelatorios.Cursor = Cursors.Hand;
        btnCartaoRelatorios.FlatAppearance.BorderSize = 0;
        btnCartaoRelatorios.FlatStyle = FlatStyle.Flat;
        btnCartaoRelatorios.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
        btnCartaoRelatorios.ForeColor = Color.White;
        btnCartaoRelatorios.Location = new Point(458, 361);
        btnCartaoRelatorios.Name = "btnCartaoRelatorios";
        btnCartaoRelatorios.Size = new Size(365, 180);
        btnCartaoRelatorios.TabIndex = 5;
        btnCartaoRelatorios.Text = "RELATÓRIOS\r\n\r\nVer as vendas por período";
        btnCartaoRelatorios.UseVisualStyleBackColor = false;
        btnCartaoRelatorios.Click += btnRelatorios_Click;
        //
        // lblRodape
        //
        lblRodape.AutoSize = true;
        lblRodape.Font = new Font("Comic Sans MS", 8F, FontStyle.Regular);
        lblRodape.ForeColor = Color.FromArgb(130, 130, 130);
        lblRodape.Location = new Point(42, 610);
        lblRodape.Name = "lblRodape";
        lblRodape.Size = new Size(300, 15);
        lblRodape.TabIndex = 6;
        lblRodape.Text = "Projeto Final de POO I  -  Mercadinho Brasil";
        //
        // FormPrincipal
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1100, 700);
        Controls.Add(pnlConteudo);
        Controls.Add(pnlMenu);
        Controls.Add(pnlTopo);
        FormBorderStyle = FormBorderStyle.None;
        Name = "FormPrincipal";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Mercadinho Brasil";
        Load += FormPrincipal_Load;
        pnlTopo.ResumeLayout(false);
        pnlTopo.PerformLayout();
        pnlMenu.ResumeLayout(false);
        pnlConteudo.ResumeLayout(false);
        pnlInicio.ResumeLayout(false);
        pnlInicio.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Panel pnlTopo;
    private Label lblTituloJanela;
    private Button btnMinimizar;
    private Button btnFechar;
    private Panel pnlMenu;
    private Label lblLogo;
    private Button btnInicio;
    private Button btnProdutos;
    private Button btnVender;
    private Button btnEstoque;
    private Button btnRelatorios;
    private Button btnSair;
    private Panel pnlConteudo;
    private Panel pnlInicio;
    private Label lblBemVindo;
    private Label lblEscolha;
    private Button btnCartaoProdutos;
    private Button btnCartaoVender;
    private Button btnCartaoEstoque;
    private Button btnCartaoRelatorios;
    private Label lblRodape;
}
