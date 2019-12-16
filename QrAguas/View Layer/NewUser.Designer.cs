namespace QrAguas.View_Layer
{
    partial class NewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUser));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuarioComentario = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.panelSenha = new System.Windows.Forms.Panel();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.panelConfirmarSenha = new System.Windows.Forms.Panel();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFuncao = new System.Windows.Forms.Label();
            this.CBFuncao = new System.Windows.Forms.ComboBox();
            this.tipousuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qraguasDataSet1 = new QrAguas.qraguasDataSet1();
            this.tipousuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tipo_usuarioTableAdapter1 = new QrAguas.qraguasDataSet1TableAdapters.tipo_usuarioTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelUsuario.SuspendLayout();
            this.panelSenha.SuspendLayout();
            this.panelConfirmarSenha.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipousuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qraguasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipousuarioBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(4, 3);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(120, 17);
            this.lblUsuario.TabIndex = 42;
            this.lblUsuario.Text = "Nome de usuário:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario.Location = new System.Drawing.Point(4, 23);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUsuario.MaxLength = 15;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(235, 23);
            this.txtUsuario.TabIndex = 40;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // lblUsuarioComentario
            // 
            this.lblUsuarioComentario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuarioComentario.AutoSize = true;
            this.lblUsuarioComentario.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioComentario.Location = new System.Drawing.Point(5, 49);
            this.lblUsuarioComentario.Name = "lblUsuarioComentario";
            this.lblUsuarioComentario.Size = new System.Drawing.Size(99, 13);
            this.lblUsuarioComentario.TabIndex = 43;
            this.lblUsuarioComentario.Text = "Máx: 15 Caracteres";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel1.Controls.Add(this.panelUsuario, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelSenha, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelConfirmarSenha, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.03226F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.96774F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(634, 361);
            this.tableLayoutPanel1.TabIndex = 44;
            // 
            // panelUsuario
            // 
            this.panelUsuario.Controls.Add(this.lblUsuario);
            this.panelUsuario.Controls.Add(this.txtUsuario);
            this.panelUsuario.Controls.Add(this.lblUsuarioComentario);
            this.panelUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUsuario.Location = new System.Drawing.Point(3, 3);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(243, 64);
            this.panelUsuario.TabIndex = 0;
            // 
            // panelSenha
            // 
            this.panelSenha.Controls.Add(this.lblSenha);
            this.panelSenha.Controls.Add(this.txtSenha);
            this.panelSenha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSenha.Location = new System.Drawing.Point(3, 73);
            this.panelSenha.Name = "panelSenha";
            this.panelSenha.Size = new System.Drawing.Size(243, 66);
            this.panelSenha.TabIndex = 1;
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(4, 3);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(53, 17);
            this.lblSenha.TabIndex = 42;
            this.lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenha.BackColor = System.Drawing.Color.White;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.Black;
            this.txtSenha.Location = new System.Drawing.Point(4, 23);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSenha.MaxLength = 15;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '●';
            this.txtSenha.Size = new System.Drawing.Size(235, 23);
            this.txtSenha.TabIndex = 40;
            // 
            // panelConfirmarSenha
            // 
            this.panelConfirmarSenha.Controls.Add(this.lblConfirmarSenha);
            this.panelConfirmarSenha.Controls.Add(this.txtConfirmarSenha);
            this.panelConfirmarSenha.Location = new System.Drawing.Point(252, 73);
            this.panelConfirmarSenha.Name = "panelConfirmarSenha";
            this.panelConfirmarSenha.Size = new System.Drawing.Size(243, 66);
            this.panelConfirmarSenha.TabIndex = 2;
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarSenha.ForeColor = System.Drawing.Color.White;
            this.lblConfirmarSenha.Location = new System.Drawing.Point(4, 3);
            this.lblConfirmarSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(118, 17);
            this.lblConfirmarSenha.TabIndex = 42;
            this.lblConfirmarSenha.Text = "Confirmar Senha:";
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmarSenha.BackColor = System.Drawing.Color.White;
            this.txtConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarSenha.ForeColor = System.Drawing.Color.Black;
            this.txtConfirmarSenha.Location = new System.Drawing.Point(4, 23);
            this.txtConfirmarSenha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtConfirmarSenha.MaxLength = 15;
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.PasswordChar = '●';
            this.txtConfirmarSenha.Size = new System.Drawing.Size(235, 23);
            this.txtConfirmarSenha.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CBFuncao);
            this.panel1.Controls.Add(this.lblFuncao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 81);
            this.panel1.TabIndex = 4;
            // 
            // lblFuncao
            // 
            this.lblFuncao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFuncao.AutoSize = true;
            this.lblFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncao.ForeColor = System.Drawing.Color.White;
            this.lblFuncao.Location = new System.Drawing.Point(4, 3);
            this.lblFuncao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFuncao.Name = "lblFuncao";
            this.lblFuncao.Size = new System.Drawing.Size(210, 17);
            this.lblFuncao.TabIndex = 42;
            this.lblFuncao.Text = "Selecione a Função do Usuário:";
            // 
            // CBFuncao
            // 
            this.CBFuncao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBFuncao.DataSource = this.tipousuarioBindingSource1;
            this.CBFuncao.DisplayMember = "DESCRICAO";
            this.CBFuncao.FormattingEnabled = true;
            this.CBFuncao.Location = new System.Drawing.Point(4, 23);
            this.CBFuncao.Name = "CBFuncao";
            this.CBFuncao.Size = new System.Drawing.Size(235, 21);
            this.CBFuncao.TabIndex = 43;
            this.CBFuncao.ValueMember = "ID_TIPO_USUARIO";
            // 
            // qraguasDataSet
            // 
            // tipousuarioBindingSource
            // 
            this.tipousuarioBindingSource.DataMember = "tipo_usuario";
            // 
            // tipo_usuarioTableAdapter
            // 
            // 
            // qraguasDataSet1
            // 
            this.qraguasDataSet1.DataSetName = "qraguasDataSet1";
            this.qraguasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipousuarioBindingSource1
            // 
            this.tipousuarioBindingSource1.DataMember = "tipo_usuario";
            this.tipousuarioBindingSource1.DataSource = this.qraguasDataSet1;
            // 
            // tipo_usuarioTableAdapter1
            // 
            this.tipo_usuarioTableAdapter1.ClearBeforeFill = true;
            // 
            // CadastrarNovoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(156)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CadastrarNovoUsuario";
            this.Text = "Qr Águas - Cadastrar Usuario";
            this.Load += new System.EventHandler(this.CadastrarNovoUsuario_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelUsuario.ResumeLayout(false);
            this.panelUsuario.PerformLayout();
            this.panelSenha.ResumeLayout(false);
            this.panelSenha.PerformLayout();
            this.panelConfirmarSenha.ResumeLayout(false);
            this.panelConfirmarSenha.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipousuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qraguasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipousuarioBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuarioComentario;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.Panel panelSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Panel panelConfirmarSenha;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CBFuncao;
        private System.Windows.Forms.Label lblFuncao;
        private System.Windows.Forms.BindingSource tipousuarioBindingSource;
        private qraguasDataSet1 qraguasDataSet1;
        private System.Windows.Forms.BindingSource tipousuarioBindingSource1;
        private qraguasDataSet1TableAdapters.tipo_usuarioTableAdapter tipo_usuarioTableAdapter1;
    }
}