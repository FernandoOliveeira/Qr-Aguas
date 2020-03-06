namespace QrAguas.View_Layer
{
    partial class RegisterProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterProduct));
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DTPValidade = new System.Windows.Forms.DateTimePicker();
            this.lblDataValidade = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CBCategoria = new System.Windows.Forms.ComboBox();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._0ybkkaeekeDataSetRegisterProductCategorias = new QrAguas._0ybkkaeekeDataSetRegisterProduct();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.panelPrecoCompra = new System.Windows.Forms.Panel();
            this.txtPrecoCompra = new System.Windows.Forms.TextBox();
            this.lblPrecoCompra = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.lblCodProduto = new System.Windows.Forms.Label();
            this.panelFornecedor = new System.Windows.Forms.Panel();
            this.CBFornecedor = new System.Windows.Forms.ComboBox();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._0ybkkaeekeDataSetRegisterProductFornecedores = new QrAguas._0ybkkaeekeDataSetRegisterProductFornecedores();
            this.panelPrecoEntrega = new System.Windows.Forms.Panel();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.lblPrecoVenda = new System.Windows.Forms.Label();
            this.panelDescricao = new System.Windows.Forms.Panel();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.panelBtnCadastrar = new System.Windows.Forms.Panel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DTPFabricacao = new System.Windows.Forms.DateTimePicker();
            this.lblDataFabricacao = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.categoriasTableAdapter = new QrAguas._0ybkkaeekeDataSetRegisterProductTableAdapters.categoriasTableAdapter();
            this.fornecedoresTableAdapter = new QrAguas._0ybkkaeekeDataSetRegisterProductFornecedoresTableAdapters.fornecedoresTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._0ybkkaeekeDataSetRegisterProductCategorias)).BeginInit();
            this.panelPrecoCompra.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelFornecedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._0ybkkaeekeDataSetRegisterProductFornecedores)).BeginInit();
            this.panelPrecoEntrega.SuspendLayout();
            this.panelDescricao.SuspendLayout();
            this.panelBtnCadastrar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.ForeColor = System.Drawing.Color.White;
            this.lblFornecedor.Location = new System.Drawing.Point(8, 8);
            this.lblFornecedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(85, 17);
            this.lblFornecedor.TabIndex = 1;
            this.lblFornecedor.Text = "Fornecedor:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelPrecoCompra, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelFornecedor, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelPrecoEntrega, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelDescricao, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelBtnCadastrar, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 111);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.21348F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.07547F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.86792F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(634, 350);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.DTPValidade);
            this.panel5.Controls.Add(this.lblDataValidade);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(426, 178);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(204, 102);
            this.panel5.TabIndex = 8;
            // 
            // DTPValidade
            // 
            this.DTPValidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DTPValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPValidade.Location = new System.Drawing.Point(12, 30);
            this.DTPValidade.Name = "DTPValidade";
            this.DTPValidade.Size = new System.Drawing.Size(186, 23);
            this.DTPValidade.TabIndex = 6;
            // 
            // lblDataValidade
            // 
            this.lblDataValidade.AutoSize = true;
            this.lblDataValidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataValidade.ForeColor = System.Drawing.Color.White;
            this.lblDataValidade.Location = new System.Drawing.Point(12, 5);
            this.lblDataValidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataValidade.Name = "lblDataValidade";
            this.lblDataValidade.Size = new System.Drawing.Size(121, 17);
            this.lblDataValidade.TabIndex = 3;
            this.lblDataValidade.Text = "Data de Validade:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.CBCategoria);
            this.panel4.Controls.Add(this.lblCategoria);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(4, 178);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(203, 102);
            this.panel4.TabIndex = 6;
            // 
            // CBCategoria
            // 
            this.CBCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBCategoria.DataSource = this.categoriasBindingSource;
            this.CBCategoria.DisplayMember = "NOME_CATEGORIA";
            this.CBCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCategoria.FormattingEnabled = true;
            this.CBCategoria.IntegralHeight = false;
            this.CBCategoria.ItemHeight = 17;
            this.CBCategoria.Location = new System.Drawing.Point(12, 30);
            this.CBCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(186, 25);
            this.CBCategoria.TabIndex = 4;
            this.CBCategoria.ValueMember = "ID_CATEGORIAS";
            this.CBCategoria.Click += new System.EventHandler(this.TxtCategoria_Click);
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "categorias";
            this.categoriasBindingSource.DataSource = this._0ybkkaeekeDataSetRegisterProductCategorias;
            // 
            // _0ybkkaeekeDataSetRegisterProductCategorias
            // 
            this._0ybkkaeekeDataSetRegisterProductCategorias.DataSetName = "_0ybkkaeekeDataSetRegisterProductCategorias";
            this._0ybkkaeekeDataSetRegisterProductCategorias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Location = new System.Drawing.Point(12, 5);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(73, 17);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoria:";
            // 
            // panelPrecoCompra
            // 
            this.panelPrecoCompra.Controls.Add(this.txtPrecoCompra);
            this.panelPrecoCompra.Controls.Add(this.lblPrecoCompra);
            this.panelPrecoCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrecoCompra.Location = new System.Drawing.Point(426, 4);
            this.panelPrecoCompra.Margin = new System.Windows.Forms.Padding(4);
            this.panelPrecoCompra.Name = "panelPrecoCompra";
            this.panelPrecoCompra.Size = new System.Drawing.Size(204, 75);
            this.panelPrecoCompra.TabIndex = 2;
            // 
            // txtPrecoCompra
            // 
            this.txtPrecoCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecoCompra.Location = new System.Drawing.Point(12, 34);
            this.txtPrecoCompra.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecoCompra.Name = "txtPrecoCompra";
            this.txtPrecoCompra.Size = new System.Drawing.Size(186, 23);
            this.txtPrecoCompra.TabIndex = 0;
            this.txtPrecoCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumeros_KeyPress);
            // 
            // lblPrecoCompra
            // 
            this.lblPrecoCompra.AutoSize = true;
            this.lblPrecoCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoCompra.ForeColor = System.Drawing.Color.White;
            this.lblPrecoCompra.Location = new System.Drawing.Point(8, 8);
            this.lblPrecoCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecoCompra.Name = "lblPrecoCompra";
            this.lblPrecoCompra.Size = new System.Drawing.Size(122, 17);
            this.lblPrecoCompra.TabIndex = 1;
            this.lblPrecoCompra.Text = "Preço de Compra:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Controls.Add(this.lblNome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(215, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 75);
            this.panel2.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Location = new System.Drawing.Point(12, 34);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(186, 23);
            this.txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(8, 8);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(123, 17);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome do Produto:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCodProduto);
            this.panel1.Controls.Add(this.lblCodProduto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 75);
            this.panel1.TabIndex = 0;
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodProduto.Location = new System.Drawing.Point(12, 34);
            this.txtCodProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(186, 23);
            this.txtCodProduto.TabIndex = 0;
            // 
            // lblCodProduto
            // 
            this.lblCodProduto.AutoSize = true;
            this.lblCodProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProduto.ForeColor = System.Drawing.Color.White;
            this.lblCodProduto.Location = new System.Drawing.Point(8, 8);
            this.lblCodProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodProduto.Name = "lblCodProduto";
            this.lblCodProduto.Size = new System.Drawing.Size(130, 17);
            this.lblCodProduto.TabIndex = 1;
            this.lblCodProduto.Text = "Código do Produto:";
            // 
            // panelFornecedor
            // 
            this.panelFornecedor.Controls.Add(this.CBFornecedor);
            this.panelFornecedor.Controls.Add(this.lblFornecedor);
            this.panelFornecedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFornecedor.Location = new System.Drawing.Point(4, 87);
            this.panelFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.panelFornecedor.Name = "panelFornecedor";
            this.panelFornecedor.Size = new System.Drawing.Size(203, 83);
            this.panelFornecedor.TabIndex = 3;
            // 
            // CBFornecedor
            // 
            this.CBFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBFornecedor.DataSource = this.fornecedoresBindingSource;
            this.CBFornecedor.DisplayMember = "RAZAO_SOCIAL";
            this.CBFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBFornecedor.FormattingEnabled = true;
            this.CBFornecedor.IntegralHeight = false;
            this.CBFornecedor.Location = new System.Drawing.Point(12, 28);
            this.CBFornecedor.Name = "CBFornecedor";
            this.CBFornecedor.Size = new System.Drawing.Size(186, 25);
            this.CBFornecedor.TabIndex = 2;
            this.CBFornecedor.ValueMember = "ID_FORNECEDORES";
            this.CBFornecedor.Click += new System.EventHandler(this.TxtFornecedor_Click);
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataMember = "fornecedores";
            this.fornecedoresBindingSource.DataSource = this._0ybkkaeekeDataSetRegisterProductFornecedores;
            // 
            // _0ybkkaeekeDataSetRegisterProductFornecedores
            // 
            this._0ybkkaeekeDataSetRegisterProductFornecedores.DataSetName = "_0ybkkaeekeDataSetRegisterProductFornecedores";
            this._0ybkkaeekeDataSetRegisterProductFornecedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelPrecoEntrega
            // 
            this.panelPrecoEntrega.Controls.Add(this.txtPrecoVenda);
            this.panelPrecoEntrega.Controls.Add(this.lblPrecoVenda);
            this.panelPrecoEntrega.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrecoEntrega.Location = new System.Drawing.Point(426, 87);
            this.panelPrecoEntrega.Margin = new System.Windows.Forms.Padding(4);
            this.panelPrecoEntrega.Name = "panelPrecoEntrega";
            this.panelPrecoEntrega.Size = new System.Drawing.Size(204, 83);
            this.panelPrecoEntrega.TabIndex = 5;
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecoVenda.Location = new System.Drawing.Point(12, 34);
            this.txtPrecoVenda.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(186, 23);
            this.txtPrecoVenda.TabIndex = 0;
            this.txtPrecoVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumeros_KeyPress);
            // 
            // lblPrecoVenda
            // 
            this.lblPrecoVenda.AutoSize = true;
            this.lblPrecoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoVenda.ForeColor = System.Drawing.Color.White;
            this.lblPrecoVenda.Location = new System.Drawing.Point(8, 8);
            this.lblPrecoVenda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecoVenda.Name = "lblPrecoVenda";
            this.lblPrecoVenda.Size = new System.Drawing.Size(114, 17);
            this.lblPrecoVenda.TabIndex = 1;
            this.lblPrecoVenda.Text = "Preço de Venda:";
            // 
            // panelDescricao
            // 
            this.panelDescricao.Controls.Add(this.txtDescricao);
            this.panelDescricao.Controls.Add(this.lblDescricao);
            this.panelDescricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDescricao.Location = new System.Drawing.Point(215, 87);
            this.panelDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.panelDescricao.Name = "panelDescricao";
            this.panelDescricao.Size = new System.Drawing.Size(203, 83);
            this.panelDescricao.TabIndex = 4;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.Location = new System.Drawing.Point(12, 34);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(186, 23);
            this.txtDescricao.TabIndex = 2;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.White;
            this.lblDescricao.Location = new System.Drawing.Point(8, 8);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(75, 17);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Descrição:";
            // 
            // panelBtnCadastrar
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panelBtnCadastrar, 3);
            this.panelBtnCadastrar.Controls.Add(this.btnCadastrar);
            this.panelBtnCadastrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBtnCadastrar.Location = new System.Drawing.Point(4, 288);
            this.panelBtnCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.panelBtnCadastrar.Name = "panelBtnCadastrar";
            this.panelBtnCadastrar.Size = new System.Drawing.Size(626, 58);
            this.panelBtnCadastrar.TabIndex = 9;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(239)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(241, 4);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(152, 48);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DTPFabricacao);
            this.panel3.Controls.Add(this.lblDataFabricacao);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(215, 178);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(203, 102);
            this.panel3.TabIndex = 7;
            // 
            // DTPFabricacao
            // 
            this.DTPFabricacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DTPFabricacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFabricacao.Location = new System.Drawing.Point(12, 32);
            this.DTPFabricacao.Name = "DTPFabricacao";
            this.DTPFabricacao.Size = new System.Drawing.Size(186, 23);
            this.DTPFabricacao.TabIndex = 5;
            // 
            // lblDataFabricacao
            // 
            this.lblDataFabricacao.AutoSize = true;
            this.lblDataFabricacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFabricacao.ForeColor = System.Drawing.Color.White;
            this.lblDataFabricacao.Location = new System.Drawing.Point(12, 5);
            this.lblDataFabricacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataFabricacao.Name = "lblDataFabricacao";
            this.lblDataFabricacao.Size = new System.Drawing.Size(136, 17);
            this.lblDataFabricacao.TabIndex = 3;
            this.lblDataFabricacao.Text = "Data de Fabricação:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(634, 107);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Cadastro de Produtos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // fornecedoresTableAdapter
            // 
            this.fornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // RegisterProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(156)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "RegisterProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qr Águas - Cadastrar Produto";
            this.Load += new System.EventHandler(this.RegisterProduct_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._0ybkkaeekeDataSetRegisterProductCategorias)).EndInit();
            this.panelPrecoCompra.ResumeLayout(false);
            this.panelPrecoCompra.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelFornecedor.ResumeLayout(false);
            this.panelFornecedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._0ybkkaeekeDataSetRegisterProductFornecedores)).EndInit();
            this.panelPrecoEntrega.ResumeLayout(false);
            this.panelPrecoEntrega.PerformLayout();
            this.panelDescricao.ResumeLayout(false);
            this.panelDescricao.PerformLayout();
            this.panelBtnCadastrar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelFornecedor;
        private System.Windows.Forms.Panel panelPrecoCompra;
        private System.Windows.Forms.TextBox txtPrecoCompra;
        private System.Windows.Forms.Label lblPrecoCompra;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.Label lblCodProduto;
        private System.Windows.Forms.Panel panelPrecoEntrega;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.Label lblPrecoVenda;
        private System.Windows.Forms.Panel panelDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Panel panelBtnCadastrar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDataFabricacao;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblDataValidade;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox CBCategoria;
        private _0ybkkaeekeDataSetRegisterProduct _0ybkkaeekeDataSetRegisterProductCategorias;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private _0ybkkaeekeDataSetRegisterProductTableAdapters.categoriasTableAdapter categoriasTableAdapter;
        private System.Windows.Forms.ComboBox CBFornecedor;
        private _0ybkkaeekeDataSetRegisterProductFornecedores _0ybkkaeekeDataSetRegisterProductFornecedores;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private _0ybkkaeekeDataSetRegisterProductFornecedoresTableAdapters.fornecedoresTableAdapter fornecedoresTableAdapter;
        private System.Windows.Forms.DateTimePicker DTPValidade;
        private System.Windows.Forms.DateTimePicker DTPFabricacao;
    }
}