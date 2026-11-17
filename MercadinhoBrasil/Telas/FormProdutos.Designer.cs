namespace MercadinhoBrasil.Telas;

partial class FormProdutos
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
        pnlCampos = new Panel();
        lblNome = new Label();
        txtNome = new TextBox();
        lblCategoria = new Label();
        cmbCategoria = new ComboBox();
        lblPreco = new Label();
        txtPreco = new TextBox();
        lblQuantidade = new Label();
        nudQuantidade = new NumericUpDown();
        btnSalvar = new Button();
        btnNovo = new Button();
        btnExcluir = new Button();
        lblModo = new Label();
        lblBuscar = new Label();
        txtBuscar = new TextBox();
        btnBuscar = new Button();
        btnMostrarTodos = new Button();
        lblDica = new Label();
        dgvProdutos = new DataGridView();
        pnlCampos.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudQuantidade).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
        SuspendLayout();
        //
        // lblTitulo
        //
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.Green;
        lblTitulo.Location = new Point(20, 18);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(120, 32);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Produtos";
        //
        // pnlCampos
        //
        pnlCampos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        pnlCampos.BackColor = Color.LightBlue;
        pnlCampos.Controls.Add(lblNome);
        pnlCampos.Controls.Add(txtNome);
        pnlCampos.Controls.Add(lblCategoria);
        pnlCampos.Controls.Add(cmbCategoria);
        pnlCampos.Controls.Add(lblPreco);
        pnlCampos.Controls.Add(txtPreco);
        pnlCampos.Controls.Add(lblQuantidade);
        pnlCampos.Controls.Add(nudQuantidade);
        pnlCampos.Controls.Add(btnSalvar);
        pnlCampos.Controls.Add(btnNovo);
        pnlCampos.Controls.Add(btnExcluir);
        pnlCampos.Controls.Add(lblModo);
        pnlCampos.Location = new Point(25, 65);
        pnlCampos.Name = "pnlCampos";
        pnlCampos.Size = new Size(840, 150);
        pnlCampos.TabIndex = 1;
        //
        // lblNome
        //
        lblNome.AutoSize = true;
        lblNome.Location = new Point(15, 14);
        lblNome.Name = "lblNome";
        lblNome.Size = new Size(49, 19);
        lblNome.TabIndex = 0;
        lblNome.Text = "Nome:";
        //
        // txtNome
        //
        txtNome.Font = new Font("Times New Roman", 11F);
        txtNome.Location = new Point(15, 37);
        txtNome.MaxLength = 100;
        txtNome.Name = "txtNome";
        txtNome.Size = new Size(310, 27);
        txtNome.TabIndex = 1;
        //
        // lblCategoria
        //
        lblCategoria.AutoSize = true;
        lblCategoria.Location = new Point(345, 14);
        lblCategoria.Name = "lblCategoria";
        lblCategoria.Size = new Size(70, 19);
        lblCategoria.TabIndex = 2;
        lblCategoria.Text = "Categoria:";
        //
        // cmbCategoria
        //
        cmbCategoria.Font = new Font("Segoe UI", 11F);
        cmbCategoria.FormattingEnabled = true;
        cmbCategoria.Items.AddRange(new object[] { "Alimentos", "Bebidas", "Laticínios", "Hortifruti", "Limpeza", "Higiene", "Outros" });
        cmbCategoria.Location = new Point(345, 37);
        cmbCategoria.MaxLength = 50;
        cmbCategoria.Name = "cmbCategoria";
        cmbCategoria.Size = new Size(190, 28);
        cmbCategoria.TabIndex = 3;
        //
        // lblPreco
        //
        lblPreco.AutoSize = true;
        lblPreco.Font = new Font("Arial", 12F, FontStyle.Bold);
        lblPreco.Location = new Point(552, 8);
        lblPreco.Name = "lblPreco";
        lblPreco.Size = new Size(75, 19);
        lblPreco.TabIndex = 4;
        lblPreco.Text = "Preço (R$):";
        //
        // txtPreco
        //
        txtPreco.Font = new Font("Segoe UI", 11F);
        txtPreco.Location = new Point(555, 37);
        txtPreco.MaxLength = 10;
        txtPreco.Name = "txtPreco";
        txtPreco.Size = new Size(75, 27);
        txtPreco.TabIndex = 5;
        //
        // lblQuantidade
        //
        lblQuantidade.AutoSize = true;
        lblQuantidade.Location = new Point(695, 14);
        lblQuantidade.Name = "lblQuantidade";
        lblQuantidade.Size = new Size(83, 19);
        lblQuantidade.TabIndex = 6;
        lblQuantidade.Text = "Quantidade:";
        //
        // nudQuantidade
        //
        nudQuantidade.Font = new Font("Segoe UI", 11F);
        nudQuantidade.Location = new Point(695, 37);
        nudQuantidade.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
        nudQuantidade.Name = "nudQuantidade";
        nudQuantidade.Size = new Size(125, 27);
        nudQuantidade.TabIndex = 7;
        //
        // btnSalvar
        //
        btnSalvar.BackColor = Color.Lime;
        btnSalvar.FlatAppearance.BorderSize = 0;
        btnSalvar.FlatStyle = FlatStyle.Flat;
        btnSalvar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnSalvar.ForeColor = Color.White;
        btnSalvar.Location = new Point(15, 92);
        btnSalvar.Name = "btnSalvar";
        btnSalvar.Size = new Size(130, 40);
        btnSalvar.TabIndex = 8;
        btnSalvar.Text = "Salvar";
        btnSalvar.UseVisualStyleBackColor = false;
        btnSalvar.Click += btnSalvar_Click;
        //
        // btnNovo
        //
        btnNovo.BackColor = Color.Blue;
        btnNovo.FlatAppearance.BorderSize = 0;
        btnNovo.FlatStyle = FlatStyle.Flat;
        btnNovo.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
        btnNovo.ForeColor = Color.White;
        btnNovo.Location = new Point(155, 92);
        btnNovo.Name = "btnNovo";
        btnNovo.Size = new Size(130, 40);
        btnNovo.TabIndex = 9;
        btnNovo.Text = "Novo";
        btnNovo.UseVisualStyleBackColor = false;
        btnNovo.Click += btnNovo_Click;
        //
        // btnExcluir
        //
        btnExcluir.BackColor = Color.Red;
        btnExcluir.FlatAppearance.BorderSize = 0;
        btnExcluir.FlatStyle = FlatStyle.Flat;
        btnExcluir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnExcluir.ForeColor = Color.White;
        btnExcluir.Location = new Point(295, 88);
        btnExcluir.Name = "btnExcluir";
        btnExcluir.Size = new Size(155, 50);
        btnExcluir.TabIndex = 10;
        btnExcluir.Text = "Excluir";
        btnExcluir.UseVisualStyleBackColor = false;
        btnExcluir.Click += btnExcluir_Click;
        //
        // lblModo
        //
        lblModo.AutoSize = true;
        lblModo.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
        lblModo.ForeColor = Color.Silver;
        lblModo.Location = new Point(465, 103);
        lblModo.Name = "lblModo";
        lblModo.Size = new Size(190, 19);
        lblModo.TabIndex = 11;
        lblModo.Text = "Cadastrando um produto novo";
        //
        // lblBuscar
        //
        lblBuscar.AutoSize = true;
        lblBuscar.Location = new Point(25, 238);
        lblBuscar.Name = "lblBuscar";
        lblBuscar.Size = new Size(116, 19);
        lblBuscar.TabIndex = 2;
        lblBuscar.Text = "Buscar por nome:";
        //
        // txtBuscar
        //
        txtBuscar.Font = new Font("Segoe UI", 11F);
        txtBuscar.Location = new Point(150, 234);
        txtBuscar.Name = "txtBuscar";
        txtBuscar.Size = new Size(280, 27);
        txtBuscar.TabIndex = 3;
        //
        // btnBuscar
        //
        btnBuscar.Location = new Point(440, 232);
        btnBuscar.Name = "btnBuscar";
        btnBuscar.Size = new Size(100, 32);
        btnBuscar.TabIndex = 4;
        btnBuscar.Text = "Buscar";
        btnBuscar.UseVisualStyleBackColor = true;
        btnBuscar.Click += btnBuscar_Click;
        //
        // btnMostrarTodos
        //
        btnMostrarTodos.Location = new Point(550, 232);
        btnMostrarTodos.Name = "btnMostrarTodos";
        btnMostrarTodos.Size = new Size(130, 32);
        btnMostrarTodos.TabIndex = 5;
        btnMostrarTodos.Text = "Mostrar todos";
        btnMostrarTodos.UseVisualStyleBackColor = true;
        btnMostrarTodos.Click += btnMostrarTodos_Click;
        //
        // lblDica
        //
        lblDica.AutoSize = true;
        lblDica.Font = new Font("Comic Sans MS", 8F, FontStyle.Regular);
        lblDica.ForeColor = Color.FromArgb(110, 110, 110);
        lblDica.Location = new Point(25, 632);
        lblDica.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblDica.Name = "lblDica";
        lblDica.Size = new Size(330, 15);
        lblDica.TabIndex = 7;
        lblDica.Text = "Dica: clique em um produto da lista para alterar ou excluir.";
        //
        // dgvProdutos
        //
        dgvProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvProdutos.Location = new Point(25, 278);
        dgvProdutos.Name = "dgvProdutos";
        dgvProdutos.Size = new Size(840, 345);
        dgvProdutos.TabIndex = 6;
        dgvProdutos.CellClick += dgvProdutos_CellClick;
        //
        // FormProdutos
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(890, 660);
        Controls.Add(lblTitulo);
        Controls.Add(pnlCampos);
        Controls.Add(lblBuscar);
        Controls.Add(txtBuscar);
        Controls.Add(btnBuscar);
        Controls.Add(btnMostrarTodos);
        Controls.Add(dgvProdutos);
        Controls.Add(lblDica);
        Name = "FormProdutos";
        Text = "Produtos";
        Load += FormProdutos_Load;
        pnlCampos.ResumeLayout(false);
        pnlCampos.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudQuantidade).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblTitulo;
    private Panel pnlCampos;
    private Label lblNome;
    private TextBox txtNome;
    private Label lblCategoria;
    private ComboBox cmbCategoria;
    private Label lblPreco;
    private TextBox txtPreco;
    private Label lblQuantidade;
    private NumericUpDown nudQuantidade;
    private Button btnSalvar;
    private Button btnNovo;
    private Button btnExcluir;
    private Label lblModo;
    private Label lblBuscar;
    private TextBox txtBuscar;
    private Button btnBuscar;
    private Button btnMostrarTodos;
    private Label lblDica;
    private DataGridView dgvProdutos;
}
