﻿namespace QrAguas.View_Layer
{
    partial class RegisterUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterUser));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuarioAviso = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.panelSenha = new System.Windows.Forms.Panel();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.panelConfirmarSenha = new System.Windows.Forms.Panel();
            this.lblConfirmarSenhaAviso = new System.Windows.Forms.Label();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBFuncao = new System.Windows.Forms.ComboBox();
            this.lblFuncao = new System.Windows.Forms.Label();
            this.panelBtnCadastrar = new System.Windows.Forms.Panel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.qrAguasRemoteDBDataSet = new QrAguas.QrAguasRemoteDBDataSet();
            this.tIPOUSUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tIPO_USUARIOTableAdapter = new QrAguas.QrAguasRemoteDBDataSetTableAdapters.TIPO_USUARIOTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelUsuario.SuspendLayout();
            this.panelSenha.SuspendLayout();
            this.panelConfirmarSenha.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelBtnCadastrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qrAguasRemoteDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOUSUARIOBindingSource)).BeginInit();
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
            this.lblUsuario.Size = new System.Drawing.Size(61, 17);
            this.lblUsuario.TabIndex = 42;
            this.lblUsuario.Text = "Usuário:";
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
            this.txtUsuario.Size = new System.Drawing.Size(303, 23);
            this.txtUsuario.TabIndex = 40;
            this.txtUsuario.TextChanged += new System.EventHandler(this.TxtUsuario_TextChanged);
            // 
            // lblUsuarioAviso
            // 
            this.lblUsuarioAviso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuarioAviso.AutoSize = true;
            this.lblUsuarioAviso.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioAviso.Location = new System.Drawing.Point(5, 49);
            this.lblUsuarioAviso.Name = "lblUsuarioAviso";
            this.lblUsuarioAviso.Size = new System.Drawing.Size(99, 13);
            this.lblUsuarioAviso.TabIndex = 43;
            this.lblUsuarioAviso.Text = "Máx: 15 Caracteres";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelUsuario, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelSenha, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelConfirmarSenha, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelBtnCadastrar, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.51613F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.48387F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(634, 298);
            this.tableLayoutPanel1.TabIndex = 44;
            // 
            // panelUsuario
            // 
            this.panelUsuario.Controls.Add(this.lblUsuario);
            this.panelUsuario.Controls.Add(this.txtUsuario);
            this.panelUsuario.Controls.Add(this.lblUsuarioAviso);
            this.panelUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUsuario.Location = new System.Drawing.Point(3, 3);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(311, 67);
            this.panelUsuario.TabIndex = 0;
            // 
            // panelSenha
            // 
            this.panelSenha.Controls.Add(this.lblSenha);
            this.panelSenha.Controls.Add(this.txtSenha);
            this.panelSenha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSenha.Location = new System.Drawing.Point(3, 76);
            this.panelSenha.Name = "panelSenha";
            this.panelSenha.Size = new System.Drawing.Size(311, 69);
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
            this.txtSenha.MaxLength = 99;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '●';
            this.txtSenha.Size = new System.Drawing.Size(303, 23);
            this.txtSenha.TabIndex = 40;
            this.txtSenha.TextChanged += new System.EventHandler(this.TxtSenha_TextChanged);
            // 
            // panelConfirmarSenha
            // 
            this.panelConfirmarSenha.Controls.Add(this.lblConfirmarSenhaAviso);
            this.panelConfirmarSenha.Controls.Add(this.lblConfirmarSenha);
            this.panelConfirmarSenha.Controls.Add(this.txtConfirmarSenha);
            this.panelConfirmarSenha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConfirmarSenha.Location = new System.Drawing.Point(320, 76);
            this.panelConfirmarSenha.Name = "panelConfirmarSenha";
            this.panelConfirmarSenha.Size = new System.Drawing.Size(311, 69);
            this.panelConfirmarSenha.TabIndex = 2;
            // 
            // lblConfirmarSenhaAviso
            // 
            this.lblConfirmarSenhaAviso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConfirmarSenhaAviso.AutoSize = true;
            this.lblConfirmarSenhaAviso.ForeColor = System.Drawing.Color.White;
            this.lblConfirmarSenhaAviso.Location = new System.Drawing.Point(4, 49);
            this.lblConfirmarSenhaAviso.Name = "lblConfirmarSenhaAviso";
            this.lblConfirmarSenhaAviso.Size = new System.Drawing.Size(34, 13);
            this.lblConfirmarSenhaAviso.TabIndex = 44;
            this.lblConfirmarSenhaAviso.Text = "Texto";
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
            this.txtConfirmarSenha.MaxLength = 99;
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.PasswordChar = '●';
            this.txtConfirmarSenha.Size = new System.Drawing.Size(303, 23);
            this.txtConfirmarSenha.TabIndex = 40;
            this.txtConfirmarSenha.TextChanged += new System.EventHandler(this.TxtConfirmarSenha_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CBFuncao);
            this.panel1.Controls.Add(this.lblFuncao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 68);
            this.panel1.TabIndex = 3;
            // 
            // CBFuncao
            // 
            this.CBFuncao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBFuncao.DataSource = this.tIPOUSUARIOBindingSource;
            this.CBFuncao.DisplayMember = "DESCRICAO";
            this.CBFuncao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBFuncao.FormattingEnabled = true;
            this.CBFuncao.IntegralHeight = false;
            this.CBFuncao.Location = new System.Drawing.Point(4, 23);
            this.CBFuncao.Name = "CBFuncao";
            this.CBFuncao.Size = new System.Drawing.Size(303, 21);
            this.CBFuncao.TabIndex = 43;
            this.CBFuncao.ValueMember = "ID_TIPO_USUARIO";
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
            // panelBtnCadastrar
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panelBtnCadastrar, 2);
            this.panelBtnCadastrar.Controls.Add(this.btnCadastrar);
            this.panelBtnCadastrar.Location = new System.Drawing.Point(3, 225);
            this.panelBtnCadastrar.Name = "panelBtnCadastrar";
            this.panelBtnCadastrar.Size = new System.Drawing.Size(628, 70);
            this.panelBtnCadastrar.TabIndex = 4;
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
            this.btnCadastrar.Location = new System.Drawing.Point(197, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(233, 37);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(634, 60);
            this.lblTitulo.TabIndex = 45;
            this.lblTitulo.Text = "Cadastro de Usuários";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // qrAguasRemoteDBDataSet
            // 
            this.qrAguasRemoteDBDataSet.DataSetName = "QrAguasRemoteDBDataSet";
            this.qrAguasRemoteDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tIPOUSUARIOBindingSource
            // 
            this.tIPOUSUARIOBindingSource.DataMember = "TIPO_USUARIO";
            this.tIPOUSUARIOBindingSource.DataSource = this.qrAguasRemoteDBDataSet;
            // 
            // tIPO_USUARIOTableAdapter
            // 
            this.tIPO_USUARIOTableAdapter.ClearBeforeFill = true;
            // 
            // RegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(156)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegisterUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qr Águas - Cadastro de Usuários";
            this.Load += new System.EventHandler(this.RegisterUser_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelUsuario.ResumeLayout(false);
            this.panelUsuario.PerformLayout();
            this.panelSenha.ResumeLayout(false);
            this.panelSenha.PerformLayout();
            this.panelConfirmarSenha.ResumeLayout(false);
            this.panelConfirmarSenha.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelBtnCadastrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qrAguasRemoteDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOUSUARIOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuarioAviso;
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
        private System.Windows.Forms.Panel panelBtnCadastrar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblConfirmarSenhaAviso;
        private System.Windows.Forms.Label lblTitulo;
        private QrAguasRemoteDBDataSet qrAguasRemoteDBDataSet;
        private System.Windows.Forms.BindingSource tIPOUSUARIOBindingSource;
        private QrAguasRemoteDBDataSetTableAdapters.TIPO_USUARIOTableAdapter tIPO_USUARIOTableAdapter;
    }
}