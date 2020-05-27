namespace QrAguas.ViewLayer
{
    partial class SearchProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchProduct));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelFornecedor = new System.Windows.Forms.Panel();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.panelBtnProcurar = new System.Windows.Forms.Panel();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGVFornecedores = new System.Windows.Forms.DataGridView();
            this.iDPRODUTOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMECATEGORIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUANTIDADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECOCOMPRADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECOVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAZAOSOCIALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAVALIDADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATACADASTRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atualizar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.searchProductDGVProdutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qrAguasRemoteDBDataSet = new QrAguas.QrAguasRemoteDBDataSet();
            this.searchProductDGVProdutosTableAdapter = new QrAguas.QrAguasRemoteDBDataSetTableAdapters.SearchProductDGVProdutosTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelFornecedor.SuspendLayout();
            this.panelBtnProcurar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFornecedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchProductDGVProdutosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrAguasRemoteDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.32189F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.01199F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.17266F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.32284F));
            this.tableLayoutPanel1.Controls.Add(this.lblTitulo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelFornecedor, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelBtnProcurar, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.23301F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.93204F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.74696F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1034, 461);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lblTitulo, 4);
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(3, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1028, 79);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Procurar Produto";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFornecedor
            // 
            this.panelFornecedor.Controls.Add(this.lblFornecedor);
            this.panelFornecedor.Controls.Add(this.txtFornecedor);
            this.panelFornecedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFornecedor.Location = new System.Drawing.Point(161, 82);
            this.panelFornecedor.Name = "panelFornecedor";
            this.panelFornecedor.Size = new System.Drawing.Size(356, 81);
            this.panelFornecedor.TabIndex = 0;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblFornecedor.ForeColor = System.Drawing.Color.White;
            this.lblFornecedor.Location = new System.Drawing.Point(4, 10);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(172, 17);
            this.lblFornecedor.TabIndex = 1;
            this.lblFornecedor.Text = "Digite o nome do produto:";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFornecedor.Location = new System.Drawing.Point(7, 30);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(319, 20);
            this.txtFornecedor.TabIndex = 0;
            this.txtFornecedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtFornecedor_KeyDown);
            // 
            // panelBtnProcurar
            // 
            this.panelBtnProcurar.Controls.Add(this.btnProcurar);
            this.panelBtnProcurar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBtnProcurar.Location = new System.Drawing.Point(523, 82);
            this.panelBtnProcurar.Name = "panelBtnProcurar";
            this.panelBtnProcurar.Size = new System.Drawing.Size(347, 81);
            this.panelBtnProcurar.TabIndex = 1;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(239)))));
            this.btnProcurar.FlatAppearance.BorderSize = 0;
            this.btnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar.ForeColor = System.Drawing.Color.White;
            this.btnProcurar.Location = new System.Drawing.Point(17, 21);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(310, 40);
            this.btnProcurar.TabIndex = 0;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = false;
            this.btnProcurar.Click += new System.EventHandler(this.BtnProcurar_Click);
            // 
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 4);
            this.panel2.Controls.Add(this.DGVFornecedores);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1028, 289);
            this.panel2.TabIndex = 16;
            // 
            // DGVFornecedores
            // 
            this.DGVFornecedores.AllowUserToAddRows = false;
            this.DGVFornecedores.AllowUserToDeleteRows = false;
            this.DGVFornecedores.AutoGenerateColumns = false;
            this.DGVFornecedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVFornecedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGVFornecedores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(156)))), ((int)(((byte)(188)))));
            this.DGVFornecedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVFornecedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVFornecedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVFornecedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPRODUTOSDataGridViewTextBoxColumn,
            this.cODPRODUTODataGridViewTextBoxColumn,
            this.nOMEPRODUTODataGridViewTextBoxColumn,
            this.nOMECATEGORIADataGridViewTextBoxColumn,
            this.dESCRICAODataGridViewTextBoxColumn,
            this.qUANTIDADEDataGridViewTextBoxColumn,
            this.pRECOCOMPRADataGridViewTextBoxColumn,
            this.pRECOVENDADataGridViewTextBoxColumn,
            this.rAZAOSOCIALDataGridViewTextBoxColumn,
            this.dATAVALIDADEDataGridViewTextBoxColumn,
            this.dATACADASTRODataGridViewTextBoxColumn,
            this.Atualizar,
            this.Excluir});
            this.DGVFornecedores.DataSource = this.searchProductDGVProdutosBindingSource;
            this.DGVFornecedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVFornecedores.Location = new System.Drawing.Point(0, 0);
            this.DGVFornecedores.MultiSelect = false;
            this.DGVFornecedores.Name = "DGVFornecedores";
            this.DGVFornecedores.ReadOnly = true;
            this.DGVFornecedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGVFornecedores.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVFornecedores.Size = new System.Drawing.Size(1028, 289);
            this.DGVFornecedores.TabIndex = 1;
            this.DGVFornecedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVFornecedores_CellContentClick);
            // 
            // iDPRODUTOSDataGridViewTextBoxColumn
            // 
            this.iDPRODUTOSDataGridViewTextBoxColumn.DataPropertyName = "ID_PRODUTOS";
            this.iDPRODUTOSDataGridViewTextBoxColumn.HeaderText = "ID_PRODUTOS";
            this.iDPRODUTOSDataGridViewTextBoxColumn.Name = "iDPRODUTOSDataGridViewTextBoxColumn";
            this.iDPRODUTOSDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPRODUTOSDataGridViewTextBoxColumn.Visible = false;
            // 
            // cODPRODUTODataGridViewTextBoxColumn
            // 
            this.cODPRODUTODataGridViewTextBoxColumn.DataPropertyName = "COD_PRODUTO";
            this.cODPRODUTODataGridViewTextBoxColumn.HeaderText = "Código";
            this.cODPRODUTODataGridViewTextBoxColumn.Name = "cODPRODUTODataGridViewTextBoxColumn";
            this.cODPRODUTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMEPRODUTODataGridViewTextBoxColumn
            // 
            this.nOMEPRODUTODataGridViewTextBoxColumn.DataPropertyName = "NOME_PRODUTO";
            this.nOMEPRODUTODataGridViewTextBoxColumn.HeaderText = "Item";
            this.nOMEPRODUTODataGridViewTextBoxColumn.Name = "nOMEPRODUTODataGridViewTextBoxColumn";
            this.nOMEPRODUTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMECATEGORIADataGridViewTextBoxColumn
            // 
            this.nOMECATEGORIADataGridViewTextBoxColumn.DataPropertyName = "NOME_CATEGORIA";
            this.nOMECATEGORIADataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.nOMECATEGORIADataGridViewTextBoxColumn.Name = "nOMECATEGORIADataGridViewTextBoxColumn";
            this.nOMECATEGORIADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESCRICAODataGridViewTextBoxColumn
            // 
            this.dESCRICAODataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO";
            this.dESCRICAODataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.dESCRICAODataGridViewTextBoxColumn.Name = "dESCRICAODataGridViewTextBoxColumn";
            this.dESCRICAODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qUANTIDADEDataGridViewTextBoxColumn
            // 
            this.qUANTIDADEDataGridViewTextBoxColumn.DataPropertyName = "QUANTIDADE";
            this.qUANTIDADEDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.qUANTIDADEDataGridViewTextBoxColumn.Name = "qUANTIDADEDataGridViewTextBoxColumn";
            this.qUANTIDADEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRECOCOMPRADataGridViewTextBoxColumn
            // 
            this.pRECOCOMPRADataGridViewTextBoxColumn.DataPropertyName = "PRECO_COMPRA";
            this.pRECOCOMPRADataGridViewTextBoxColumn.HeaderText = "Preço de Compra";
            this.pRECOCOMPRADataGridViewTextBoxColumn.Name = "pRECOCOMPRADataGridViewTextBoxColumn";
            this.pRECOCOMPRADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRECOVENDADataGridViewTextBoxColumn
            // 
            this.pRECOVENDADataGridViewTextBoxColumn.DataPropertyName = "PRECO_VENDA";
            this.pRECOVENDADataGridViewTextBoxColumn.HeaderText = "Preço de Venda";
            this.pRECOVENDADataGridViewTextBoxColumn.Name = "pRECOVENDADataGridViewTextBoxColumn";
            this.pRECOVENDADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rAZAOSOCIALDataGridViewTextBoxColumn
            // 
            this.rAZAOSOCIALDataGridViewTextBoxColumn.DataPropertyName = "RAZAO_SOCIAL";
            this.rAZAOSOCIALDataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            this.rAZAOSOCIALDataGridViewTextBoxColumn.Name = "rAZAOSOCIALDataGridViewTextBoxColumn";
            this.rAZAOSOCIALDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATAVALIDADEDataGridViewTextBoxColumn
            // 
            this.dATAVALIDADEDataGridViewTextBoxColumn.DataPropertyName = "DATA_VALIDADE";
            this.dATAVALIDADEDataGridViewTextBoxColumn.HeaderText = "Data de Validade";
            this.dATAVALIDADEDataGridViewTextBoxColumn.Name = "dATAVALIDADEDataGridViewTextBoxColumn";
            this.dATAVALIDADEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATACADASTRODataGridViewTextBoxColumn
            // 
            this.dATACADASTRODataGridViewTextBoxColumn.DataPropertyName = "DATA_CADASTRO";
            this.dATACADASTRODataGridViewTextBoxColumn.HeaderText = "Data de Cadastro";
            this.dATACADASTRODataGridViewTextBoxColumn.Name = "dATACADASTRODataGridViewTextBoxColumn";
            this.dATACADASTRODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Atualizar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Atualizar.DefaultCellStyle = dataGridViewCellStyle2;
            this.Atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Atualizar.HeaderText = "Atualizar";
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.ReadOnly = true;
            this.Atualizar.Text = "Atualizar";
            this.Atualizar.UseColumnTextForButtonValue = true;
            // 
            // Excluir
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Excluir.DefaultCellStyle = dataGridViewCellStyle3;
            this.Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseColumnTextForButtonValue = true;
            // 
            // searchProductDGVProdutosBindingSource
            // 
            this.searchProductDGVProdutosBindingSource.DataMember = "SearchProductDGVProdutos";
            this.searchProductDGVProdutosBindingSource.DataSource = this.qrAguasRemoteDBDataSet;
            // 
            // qrAguasRemoteDBDataSet
            // 
            this.qrAguasRemoteDBDataSet.DataSetName = "QrAguasRemoteDBDataSet";
            this.qrAguasRemoteDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchProductDGVProdutosTableAdapter
            // 
            this.searchProductDGVProdutosTableAdapter.ClearBeforeFill = true;
            // 
            // SearchProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(156)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(1034, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qr Águas - Procurar Produto";
            this.Load += new System.EventHandler(this.SearchProduct_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelFornecedor.ResumeLayout(false);
            this.panelFornecedor.PerformLayout();
            this.panelBtnProcurar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVFornecedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchProductDGVProdutosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrAguasRemoteDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelFornecedor;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Panel panelBtnProcurar;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGVFornecedores;
        private QrAguasRemoteDBDataSet qrAguasRemoteDBDataSet;
        private System.Windows.Forms.BindingSource searchProductDGVProdutosBindingSource;
        private QrAguasRemoteDBDataSetTableAdapters.SearchProductDGVProdutosTableAdapter searchProductDGVProdutosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPRODUTOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMECATEGORIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUANTIDADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECOCOMPRADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECOVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAZAOSOCIALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAVALIDADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATACADASTRODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Atualizar;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir;
    }
}