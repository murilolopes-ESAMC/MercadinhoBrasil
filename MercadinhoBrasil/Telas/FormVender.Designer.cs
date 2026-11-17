namespace MercadinhoBrasil.Telas;

partial class FormVender
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
        pnlProduto = new Panel();
        lblProduto = new Label();
        cmbProduto = new ComboBox();
        lblPrecoTitulo = new Label();
        lblPreco = new Label();
        lblEstoqueTitulo = new Label();
        lblEstoque = new Label();
        lblQuantidade = new Label();
        nudQuantidade = new NumericUpDown();
        btnAdicionar = new Button();
        lblCarrinho = new Label();
        dgvCarrinho = new DataGridView();
        btnRemover = new Button();
        lblPagamento = new Label();
        cmbPagamento = new ComboBox();
        lblTotalTitulo = new Label();
        lblTotal = new Label();
        btnCancelar = new Button();
        btnFinalizar = new Button();
        pnlProduto.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudQuantidade).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvCarrinho).BeginInit();
        SuspendLayout();
        //
        // lblTitulo
        //
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Arial", 16F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.Blue;
        lblTitulo.Location = new Point(20, 18);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(95, 32);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Vender";
        //
        // pnlProduto
        //
        pnlProduto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        pnlProduto.BackColor = Color.Khaki;
        pnlProduto.Controls.Add(lblProduto);
        pnlProduto.Controls.Add(cmbProduto);
        pnlProduto.Controls.Add(lblPrecoTitulo);
        pnlProduto.Controls.Add(lblPreco);
        pnlProduto.Controls.Add(lblEstoqueTitulo);
        pnlProduto.Controls.Add(lblEstoque);
        pnlProduto.Controls.Add(lblQuantidade);
        pnlProduto.Controls.Add(nudQuantidade);
        pnlProduto.Controls.Add(btnAdicionar);
        pnlProduto.Location = new Point(25, 65);
        pnlProduto.Name = "pnlProduto";
        pnlProduto.Size = new Size(840, 90);
        pnlProduto.TabIndex = 1;
        //
        // lblProduto
        //
        lblProduto.AutoSize = true;
        lblProduto.Location = new Point(15, 14);
        lblProduto.Name = "lblProduto";
        lblProduto.Size = new Size(60, 19);
        lblProduto.TabIndex = 0;
        lblProduto.Text = "Produto:";
        //
        // cmbProduto
        //
        cmbProduto.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbProduto.Font = new Font("Segoe UI", 11F);
        cmbProduto.FormattingEnabled = true;
        cmbProduto.Location = new Point(15, 38);
        cmbProduto.Name = "cmbProduto";
        cmbProduto.Size = new Size(310, 28);
        cmbProduto.TabIndex = 1;
        cmbProduto.SelectedIndexChanged += cmbProduto_SelectedIndexChanged;
        //
        // lblPrecoTitulo
        //
        lblPrecoTitulo.AutoSize = true;
        lblPrecoTitulo.Location = new Point(345, 14);
        lblPrecoTitulo.Name = "lblPrecoTitulo";
        lblPrecoTitulo.Size = new Size(45, 19);
        lblPrecoTitulo.TabIndex = 2;
        lblPrecoTitulo.Text = "Preço:";
        //
        // lblPreco
        //
        lblPreco.AutoSize = true;
        lblPreco.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
        lblPreco.Location = new Point(343, 38);
        lblPreco.Name = "lblPreco";
        lblPreco.Size = new Size(72, 25);
        lblPreco.TabIndex = 3;
        lblPreco.Text = "R$ 0,00";
        //
        // lblEstoqueTitulo
        //
        lblEstoqueTitulo.AutoSize = true;
        lblEstoqueTitulo.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular);
        lblEstoqueTitulo.Location = new Point(470, 14);
        lblEstoqueTitulo.Name = "lblEstoqueTitulo";
        lblEstoqueTitulo.Size = new Size(82, 19);
        lblEstoqueTitulo.TabIndex = 4;
        lblEstoqueTitulo.Text = "Em estoque:";
        //
        // lblEstoque
        //
        lblEstoque.AutoSize = true;
        lblEstoque.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        lblEstoque.Location = new Point(468, 38);
        lblEstoque.Name = "lblEstoque";
        lblEstoque.Size = new Size(22, 25);
        lblEstoque.TabIndex = 5;
        lblEstoque.Text = "0";
        //
        // lblQuantidade
        //
        lblQuantidade.AutoSize = true;
        lblQuantidade.Location = new Point(580, 14);
        lblQuantidade.Name = "lblQuantidade";
        lblQuantidade.Size = new Size(83, 19);
        lblQuantidade.TabIndex = 6;
        lblQuantidade.Text = "Quantidade:";
        //
        // nudQuantidade
        //
        nudQuantidade.Font = new Font("Segoe UI", 11F);
        nudQuantidade.Location = new Point(580, 38);
        nudQuantidade.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
        nudQuantidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudQuantidade.Name = "nudQuantidade";
        nudQuantidade.Size = new Size(90, 27);
        nudQuantidade.TabIndex = 7;
        nudQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
        //
        // btnAdicionar
        //
        btnAdicionar.BackColor = Color.Orange;
        btnAdicionar.FlatAppearance.BorderSize = 0;
        btnAdicionar.FlatStyle = FlatStyle.Flat;
        btnAdicionar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnAdicionar.ForeColor = Color.White;
        btnAdicionar.Location = new Point(690, 18);
        btnAdicionar.Name = "btnAdicionar";
        btnAdicionar.Size = new Size(135, 55);
        btnAdicionar.TabIndex = 8;
        btnAdicionar.Text = "Adicionar";
        btnAdicionar.UseVisualStyleBackColor = false;
        btnAdicionar.Click += btnAdicionar_Click;
        //
        // lblCarrinho
        //
        lblCarrinho.AutoSize = true;
        lblCarrinho.Font = new Font("Times New Roman", 13F, FontStyle.Bold);
        lblCarrinho.Location = new Point(22, 170);
        lblCarrinho.Name = "lblCarrinho";
        lblCarrinho.Size = new Size(76, 21);
        lblCarrinho.TabIndex = 2;
        lblCarrinho.Text = "Carrinho";
        //
        // dgvCarrinho
        //
        dgvCarrinho.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvCarrinho.Location = new Point(25, 198);
        dgvCarrinho.Name = "dgvCarrinho";
        dgvCarrinho.Size = new Size(840, 300);
        dgvCarrinho.TabIndex = 3;
        //
        // btnRemover
        //
        btnRemover.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnRemover.Location = new Point(25, 508);
        btnRemover.Name = "btnRemover";
        btnRemover.Size = new Size(150, 36);
        btnRemover.TabIndex = 4;
        btnRemover.Text = "Remover item";
        btnRemover.UseVisualStyleBackColor = true;
        btnRemover.Click += btnRemover_Click;
        //
        // lblPagamento
        //
        lblPagamento.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblPagamento.AutoSize = true;
        lblPagamento.Location = new Point(25, 575);
        lblPagamento.Name = "lblPagamento";
        lblPagamento.Size = new Size(140, 19);
        lblPagamento.TabIndex = 5;
        lblPagamento.Text = "Forma de pagamento:";
        //
        // cmbPagamento
        //
        cmbPagamento.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        cmbPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbPagamento.Font = new Font("Segoe UI", 11F);
        cmbPagamento.FormattingEnabled = true;
        cmbPagamento.Items.AddRange(new object[] { "Dinheiro", "Pix", "Cartão de Débito", "Cartão de Crédito" });
        cmbPagamento.Location = new Point(25, 600);
        cmbPagamento.Name = "cmbPagamento";
        cmbPagamento.Size = new Size(210, 28);
        cmbPagamento.TabIndex = 6;
        //
        // lblTotalTitulo
        //
        lblTotalTitulo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        lblTotalTitulo.AutoSize = true;
        lblTotalTitulo.Font = new Font("Arial", 11F);
        lblTotalTitulo.Location = new Point(520, 525);
        lblTotalTitulo.Name = "lblTotalTitulo";
        lblTotalTitulo.Size = new Size(76, 25);
        lblTotalTitulo.TabIndex = 7;
        lblTotalTitulo.Text = "TOTAL:";
        //
        // lblTotal
        //
        lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        lblTotal.Font = new Font("Comic Sans MS", 22F, FontStyle.Bold);
        lblTotal.ForeColor = Color.Red;
        lblTotal.Location = new Point(605, 508);
        lblTotal.Name = "lblTotal";
        lblTotal.Size = new Size(260, 55);
        lblTotal.TabIndex = 8;
        lblTotal.Text = "R$ 0,00";
        lblTotal.TextAlign = ContentAlignment.MiddleRight;
        //
        // btnCancelar
        //
        btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnCancelar.BackColor = Color.Gray;
        btnCancelar.FlatAppearance.BorderSize = 0;
        btnCancelar.FlatStyle = FlatStyle.Flat;
        btnCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnCancelar.ForeColor = Color.White;
        btnCancelar.Location = new Point(475, 585);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(170, 38);
        btnCancelar.TabIndex = 9;
        btnCancelar.Text = "Cancelar venda";
        btnCancelar.UseVisualStyleBackColor = false;
        btnCancelar.Click += btnCancelar_Click;
        //
        // btnFinalizar
        //
        btnFinalizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnFinalizar.BackColor = Color.Lime;
        btnFinalizar.FlatAppearance.BorderSize = 0;
        btnFinalizar.FlatStyle = FlatStyle.Flat;
        btnFinalizar.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
        btnFinalizar.ForeColor = Color.White;
        btnFinalizar.Location = new Point(655, 585);
        btnFinalizar.Name = "btnFinalizar";
        btnFinalizar.Size = new Size(210, 50);
        btnFinalizar.TabIndex = 10;
        btnFinalizar.Text = "Finalizar venda";
        btnFinalizar.UseVisualStyleBackColor = false;
        btnFinalizar.Click += btnFinalizar_Click;
        //
        // FormVender
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(890, 660);
        Controls.Add(lblTitulo);
        Controls.Add(pnlProduto);
        Controls.Add(lblCarrinho);
        Controls.Add(dgvCarrinho);
        Controls.Add(btnRemover);
        Controls.Add(lblPagamento);
        Controls.Add(cmbPagamento);
        Controls.Add(lblTotalTitulo);
        Controls.Add(lblTotal);
        Controls.Add(btnCancelar);
        Controls.Add(btnFinalizar);
        Name = "FormVender";
        Text = "Vender";
        Load += FormVender_Load;
        pnlProduto.ResumeLayout(false);
        pnlProduto.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudQuantidade).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvCarrinho).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblTitulo;
    private Panel pnlProduto;
    private Label lblProduto;
    private ComboBox cmbProduto;
    private Label lblPrecoTitulo;
    private Label lblPreco;
    private Label lblEstoqueTitulo;
    private Label lblEstoque;
    private Label lblQuantidade;
    private NumericUpDown nudQuantidade;
    private Button btnAdicionar;
    private Label lblCarrinho;
    private DataGridView dgvCarrinho;
    private Button btnRemover;
    private Label lblPagamento;
    private ComboBox cmbPagamento;
    private Label lblTotalTitulo;
    private Label lblTotal;
    private Button btnCancelar;
    private Button btnFinalizar;
}
