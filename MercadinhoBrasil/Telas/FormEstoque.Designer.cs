namespace MercadinhoBrasil.Telas;

partial class FormEstoque
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
        pnlTotalProdutos = new Panel();
        lblTotalProdutosTitulo = new Label();
        lblTotalProdutos = new Label();
        pnlTotalItens = new Panel();
        lblTotalItensTitulo = new Label();
        lblTotalItens = new Label();
        pnlValorEstoque = new Panel();
        lblValorEstoqueTitulo = new Label();
        lblValorEstoque = new Label();
        pnlEstoqueBaixo = new Panel();
        lblEstoqueBaixoTitulo = new Label();
        lblEstoqueBaixo = new Label();
        chkEstoqueBaixo = new CheckBox();
        dgvEstoque = new DataGridView();
        pnlEntrada = new Panel();
        lblEntrada = new Label();
        lblSelecionado = new Label();
        lblQuantidadeEntrada = new Label();
        nudEntrada = new NumericUpDown();
        btnAdicionarEstoque = new Button();
        pnlTotalProdutos.SuspendLayout();
        pnlTotalItens.SuspendLayout();
        pnlValorEstoque.SuspendLayout();
        pnlEstoqueBaixo.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
        pnlEntrada.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudEntrada).BeginInit();
        SuspendLayout();
        //
        // lblTitulo
        //
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.Green;
        lblTitulo.Location = new Point(20, 18);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(105, 32);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Estoque";
        //
        // pnlTotalProdutos
        //
        pnlTotalProdutos.BackColor = Color.LightBlue;
        pnlTotalProdutos.Controls.Add(lblTotalProdutosTitulo);
        pnlTotalProdutos.Controls.Add(lblTotalProdutos);
        pnlTotalProdutos.Location = new Point(25, 65);
        pnlTotalProdutos.Name = "pnlTotalProdutos";
        pnlTotalProdutos.Size = new Size(195, 80);
        pnlTotalProdutos.TabIndex = 1;
        //
        // lblTotalProdutosTitulo
        //
        lblTotalProdutosTitulo.AutoSize = true;
        lblTotalProdutosTitulo.Font = new Font("Segoe UI", 9F);
        lblTotalProdutosTitulo.ForeColor = Color.FromArgb(110, 110, 110);
        lblTotalProdutosTitulo.Location = new Point(12, 10);
        lblTotalProdutosTitulo.Name = "lblTotalProdutosTitulo";
        lblTotalProdutosTitulo.Size = new Size(125, 15);
        lblTotalProdutosTitulo.TabIndex = 0;
        lblTotalProdutosTitulo.Text = "Produtos cadastrados";
        //
        // lblTotalProdutos
        //
        lblTotalProdutos.AutoSize = true;
        lblTotalProdutos.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblTotalProdutos.ForeColor = Color.FromArgb(0, 122, 61);
        lblTotalProdutos.Location = new Point(8, 32);
        lblTotalProdutos.Name = "lblTotalProdutos";
        lblTotalProdutos.Size = new Size(28, 32);
        lblTotalProdutos.TabIndex = 1;
        lblTotalProdutos.Text = "0";
        //
        // pnlTotalItens
        //
        pnlTotalItens.BackColor = Color.LightPink;
        pnlTotalItens.Controls.Add(lblTotalItensTitulo);
        pnlTotalItens.Controls.Add(lblTotalItens);
        pnlTotalItens.Location = new Point(240, 65);
        pnlTotalItens.Name = "pnlTotalItens";
        pnlTotalItens.Size = new Size(195, 80);
        pnlTotalItens.TabIndex = 2;
        //
        // lblTotalItensTitulo
        //
        lblTotalItensTitulo.AutoSize = true;
        lblTotalItensTitulo.Font = new Font("Segoe UI", 9F);
        lblTotalItensTitulo.ForeColor = Color.FromArgb(110, 110, 110);
        lblTotalItensTitulo.Location = new Point(12, 10);
        lblTotalItensTitulo.Name = "lblTotalItensTitulo";
        lblTotalItensTitulo.Size = new Size(120, 15);
        lblTotalItensTitulo.TabIndex = 0;
        lblTotalItensTitulo.Text = "Unidades em estoque";
        //
        // lblTotalItens
        //
        lblTotalItens.AutoSize = true;
        lblTotalItens.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
        lblTotalItens.ForeColor = Color.FromArgb(0, 59, 142);
        lblTotalItens.Location = new Point(8, 32);
        lblTotalItens.Name = "lblTotalItens";
        lblTotalItens.Size = new Size(28, 32);
        lblTotalItens.TabIndex = 1;
        lblTotalItens.Text = "0";
        //
        // pnlValorEstoque
        //
        pnlValorEstoque.BackColor = Color.Khaki;
        pnlValorEstoque.Controls.Add(lblValorEstoqueTitulo);
        pnlValorEstoque.Controls.Add(lblValorEstoque);
        pnlValorEstoque.Location = new Point(455, 65);
        pnlValorEstoque.Name = "pnlValorEstoque";
        pnlValorEstoque.Size = new Size(195, 95);
        pnlValorEstoque.TabIndex = 3;
        //
        // lblValorEstoqueTitulo
        //
        lblValorEstoqueTitulo.AutoSize = true;
        lblValorEstoqueTitulo.Font = new Font("Segoe UI", 9F);
        lblValorEstoqueTitulo.ForeColor = Color.FromArgb(110, 110, 110);
        lblValorEstoqueTitulo.Location = new Point(12, 10);
        lblValorEstoqueTitulo.Name = "lblValorEstoqueTitulo";
        lblValorEstoqueTitulo.Size = new Size(120, 15);
        lblValorEstoqueTitulo.TabIndex = 0;
        lblValorEstoqueTitulo.Text = "Valor total em estoque";
        //
        // lblValorEstoque
        //
        lblValorEstoque.AutoSize = true;
        lblValorEstoque.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
        lblValorEstoque.ForeColor = Color.FromArgb(70, 80, 95);
        lblValorEstoque.Location = new Point(8, 34);
        lblValorEstoque.Name = "lblValorEstoque";
        lblValorEstoque.Size = new Size(90, 30);
        lblValorEstoque.TabIndex = 1;
        lblValorEstoque.Text = "R$ 0,00";
        //
        // pnlEstoqueBaixo
        //
        pnlEstoqueBaixo.BackColor = Color.White;
        pnlEstoqueBaixo.Controls.Add(lblEstoqueBaixoTitulo);
        pnlEstoqueBaixo.Controls.Add(lblEstoqueBaixo);
        pnlEstoqueBaixo.Location = new Point(670, 65);
        pnlEstoqueBaixo.Name = "pnlEstoqueBaixo";
        pnlEstoqueBaixo.Size = new Size(195, 80);
        pnlEstoqueBaixo.TabIndex = 4;
        //
        // lblEstoqueBaixoTitulo
        //
        lblEstoqueBaixoTitulo.AutoSize = true;
        lblEstoqueBaixoTitulo.Font = new Font("Segoe UI", 9F);
        lblEstoqueBaixoTitulo.ForeColor = Color.Silver;
        lblEstoqueBaixoTitulo.Location = new Point(12, 10);
        lblEstoqueBaixoTitulo.Name = "lblEstoqueBaixoTitulo";
        lblEstoqueBaixoTitulo.Size = new Size(150, 15);
        lblEstoqueBaixoTitulo.TabIndex = 0;
        lblEstoqueBaixoTitulo.Text = "Produtos com estoque baixo";
        //
        // lblEstoqueBaixo
        //
        lblEstoqueBaixo.AutoSize = true;
        lblEstoqueBaixo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblEstoqueBaixo.ForeColor = Color.FromArgb(200, 50, 50);
        lblEstoqueBaixo.Location = new Point(8, 32);
        lblEstoqueBaixo.Name = "lblEstoqueBaixo";
        lblEstoqueBaixo.Size = new Size(28, 32);
        lblEstoqueBaixo.TabIndex = 1;
        lblEstoqueBaixo.Text = "0";
        //
        // chkEstoqueBaixo
        //
        chkEstoqueBaixo.AutoSize = true;
        chkEstoqueBaixo.Location = new Point(25, 160);
        chkEstoqueBaixo.Name = "chkEstoqueBaixo";
        chkEstoqueBaixo.Size = new Size(360, 23);
        chkEstoqueBaixo.TabIndex = 5;
        chkEstoqueBaixo.Text = "Mostrar só os produtos com estoque baixo (5 ou menos)";
        chkEstoqueBaixo.UseVisualStyleBackColor = true;
        chkEstoqueBaixo.CheckedChanged += chkEstoqueBaixo_CheckedChanged;
        //
        // dgvEstoque
        //
        dgvEstoque.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvEstoque.Location = new Point(25, 192);
        dgvEstoque.Name = "dgvEstoque";
        dgvEstoque.Size = new Size(840, 330);
        dgvEstoque.TabIndex = 6;
        dgvEstoque.CellClick += dgvEstoque_CellClick;
        //
        // pnlEntrada
        //
        pnlEntrada.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pnlEntrada.BackColor = Color.LightGreen;
        pnlEntrada.Controls.Add(lblEntrada);
        pnlEntrada.Controls.Add(lblSelecionado);
        pnlEntrada.Controls.Add(lblQuantidadeEntrada);
        pnlEntrada.Controls.Add(nudEntrada);
        pnlEntrada.Controls.Add(btnAdicionarEstoque);
        pnlEntrada.Location = new Point(25, 537);
        pnlEntrada.Name = "pnlEntrada";
        pnlEntrada.Size = new Size(840, 100);
        pnlEntrada.TabIndex = 7;
        //
        // lblEntrada
        //
        lblEntrada.AutoSize = true;
        lblEntrada.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
        lblEntrada.Location = new Point(12, 12);
        lblEntrada.Name = "lblEntrada";
        lblEntrada.Size = new Size(290, 21);
        lblEntrada.TabIndex = 0;
        lblEntrada.Text = "Entrada de mercadoria (compra)";
        //
        // lblSelecionado
        //
        lblSelecionado.Font = new Font("Segoe UI", 10F);
        lblSelecionado.ForeColor = Color.FromArgb(70, 80, 95);
        lblSelecionado.Location = new Point(14, 50);
        lblSelecionado.Name = "lblSelecionado";
        lblSelecionado.Size = new Size(400, 40);
        lblSelecionado.TabIndex = 1;
        lblSelecionado.Text = "Produto selecionado: (clique em um produto da lista)";
        //
        // lblQuantidadeEntrada
        //
        lblQuantidadeEntrada.AutoSize = true;
        lblQuantidadeEntrada.Location = new Point(430, 18);
        lblQuantidadeEntrada.Name = "lblQuantidadeEntrada";
        lblQuantidadeEntrada.Size = new Size(155, 19);
        lblQuantidadeEntrada.TabIndex = 2;
        lblQuantidadeEntrada.Text = "Quantidade que chegou:";
        //
        // nudEntrada
        //
        nudEntrada.Font = new Font("Segoe UI", 11F);
        nudEntrada.Location = new Point(430, 45);
        nudEntrada.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
        nudEntrada.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudEntrada.Name = "nudEntrada";
        nudEntrada.Size = new Size(150, 27);
        nudEntrada.TabIndex = 3;
        nudEntrada.Value = new decimal(new int[] { 1, 0, 0, 0 });
        //
        // btnAdicionarEstoque
        //
        btnAdicionarEstoque.BackColor = Color.Blue;
        btnAdicionarEstoque.FlatAppearance.BorderSize = 0;
        btnAdicionarEstoque.FlatStyle = FlatStyle.Flat;
        btnAdicionarEstoque.Font = new Font("Arial", 9F, FontStyle.Bold);
        btnAdicionarEstoque.ForeColor = Color.White;
        btnAdicionarEstoque.Location = new Point(610, 30);
        btnAdicionarEstoque.Name = "btnAdicionarEstoque";
        btnAdicionarEstoque.Size = new Size(210, 45);
        btnAdicionarEstoque.TabIndex = 4;
        btnAdicionarEstoque.Text = "Adicionar ao estoque";
        btnAdicionarEstoque.UseVisualStyleBackColor = false;
        btnAdicionarEstoque.Click += btnAdicionarEstoque_Click;
        //
        // FormEstoque
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(890, 660);
        Controls.Add(lblTitulo);
        Controls.Add(pnlTotalProdutos);
        Controls.Add(pnlTotalItens);
        Controls.Add(pnlValorEstoque);
        Controls.Add(pnlEstoqueBaixo);
        Controls.Add(chkEstoqueBaixo);
        Controls.Add(dgvEstoque);
        Controls.Add(pnlEntrada);
        Name = "FormEstoque";
        Text = "Estoque";
        Load += FormEstoque_Load;
        pnlTotalProdutos.ResumeLayout(false);
        pnlTotalProdutos.PerformLayout();
        pnlTotalItens.ResumeLayout(false);
        pnlTotalItens.PerformLayout();
        pnlValorEstoque.ResumeLayout(false);
        pnlValorEstoque.PerformLayout();
        pnlEstoqueBaixo.ResumeLayout(false);
        pnlEstoqueBaixo.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvEstoque).EndInit();
        pnlEntrada.ResumeLayout(false);
        pnlEntrada.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudEntrada).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblTitulo;
    private Panel pnlTotalProdutos;
    private Label lblTotalProdutosTitulo;
    private Label lblTotalProdutos;
    private Panel pnlTotalItens;
    private Label lblTotalItensTitulo;
    private Label lblTotalItens;
    private Panel pnlValorEstoque;
    private Label lblValorEstoqueTitulo;
    private Label lblValorEstoque;
    private Panel pnlEstoqueBaixo;
    private Label lblEstoqueBaixoTitulo;
    private Label lblEstoqueBaixo;
    private CheckBox chkEstoqueBaixo;
    private DataGridView dgvEstoque;
    private Panel pnlEntrada;
    private Label lblEntrada;
    private Label lblSelecionado;
    private Label lblQuantidadeEntrada;
    private NumericUpDown nudEntrada;
    private Button btnAdicionarEstoque;
}
