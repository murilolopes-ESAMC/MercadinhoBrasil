namespace MercadinhoBrasil.Telas;

partial class FormRelatorios
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
        lblTitulo = new Label();
        pnlFiltros = new Panel();
        lblInicio = new Label();
        dtpInicio = new DateTimePicker();
        lblFim = new Label();
        dtpFim = new DateTimePicker();
        lblPagamento = new Label();
        cmbPagamento = new ComboBox();
        btnFiltrar = new Button();
        btnHoje = new Button();
        btnEsteMes = new Button();
        lblVendas = new Label();
        dgvVendas = new DataGridView();
        lblItens = new Label();
        dgvItens = new DataGridView();
        pnlResumo = new Panel();
        lblQuantidadeVendasTitulo = new Label();
        lblQuantidadeVendas = new Label();
        lblTotalVendidoTitulo = new Label();
        lblTotalVendido = new Label();
        lblMediaTitulo = new Label();
        lblMedia = new Label();
        pnlFiltros.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvVendas).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvItens).BeginInit();
        pnlResumo.SuspendLayout();
        SuspendLayout();
        //
        // lblTitulo
        //
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.Black;
        lblTitulo.Location = new Point(20, 18);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(260, 32);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Relatórios de vendas";
        //
        // pnlFiltros
        //
        pnlFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        pnlFiltros.BackColor = Color.LightGray;
        pnlFiltros.Controls.Add(lblInicio);
        pnlFiltros.Controls.Add(dtpInicio);
        pnlFiltros.Controls.Add(lblFim);
        pnlFiltros.Controls.Add(dtpFim);
        pnlFiltros.Controls.Add(lblPagamento);
        pnlFiltros.Controls.Add(cmbPagamento);
        pnlFiltros.Controls.Add(btnFiltrar);
        pnlFiltros.Controls.Add(btnHoje);
        pnlFiltros.Controls.Add(btnEsteMes);
        pnlFiltros.Location = new Point(25, 65);
        pnlFiltros.Name = "pnlFiltros";
        pnlFiltros.Size = new Size(840, 85);
        pnlFiltros.TabIndex = 1;
        //
        // lblInicio
        //
        lblInicio.AutoSize = true;
        lblInicio.Location = new Point(15, 12);
        lblInicio.Name = "lblInicio";
        lblInicio.Size = new Size(78, 19);
        lblInicio.TabIndex = 0;
        lblInicio.Text = "Data inicial:";
        //
        // dtpInicio
        //
        dtpInicio.Font = new Font("Segoe UI", 11F);
        dtpInicio.Format = DateTimePickerFormat.Short;
        dtpInicio.Location = new Point(15, 37);
        dtpInicio.Name = "dtpInicio";
        dtpInicio.Size = new Size(135, 27);
        dtpInicio.TabIndex = 1;
        //
        // lblFim
        //
        lblFim.AutoSize = true;
        lblFim.Location = new Point(165, 12);
        lblFim.Name = "lblFim";
        lblFim.Size = new Size(70, 19);
        lblFim.TabIndex = 2;
        lblFim.Text = "Data final:";
        //
        // dtpFim
        //
        dtpFim.Font = new Font("Segoe UI", 11F);
        dtpFim.Format = DateTimePickerFormat.Short;
        dtpFim.Location = new Point(165, 37);
        dtpFim.Name = "dtpFim";
        dtpFim.Size = new Size(135, 27);
        dtpFim.TabIndex = 3;
        //
        // lblPagamento
        //
        lblPagamento.AutoSize = true;
        lblPagamento.Location = new Point(315, 12);
        lblPagamento.Name = "lblPagamento";
        lblPagamento.Size = new Size(140, 19);
        lblPagamento.TabIndex = 4;
        lblPagamento.Text = "Forma de pagamento:";
        //
        // cmbPagamento
        //
        cmbPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbPagamento.Font = new Font("Segoe UI", 11F);
        cmbPagamento.FormattingEnabled = true;
        cmbPagamento.Items.AddRange(new object[] { "Todas", "Dinheiro", "Pix", "Cartão de Débito", "Cartão de Crédito" });
        cmbPagamento.Location = new Point(315, 37);
        cmbPagamento.Name = "cmbPagamento";
        cmbPagamento.Size = new Size(185, 28);
        cmbPagamento.TabIndex = 5;
        //
        // btnFiltrar
        //
        btnFiltrar.BackColor = Color.Purple;
        btnFiltrar.FlatAppearance.BorderSize = 0;
        btnFiltrar.FlatStyle = FlatStyle.Flat;
        btnFiltrar.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
        btnFiltrar.ForeColor = Color.White;
        btnFiltrar.Location = new Point(520, 28);
        btnFiltrar.Name = "btnFiltrar";
        btnFiltrar.Size = new Size(110, 40);
        btnFiltrar.TabIndex = 6;
        btnFiltrar.Text = "Filtrar";
        btnFiltrar.UseVisualStyleBackColor = false;
        btnFiltrar.Click += btnFiltrar_Click;
        //
        // btnHoje
        //
        btnHoje.Location = new Point(640, 28);
        btnHoje.Name = "btnHoje";
        btnHoje.Size = new Size(80, 40);
        btnHoje.TabIndex = 7;
        btnHoje.Text = "Hoje";
        btnHoje.UseVisualStyleBackColor = true;
        btnHoje.Click += btnHoje_Click;
        //
        // btnEsteMes
        //
        btnEsteMes.Location = new Point(730, 28);
        btnEsteMes.Name = "btnEsteMes";
        btnEsteMes.Size = new Size(95, 40);
        btnEsteMes.TabIndex = 8;
        btnEsteMes.Text = "Este mês";
        btnEsteMes.UseVisualStyleBackColor = true;
        btnEsteMes.Click += btnEsteMes_Click;
        //
        // lblVendas
        //
        lblVendas.AutoSize = true;
        lblVendas.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
        lblVendas.Location = new Point(22, 163);
        lblVendas.Name = "lblVendas";
        lblVendas.Size = new Size(150, 21);
        lblVendas.TabIndex = 2;
        lblVendas.Text = "Vendas do período";
        //
        // dgvVendas
        //
        dgvVendas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        dgvVendas.Location = new Point(25, 190);
        dgvVendas.Name = "dgvVendas";
        dgvVendas.Size = new Size(480, 345);
        dgvVendas.TabIndex = 3;
        dgvVendas.CellClick += dgvVendas_CellClick;
        //
        // lblItens
        //
        lblItens.AutoSize = true;
        lblItens.Font = new Font("Arial", 10F, FontStyle.Bold);
        lblItens.Location = new Point(522, 163);
        lblItens.Name = "lblItens";
        lblItens.Size = new Size(300, 21);
        lblItens.TabIndex = 4;
        lblItens.Text = "Itens da venda (clique em uma venda)";
        //
        // dgvItens
        //
        dgvItens.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvItens.Location = new Point(525, 190);
        dgvItens.Name = "dgvItens";
        dgvItens.Size = new Size(340, 345);
        dgvItens.TabIndex = 5;
        //
        // pnlResumo
        //
        pnlResumo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pnlResumo.BackColor = Color.LightYellow;
        pnlResumo.Controls.Add(lblQuantidadeVendasTitulo);
        pnlResumo.Controls.Add(lblQuantidadeVendas);
        pnlResumo.Controls.Add(lblTotalVendidoTitulo);
        pnlResumo.Controls.Add(lblTotalVendido);
        pnlResumo.Controls.Add(lblMediaTitulo);
        pnlResumo.Controls.Add(lblMedia);
        pnlResumo.Location = new Point(25, 550);
        pnlResumo.Name = "pnlResumo";
        pnlResumo.Size = new Size(840, 88);
        pnlResumo.TabIndex = 6;
        //
        // lblQuantidadeVendasTitulo
        //
        lblQuantidadeVendasTitulo.AutoSize = true;
        lblQuantidadeVendasTitulo.Font = new Font("Segoe UI", 9F);
        lblQuantidadeVendasTitulo.ForeColor = Color.Silver;
        lblQuantidadeVendasTitulo.Location = new Point(20, 12);
        lblQuantidadeVendasTitulo.Name = "lblQuantidadeVendasTitulo";
        lblQuantidadeVendasTitulo.Size = new Size(125, 15);
        lblQuantidadeVendasTitulo.TabIndex = 0;
        lblQuantidadeVendasTitulo.Text = "Quantidade de vendas";
        //
        // lblQuantidadeVendas
        //
        lblQuantidadeVendas.AutoSize = true;
        lblQuantidadeVendas.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblQuantidadeVendas.ForeColor = Color.FromArgb(0, 59, 142);
        lblQuantidadeVendas.Location = new Point(15, 35);
        lblQuantidadeVendas.Name = "lblQuantidadeVendas";
        lblQuantidadeVendas.Size = new Size(33, 37);
        lblQuantidadeVendas.TabIndex = 1;
        lblQuantidadeVendas.Text = "0";
        //
        // lblTotalVendidoTitulo
        //
        lblTotalVendidoTitulo.AutoSize = true;
        lblTotalVendidoTitulo.Font = new Font("Segoe UI", 9F);
        lblTotalVendidoTitulo.ForeColor = Color.FromArgb(110, 110, 110);
        lblTotalVendidoTitulo.Location = new Point(290, 12);
        lblTotalVendidoTitulo.Name = "lblTotalVendidoTitulo";
        lblTotalVendidoTitulo.Size = new Size(140, 15);
        lblTotalVendidoTitulo.TabIndex = 2;
        lblTotalVendidoTitulo.Text = "Total vendido no período";
        //
        // lblTotalVendido
        //
        lblTotalVendido.AutoSize = true;
        lblTotalVendido.Font = new Font("Comic Sans MS", 20F, FontStyle.Bold);
        lblTotalVendido.ForeColor = Color.Red;
        lblTotalVendido.Location = new Point(285, 35);
        lblTotalVendido.Name = "lblTotalVendido";
        lblTotalVendido.Size = new Size(110, 37);
        lblTotalVendido.TabIndex = 3;
        lblTotalVendido.Text = "R$ 0,00";
        //
        // lblMediaTitulo
        //
        lblMediaTitulo.AutoSize = true;
        lblMediaTitulo.Font = new Font("Segoe UI", 9F);
        lblMediaTitulo.ForeColor = Color.FromArgb(110, 110, 110);
        lblMediaTitulo.Location = new Point(590, 12);
        lblMediaTitulo.Name = "lblMediaTitulo";
        lblMediaTitulo.Size = new Size(100, 15);
        lblMediaTitulo.TabIndex = 4;
        lblMediaTitulo.Text = "Média por venda";
        //
        // lblMedia
        //
        lblMedia.AutoSize = true;
        lblMedia.Font = new Font("Times New Roman", 16F);
        lblMedia.ForeColor = Color.FromArgb(70, 80, 95);
        lblMedia.Location = new Point(585, 35);
        lblMedia.Name = "lblMedia";
        lblMedia.Size = new Size(110, 37);
        lblMedia.TabIndex = 5;
        lblMedia.Text = "R$ 0,00";
        //
        // FormRelatorios
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(890, 660);
        Controls.Add(lblTitulo);
        Controls.Add(pnlFiltros);
        Controls.Add(lblVendas);
        Controls.Add(dgvVendas);
        Controls.Add(lblItens);
        Controls.Add(dgvItens);
        Controls.Add(pnlResumo);
        Name = "FormRelatorios";
        Text = "Relatórios";
        Load += FormRelatorios_Load;
        pnlFiltros.ResumeLayout(false);
        pnlFiltros.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvVendas).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvItens).EndInit();
        pnlResumo.ResumeLayout(false);
        pnlResumo.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblTitulo;
    private Panel pnlFiltros;
    private Label lblInicio;
    private DateTimePicker dtpInicio;
    private Label lblFim;
    private DateTimePicker dtpFim;
    private Label lblPagamento;
    private ComboBox cmbPagamento;
    private Button btnFiltrar;
    private Button btnHoje;
    private Button btnEsteMes;
    private Label lblVendas;
    private DataGridView dgvVendas;
    private Label lblItens;
    private DataGridView dgvItens;
    private Panel pnlResumo;
    private Label lblQuantidadeVendasTitulo;
    private Label lblQuantidadeVendas;
    private Label lblTotalVendidoTitulo;
    private Label lblTotalVendido;
    private Label lblMediaTitulo;
    private Label lblMedia;
}
