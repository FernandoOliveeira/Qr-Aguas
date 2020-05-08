namespace QrAguas.ViewLayer
{
    partial class SellProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellProduct));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCarrinho = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtQuantidade = new System.Windows.Forms.NumericUpDown();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblCodProduto = new System.Windows.Forms.Label();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DGVCarrinho = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCarrinho)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.29033F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.67742F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.67742F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.35484F));
            this.tableLayoutPanel1.Controls.Add(this.lblTitulo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCarrinho, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 4, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.03203F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.786477F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.423488F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.35943F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.13167F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.97208F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1034, 562);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lblTitulo, 5);
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(4, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1026, 62);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Venda de Produtos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCarrinho
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lblCarrinho, 2);
            this.lblCarrinho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCarrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblCarrinho.ForeColor = System.Drawing.Color.White;
            this.lblCarrinho.Location = new System.Drawing.Point(192, 62);
            this.lblCarrinho.Name = "lblCarrinho";
            this.lblCarrinho.Size = new System.Drawing.Size(321, 55);
            this.lblCarrinho.TabIndex = 0;
            this.lblCarrinho.Text = "Lista de Compras";
            this.lblCarrinho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(519, 423);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 136);
            this.panel2.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(166, 136);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRemover);
            this.panel3.Controls.Add(this.btnVender);
            this.panel3.Controls.Add(this.btnAdicionar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(691, 293);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 124);
            this.panel3.TabIndex = 1;
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(176, 84);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(111, 37);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.Lime;
            this.btnVender.FlatAppearance.BorderSize = 0;
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.ForeColor = System.Drawing.Color.White;
            this.btnVender.Location = new System.Drawing.Point(54, 84);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(111, 37);
            this.btnVender.TabIndex = 1;
            this.btnVender.Text = "Finalizar";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(239)))));
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(54, 13);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(233, 37);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtQuantidade);
            this.panel4.Controls.Add(this.lblQuantidade);
            this.panel4.Controls.Add(this.lblCodProduto);
            this.panel4.Controls.Add(this.txtCodProduto);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(691, 128);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(340, 159);
            this.panel4.TabIndex = 0;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(82, 119);
            this.txtQuantidade.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.txtQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(177, 23);
            this.txtQuantidade.TabIndex = 1;
            this.txtQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PressionarEnter_KeyDown);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.ForeColor = System.Drawing.Color.White;
            this.lblQuantidade.Location = new System.Drawing.Point(79, 99);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(86, 17);
            this.lblQuantidade.TabIndex = 3;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblCodProduto
            // 
            this.lblCodProduto.AutoSize = true;
            this.lblCodProduto.ForeColor = System.Drawing.Color.White;
            this.lblCodProduto.Location = new System.Drawing.Point(79, 12);
            this.lblCodProduto.Name = "lblCodProduto";
            this.lblCodProduto.Size = new System.Drawing.Size(129, 17);
            this.lblCodProduto.TabIndex = 1;
            this.lblCodProduto.Text = "Código do produto:";
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Location = new System.Drawing.Point(82, 32);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(177, 23);
            this.txtCodProduto.TabIndex = 0;
            this.txtCodProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PressionarEnter_KeyDown);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(691, 423);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(340, 136);
            this.panel5.TabIndex = 9;
            // 
            // DGVCarrinho
            // 
            this.DGVCarrinho.AllowUserToAddRows = false;
            this.DGVCarrinho.AllowUserToDeleteRows = false;
            this.DGVCarrinho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVCarrinho.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGVCarrinho.BackgroundColor = System.Drawing.Color.White;
            this.DGVCarrinho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVCarrinho.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCarrinho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVCarrinho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVCarrinho.Location = new System.Drawing.Point(0, 0);
            this.DGVCarrinho.MultiSelect = false;
            this.DGVCarrinho.Name = "DGVCarrinho";
            this.DGVCarrinho.ReadOnly = true;
            this.DGVCarrinho.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGVCarrinho.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVCarrinho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVCarrinho.Size = new System.Drawing.Size(682, 297);
            this.DGVCarrinho.TabIndex = 1;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 4);
            this.panel1.Controls.Add(this.DGVCarrinho);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 120);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 3);
            this.panel1.Size = new System.Drawing.Size(682, 297);
            this.panel1.TabIndex = 5;
            // 
            // SellProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(156)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(1034, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SellProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qr Águas - Venda de Produtos";
            this.Load += new System.EventHandler(this.SellProduct_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCarrinho)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCarrinho;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblCodProduto;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGVCarrinho;
    }
}