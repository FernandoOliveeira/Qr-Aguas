namespace QrAguas.View_Layer
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.imagemIcone = new System.Windows.Forms.PictureBox();
            this.lblTituloPanel = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblTituloLogo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imagemUsuario = new System.Windows.Forms.PictureBox();
            this.imagemLogo = new System.Windows.Forms.PictureBox();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(52)))), ((int)(((byte)(97)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(14, 266);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(331, 22);
            this.txtUsuario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(73, 232);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(156, 24);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Nome de usuário";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(14, 291);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 1);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(14, 399);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 1);
            this.panel2.TabIndex = 8;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(73, 341);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(65, 24);
            this.lblSenha.TabIndex = 6;
            this.lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(52)))), ((int)(((byte)(97)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.White;
            this.txtSenha.Location = new System.Drawing.Point(14, 375);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '●';
            this.txtSenha.Size = new System.Drawing.Size(331, 22);
            this.txtSenha.TabIndex = 5;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Transparent;
            this.topPanel.Controls.Add(this.imagemIcone);
            this.topPanel.Controls.Add(this.lblTituloPanel);
            this.topPanel.Controls.Add(this.btnInfo);
            this.topPanel.Controls.Add(this.btnFechar);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(350, 31);
            this.topPanel.TabIndex = 9;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ArrastarTela_MouseDown);
            // 
            // imagemIcone
            // 
            this.imagemIcone.Image = global::QrAguas.Properties.Resources.qrAguasIconeGota;
            this.imagemIcone.Location = new System.Drawing.Point(0, 6);
            this.imagemIcone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.imagemIcone.Name = "imagemIcone";
            this.imagemIcone.Size = new System.Drawing.Size(48, 19);
            this.imagemIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagemIcone.TabIndex = 13;
            this.imagemIcone.TabStop = false;
            this.imagemIcone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ArrastarTela_MouseDown);
            // 
            // lblTituloPanel
            // 
            this.lblTituloPanel.AutoSize = true;
            this.lblTituloPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(52)))), ((int)(((byte)(97)))));
            this.lblTituloPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPanel.ForeColor = System.Drawing.Color.White;
            this.lblTituloPanel.Location = new System.Drawing.Point(43, 6);
            this.lblTituloPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloPanel.Name = "lblTituloPanel";
            this.lblTituloPanel.Size = new System.Drawing.Size(80, 20);
            this.lblTituloPanel.TabIndex = 12;
            this.lblTituloPanel.Text = "Qr Águas";
            this.lblTituloPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ArrastarTela_MouseDown);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(52)))), ((int)(((byte)(97)))));
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.Transparent;
            this.btnInfo.Location = new System.Drawing.Point(271, 0);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(36, 31);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "?";
            this.btnInfo.UseVisualStyleBackColor = false;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(52)))), ((int)(((byte)(97)))));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.Transparent;
            this.btnFechar.Location = new System.Drawing.Point(314, 0);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(36, 31);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "✕";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            this.btnFechar.MouseEnter += new System.EventHandler(this.btnFechar_MouseEnter);
            this.btnFechar.MouseLeave += new System.EventHandler(this.btnFechar_MouseLeave);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(239)))));
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.Transparent;
            this.btnEntrar.Location = new System.Drawing.Point(107, 448);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(148, 31);
            this.btnEntrar.TabIndex = 10;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblTituloLogo
            // 
            this.lblTituloLogo.AutoSize = true;
            this.lblTituloLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(52)))), ((int)(((byte)(97)))));
            this.lblTituloLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLogo.ForeColor = System.Drawing.Color.White;
            this.lblTituloLogo.Location = new System.Drawing.Point(131, 162);
            this.lblTituloLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloLogo.Name = "lblTituloLogo";
            this.lblTituloLogo.Size = new System.Drawing.Size(90, 24);
            this.lblTituloLogo.TabIndex = 11;
            this.lblTituloLogo.Text = "Qr Águas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QrAguas.Properties.Resources.senha;
            this.pictureBox1.Location = new System.Drawing.Point(14, 330);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // imagemUsuario
            // 
            this.imagemUsuario.Image = global::QrAguas.Properties.Resources.User;
            this.imagemUsuario.Location = new System.Drawing.Point(14, 220);
            this.imagemUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.imagemUsuario.Name = "imagemUsuario";
            this.imagemUsuario.Size = new System.Drawing.Size(54, 34);
            this.imagemUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagemUsuario.TabIndex = 3;
            this.imagemUsuario.TabStop = false;
            // 
            // imagemLogo
            // 
            this.imagemLogo.Image = global::QrAguas.Properties.Resources.qrAguasIconeGota;
            this.imagemLogo.Location = new System.Drawing.Point(14, 35);
            this.imagemLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.imagemLogo.Name = "imagemLogo";
            this.imagemLogo.Size = new System.Drawing.Size(331, 123);
            this.imagemLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagemLogo.TabIndex = 0;
            this.imagemLogo.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(52)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(350, 500);
            this.Controls.Add(this.lblTituloLogo);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.imagemUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.imagemLogo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qr Águas - Login";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagemLogo;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox imagemUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblTituloLogo;
        private System.Windows.Forms.Label lblTituloPanel;
        private System.Windows.Forms.PictureBox imagemIcone;
    }
}