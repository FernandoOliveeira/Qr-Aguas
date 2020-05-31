namespace QrAguas.ViewLayer
{
    partial class ReportSells
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportSells));
            this.reportSellsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qrAguasRemoteDBDataSet = new QrAguas.QrAguasRemoteDBDataSet();
            this.RVVendas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelBtnProcurar = new System.Windows.Forms.Panel();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DTPFim = new System.Windows.Forms.DateTimePicker();
            this.lblFim = new System.Windows.Forms.Label();
            this.DTPInicio = new System.Windows.Forms.DateTimePicker();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblSelecionar = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportSellsTableAdapter = new QrAguas.QrAguasRemoteDBDataSetTableAdapters.ReportSellsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportSellsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrAguasRemoteDBDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelBtnProcurar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportSellsBindingSource
            // 
            this.reportSellsBindingSource.DataMember = "ReportSells";
            this.reportSellsBindingSource.DataSource = this.qrAguasRemoteDBDataSet;
            // 
            // qrAguasRemoteDBDataSet
            // 
            this.qrAguasRemoteDBDataSet.DataSetName = "QrAguasRemoteDBDataSet";
            this.qrAguasRemoteDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RVVendas
            // 
            this.RVVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "RepSells";
            reportDataSource1.Value = this.reportSellsBindingSource;
            this.RVVendas.LocalReport.DataSources.Add(reportDataSource1);
            this.RVVendas.LocalReport.ReportEmbeddedResource = "QrAguas.Reports.RepSells.rdlc";
            this.RVVendas.Location = new System.Drawing.Point(0, 0);
            this.RVVendas.Margin = new System.Windows.Forms.Padding(4);
            this.RVVendas.Name = "RVVendas";
            this.RVVendas.ServerReport.BearerToken = null;
            this.RVVendas.Size = new System.Drawing.Size(1128, 364);
            this.RVVendas.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelBtnProcurar, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTitulo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.6771F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.11155F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.21135F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1134, 511);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panelBtnProcurar
            // 
            this.panelBtnProcurar.Controls.Add(this.btnProcurar);
            this.panelBtnProcurar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBtnProcurar.Location = new System.Drawing.Point(570, 77);
            this.panelBtnProcurar.Name = "panelBtnProcurar";
            this.panelBtnProcurar.Size = new System.Drawing.Size(561, 61);
            this.panelBtnProcurar.TabIndex = 16;
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
            this.btnProcurar.Location = new System.Drawing.Point(174, 13);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(206, 40);
            this.btnProcurar.TabIndex = 0;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = false;
            this.btnProcurar.Click += new System.EventHandler(this.BtnProcurar_Click);
            // 
            // lblTitulo
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lblTitulo, 4);
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(3, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1128, 74);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Relatório de Vendas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DTPFim);
            this.panel1.Controls.Add(this.lblFim);
            this.panel1.Controls.Add(this.DTPInicio);
            this.panel1.Controls.Add(this.lblInicio);
            this.panel1.Controls.Add(this.lblSelecionar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 61);
            this.panel1.TabIndex = 15;
            // 
            // DTPFim
            // 
            this.DTPFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.DTPFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFim.Location = new System.Drawing.Point(378, 30);
            this.DTPFim.Name = "DTPFim";
            this.DTPFim.Size = new System.Drawing.Size(130, 21);
            this.DTPFim.TabIndex = 4;
            // 
            // lblFim
            // 
            this.lblFim.AutoSize = true;
            this.lblFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblFim.ForeColor = System.Drawing.Color.White;
            this.lblFim.Location = new System.Drawing.Point(338, 34);
            this.lblFim.Name = "lblFim";
            this.lblFim.Size = new System.Drawing.Size(34, 17);
            this.lblFim.TabIndex = 3;
            this.lblFim.Text = "Fim:";
            // 
            // DTPInicio
            // 
            this.DTPInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.DTPInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPInicio.Location = new System.Drawing.Point(168, 30);
            this.DTPInicio.Name = "DTPInicio";
            this.DTPInicio.Size = new System.Drawing.Size(130, 21);
            this.DTPInicio.TabIndex = 2;
            this.DTPInicio.ValueChanged += new System.EventHandler(this.DTPInicio_ValueChanged);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblInicio.ForeColor = System.Drawing.Color.White;
            this.lblInicio.Location = new System.Drawing.Point(118, 34);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(44, 17);
            this.lblInicio.TabIndex = 1;
            this.lblInicio.Text = "Início:";
            // 
            // lblSelecionar
            // 
            this.lblSelecionar.AutoSize = true;
            this.lblSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblSelecionar.ForeColor = System.Drawing.Color.White;
            this.lblSelecionar.Location = new System.Drawing.Point(102, 4);
            this.lblSelecionar.Name = "lblSelecionar";
            this.lblSelecionar.Size = new System.Drawing.Size(138, 17);
            this.lblSelecionar.TabIndex = 0;
            this.lblSelecionar.Text = "Selecione o período:";
            // 
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 3);
            this.panel2.Controls.Add(this.RVVendas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1128, 364);
            this.panel2.TabIndex = 17;
            // 
            // reportSellsTableAdapter
            // 
            this.reportSellsTableAdapter.ClearBeforeFill = true;
            // 
            // ReportSells
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(156)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(1134, 511);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportSells";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qr Águas - Relatório de Vendas";
            this.Load += new System.EventHandler(this.ReportSells_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportSellsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrAguasRemoteDBDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelBtnProcurar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RVVendas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker DTPFim;
        private System.Windows.Forms.Label lblFim;
        private System.Windows.Forms.DateTimePicker DTPInicio;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblSelecionar;
        private System.Windows.Forms.Panel panelBtnProcurar;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.BindingSource reportSellsBindingSource;
        private QrAguasRemoteDBDataSet qrAguasRemoteDBDataSet;
        private QrAguasRemoteDBDataSetTableAdapters.ReportSellsTableAdapter reportSellsTableAdapter;
        private System.Windows.Forms.Panel panel2;
    }
}