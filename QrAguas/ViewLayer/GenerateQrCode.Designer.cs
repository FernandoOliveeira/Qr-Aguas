namespace QrAguas.ViewLayer
{
    partial class GenerateQrCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateQrCode));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GBVerQrCode = new System.Windows.Forms.GroupBox();
            this.PBQrCode = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DTPValidade = new System.Windows.Forms.DateTimePicker();
            this.lblDataValidade = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNomeEmpresa = new System.Windows.Forms.Label();
            this.txtNomeEmpresa = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.GBVerQrCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBQrCode)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTitulo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(507, 431);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // GBVerQrCode
            // 
            this.GBVerQrCode.Controls.Add(this.PBQrCode);
            this.GBVerQrCode.Dock = System.Windows.Forms.DockStyle.Right;
            this.GBVerQrCode.ForeColor = System.Drawing.Color.White;
            this.GBVerQrCode.Location = new System.Drawing.Point(513, 0);
            this.GBVerQrCode.Name = "GBVerQrCode";
            this.GBVerQrCode.Size = new System.Drawing.Size(256, 431);
            this.GBVerQrCode.TabIndex = 1;
            this.GBVerQrCode.TabStop = false;
            this.GBVerQrCode.Text = "Visualizar Qr Code";
            // 
            // PBQrCode
            // 
            this.PBQrCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBQrCode.Location = new System.Drawing.Point(3, 19);
            this.PBQrCode.Name = "PBQrCode";
            this.PBQrCode.Size = new System.Drawing.Size(250, 409);
            this.PBQrCode.TabIndex = 0;
            this.PBQrCode.TabStop = false;
            // 
            // lblTitulo
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lblTitulo, 5);
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(3, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(501, 86);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Gerar Qr Code";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.lblNomeProduto);
            this.panel1.Controls.Add(this.txtNomeProduto);
            this.panel1.Location = new System.Drawing.Point(3, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 78);
            this.panel1.TabIndex = 14;
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.ForeColor = System.Drawing.Color.White;
            this.lblNomeProduto.Location = new System.Drawing.Point(4, 10);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(123, 17);
            this.lblNomeProduto.TabIndex = 1;
            this.lblNomeProduto.Text = "Nome do Produto:";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeProduto.Location = new System.Drawing.Point(7, 30);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(159, 23);
            this.txtNomeProduto.TabIndex = 0;
            // 
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.txtTelefone);
            this.panel2.Controls.Add(this.lblTelefone);
            this.panel2.Location = new System.Drawing.Point(306, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 80);
            this.panel2.TabIndex = 15;
            // 
            // lblTelefone
            // 
            this.lblTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.ForeColor = System.Drawing.Color.White;
            this.lblTelefone.Location = new System.Drawing.Point(4, 10);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(68, 17);
            this.lblTelefone.TabIndex = 1;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(7, 30);
            this.txtTelefone.Mask = "(00) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(184, 23);
            this.txtTelefone.TabIndex = 2;
            // 
            // panel5
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel5, 2);
            this.panel5.Controls.Add(this.DTPValidade);
            this.panel5.Controls.Add(this.lblDataValidade);
            this.panel5.Location = new System.Drawing.Point(307, 90);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(196, 71);
            this.panel5.TabIndex = 16;
            // 
            // DTPValidade
            // 
            this.DTPValidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DTPValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPValidade.Location = new System.Drawing.Point(12, 30);
            this.DTPValidade.Name = "DTPValidade";
            this.DTPValidade.Size = new System.Drawing.Size(178, 23);
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
            this.lblDataValidade.Size = new System.Drawing.Size(126, 17);
            this.lblDataValidade.TabIndex = 3;
            this.lblDataValidade.Text = "Data de Validade:*";
            // 
            // panel3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel3, 2);
            this.panel3.Controls.Add(this.lblNomeEmpresa);
            this.panel3.Controls.Add(this.txtNomeEmpresa);
            this.panel3.Location = new System.Drawing.Point(3, 175);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(196, 78);
            this.panel3.TabIndex = 17;
            // 
            // lblNomeEmpresa
            // 
            this.lblNomeEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomeEmpresa.AutoSize = true;
            this.lblNomeEmpresa.ForeColor = System.Drawing.Color.White;
            this.lblNomeEmpresa.Location = new System.Drawing.Point(4, 10);
            this.lblNomeEmpresa.Name = "lblNomeEmpresa";
            this.lblNomeEmpresa.Size = new System.Drawing.Size(129, 17);
            this.lblNomeEmpresa.TabIndex = 1;
            this.lblNomeEmpresa.Text = "Nome da Empresa:";
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeEmpresa.Location = new System.Drawing.Point(7, 30);
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.Size = new System.Drawing.Size(159, 23);
            this.txtNomeEmpresa.TabIndex = 0;
            // 
            // GenerateQrCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(156)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(769, 431);
            this.Controls.Add(this.GBVerQrCode);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GenerateQrCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qr Águas - Gerar Qr Code";
            this.Load += new System.EventHandler(this.GenerateQrCode_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.GBVerQrCode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBQrCode)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox GBVerQrCode;
        private System.Windows.Forms.PictureBox PBQrCode;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker DTPValidade;
        private System.Windows.Forms.Label lblDataValidade;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNomeEmpresa;
        private System.Windows.Forms.TextBox txtNomeEmpresa;
    }
}