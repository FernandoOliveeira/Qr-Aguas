namespace QrAguas.ViewLayer
{
    partial class SearchProvider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchProvider));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelFornecedor = new System.Windows.Forms.Panel();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.panelBtnProcurar = new System.Windows.Forms.Panel();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGVFornecedores = new System.Windows.Forms.DataGridView();
            this.qrAguasRemoteDBDataSet = new QrAguas.QrAguasRemoteDBDataSet();
            this.fORNECEDORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fORNECEDORESTableAdapter = new QrAguas.QrAguasRemoteDBDataSetTableAdapters.FORNECEDORESTableAdapter();
            this.iDFORNECEDORESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAZAOSOCIALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNDERECODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMERODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAIRRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPLEMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cELULARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelFornecedor.SuspendLayout();
            this.panelBtnProcurar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFornecedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrAguasRemoteDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORESBindingSource)).BeginInit();
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
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.lblTitulo.Text = "Procurar Fornecedor";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFornecedor
            // 
            this.panelFornecedor.Controls.Add(this.lblFornecedor);
            this.panelFornecedor.Controls.Add(this.txtFornecedor);
            this.panelFornecedor.Location = new System.Drawing.Point(161, 82);
            this.panelFornecedor.Name = "panelFornecedor";
            this.panelFornecedor.Size = new System.Drawing.Size(286, 72);
            this.panelFornecedor.TabIndex = 14;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.ForeColor = System.Drawing.Color.White;
            this.lblFornecedor.Location = new System.Drawing.Point(4, 10);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(192, 17);
            this.lblFornecedor.TabIndex = 1;
            this.lblFornecedor.Text = "Digite o nome do fornecedor:";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFornecedor.Location = new System.Drawing.Point(7, 30);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(249, 23);
            this.txtFornecedor.TabIndex = 0;
            // 
            // panelBtnProcurar
            // 
            this.panelBtnProcurar.Controls.Add(this.btnProcurar);
            this.panelBtnProcurar.Location = new System.Drawing.Point(523, 82);
            this.panelBtnProcurar.Name = "panelBtnProcurar";
            this.panelBtnProcurar.Size = new System.Drawing.Size(279, 72);
            this.panelBtnProcurar.TabIndex = 15;
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
            this.btnProcurar.Size = new System.Drawing.Size(242, 40);
            this.btnProcurar.TabIndex = 0;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = false;
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
            this.iDFORNECEDORESDataGridViewTextBoxColumn,
            this.rAZAOSOCIALDataGridViewTextBoxColumn,
            this.cNPJDataGridViewTextBoxColumn,
            this.eNDERECODataGridViewTextBoxColumn,
            this.nUMERODataGridViewTextBoxColumn,
            this.bAIRRODataGridViewTextBoxColumn,
            this.cIDADEDataGridViewTextBoxColumn,
            this.cOMPLEMENTODataGridViewTextBoxColumn,
            this.uFDataGridViewTextBoxColumn,
            this.tELEFONEDataGridViewTextBoxColumn,
            this.cELULARDataGridViewTextBoxColumn,
            this.cEPDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.Editar,
            this.Excluir});
            this.DGVFornecedores.DataSource = this.fORNECEDORESBindingSource;
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
            // 
            // qrAguasRemoteDBDataSet
            // 
            this.qrAguasRemoteDBDataSet.DataSetName = "QrAguasRemoteDBDataSet";
            this.qrAguasRemoteDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fORNECEDORESBindingSource
            // 
            this.fORNECEDORESBindingSource.DataMember = "FORNECEDORES";
            this.fORNECEDORESBindingSource.DataSource = this.qrAguasRemoteDBDataSet;
            // 
            // fORNECEDORESTableAdapter
            // 
            this.fORNECEDORESTableAdapter.ClearBeforeFill = true;
            // 
            // iDFORNECEDORESDataGridViewTextBoxColumn
            // 
            this.iDFORNECEDORESDataGridViewTextBoxColumn.DataPropertyName = "ID_FORNECEDORES";
            this.iDFORNECEDORESDataGridViewTextBoxColumn.HeaderText = "ID_FORNECEDORES";
            this.iDFORNECEDORESDataGridViewTextBoxColumn.Name = "iDFORNECEDORESDataGridViewTextBoxColumn";
            this.iDFORNECEDORESDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDFORNECEDORESDataGridViewTextBoxColumn.Visible = false;
            // 
            // rAZAOSOCIALDataGridViewTextBoxColumn
            // 
            this.rAZAOSOCIALDataGridViewTextBoxColumn.DataPropertyName = "RAZAO_SOCIAL";
            this.rAZAOSOCIALDataGridViewTextBoxColumn.FillWeight = 73.17446F;
            this.rAZAOSOCIALDataGridViewTextBoxColumn.HeaderText = "Razão Social";
            this.rAZAOSOCIALDataGridViewTextBoxColumn.Name = "rAZAOSOCIALDataGridViewTextBoxColumn";
            this.rAZAOSOCIALDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cNPJDataGridViewTextBoxColumn
            // 
            this.cNPJDataGridViewTextBoxColumn.DataPropertyName = "CNPJ";
            this.cNPJDataGridViewTextBoxColumn.FillWeight = 73.17446F;
            this.cNPJDataGridViewTextBoxColumn.HeaderText = "CNPJ";
            this.cNPJDataGridViewTextBoxColumn.Name = "cNPJDataGridViewTextBoxColumn";
            this.cNPJDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eNDERECODataGridViewTextBoxColumn
            // 
            this.eNDERECODataGridViewTextBoxColumn.DataPropertyName = "ENDERECO";
            this.eNDERECODataGridViewTextBoxColumn.FillWeight = 73.17446F;
            this.eNDERECODataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.eNDERECODataGridViewTextBoxColumn.Name = "eNDERECODataGridViewTextBoxColumn";
            this.eNDERECODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nUMERODataGridViewTextBoxColumn
            // 
            this.nUMERODataGridViewTextBoxColumn.DataPropertyName = "NUMERO";
            this.nUMERODataGridViewTextBoxColumn.FillWeight = 73.17446F;
            this.nUMERODataGridViewTextBoxColumn.HeaderText = "Número";
            this.nUMERODataGridViewTextBoxColumn.Name = "nUMERODataGridViewTextBoxColumn";
            this.nUMERODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bAIRRODataGridViewTextBoxColumn
            // 
            this.bAIRRODataGridViewTextBoxColumn.DataPropertyName = "BAIRRO";
            this.bAIRRODataGridViewTextBoxColumn.FillWeight = 73.17446F;
            this.bAIRRODataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.bAIRRODataGridViewTextBoxColumn.Name = "bAIRRODataGridViewTextBoxColumn";
            this.bAIRRODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cIDADEDataGridViewTextBoxColumn
            // 
            this.cIDADEDataGridViewTextBoxColumn.DataPropertyName = "CIDADE";
            this.cIDADEDataGridViewTextBoxColumn.FillWeight = 73.17446F;
            this.cIDADEDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cIDADEDataGridViewTextBoxColumn.Name = "cIDADEDataGridViewTextBoxColumn";
            this.cIDADEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cOMPLEMENTODataGridViewTextBoxColumn
            // 
            this.cOMPLEMENTODataGridViewTextBoxColumn.DataPropertyName = "COMPLEMENTO";
            this.cOMPLEMENTODataGridViewTextBoxColumn.FillWeight = 115.736F;
            this.cOMPLEMENTODataGridViewTextBoxColumn.HeaderText = "Complemento";
            this.cOMPLEMENTODataGridViewTextBoxColumn.Name = "cOMPLEMENTODataGridViewTextBoxColumn";
            this.cOMPLEMENTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uFDataGridViewTextBoxColumn
            // 
            this.uFDataGridViewTextBoxColumn.DataPropertyName = "UF";
            this.uFDataGridViewTextBoxColumn.FillWeight = 30F;
            this.uFDataGridViewTextBoxColumn.HeaderText = "UF";
            this.uFDataGridViewTextBoxColumn.Name = "uFDataGridViewTextBoxColumn";
            this.uFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tELEFONEDataGridViewTextBoxColumn
            // 
            this.tELEFONEDataGridViewTextBoxColumn.DataPropertyName = "TELEFONE";
            this.tELEFONEDataGridViewTextBoxColumn.FillWeight = 73.17446F;
            this.tELEFONEDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.tELEFONEDataGridViewTextBoxColumn.Name = "tELEFONEDataGridViewTextBoxColumn";
            this.tELEFONEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cELULARDataGridViewTextBoxColumn
            // 
            this.cELULARDataGridViewTextBoxColumn.DataPropertyName = "CELULAR";
            this.cELULARDataGridViewTextBoxColumn.FillWeight = 73.17446F;
            this.cELULARDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.cELULARDataGridViewTextBoxColumn.Name = "cELULARDataGridViewTextBoxColumn";
            this.cELULARDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cEPDataGridViewTextBoxColumn
            // 
            this.cEPDataGridViewTextBoxColumn.DataPropertyName = "CEP";
            this.cEPDataGridViewTextBoxColumn.FillWeight = 73.17446F;
            this.cEPDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.cEPDataGridViewTextBoxColumn.Name = "cEPDataGridViewTextBoxColumn";
            this.cEPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.FillWeight = 73.17446F;
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "Email";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            this.eMAILDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Editar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Editar.DefaultCellStyle = dataGridViewCellStyle2;
            this.Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
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
            // SearchProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(156)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(1034, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SearchProvider";
            this.Text = "Qr Águas - Procurar Fornecedor";
            this.Load += new System.EventHandler(this.SearchProvider_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelFornecedor.ResumeLayout(false);
            this.panelFornecedor.PerformLayout();
            this.panelBtnProcurar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVFornecedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrAguasRemoteDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORESBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource fORNECEDORESBindingSource;
        private QrAguasRemoteDBDataSetTableAdapters.FORNECEDORESTableAdapter fORNECEDORESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDFORNECEDORESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAZAOSOCIALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNDERECODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMERODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bAIRRODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPLEMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cELULARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir;
    }
}