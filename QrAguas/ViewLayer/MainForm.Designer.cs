namespace QrAguas.View_Layer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Cadastrar Novos Fornecedores", 1, 1);
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Cadastrar Novos Produtos", 1, 1);
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Cadastrar Novos Usuários", 1, 1);
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Cadastrar Novas Categorias", 1, 1);
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Cadastros", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Entrada de Novos Galões", -2, -2);
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Venda de Produtos", 1, 1);
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Vendas", new System.Windows.Forms.TreeNode[] {
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Relatório de Vendas", 1, 1);
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Relatório de Fornecedores", 1, 1);
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Relatório de Produtos", 1, 1);
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Relatórios", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Qr Águas - Menu Geral", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode21,
            treeNode25});
            this.TreeViewImageList = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.segundoItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procurarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSLUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TreeViewImageList
            // 
            this.TreeViewImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TreeViewImageList.ImageStream")));
            this.TreeViewImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.TreeViewImageList.Images.SetKeyName(0, "");
            this.TreeViewImageList.Images.SetKeyName(1, "");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.segundoItemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.menuStrip1.Size = new System.Drawing.Size(934, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // segundoItemToolStripMenuItem
            // 
            this.segundoItemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.procurarUsuarioToolStripMenuItem,
            this.alterarSenhaToolStripMenuItem});
            this.segundoItemToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.segundoItemToolStripMenuItem.Name = "segundoItemToolStripMenuItem";
            this.segundoItemToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.segundoItemToolStripMenuItem.Text = "Opções";
            // 
            // procurarUsuarioToolStripMenuItem
            // 
            this.procurarUsuarioToolStripMenuItem.Name = "procurarUsuarioToolStripMenuItem";
            this.procurarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.procurarUsuarioToolStripMenuItem.Text = "Procurar Usuário";
            this.procurarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.ProcurarUsuarioToolStripMenuItem_Click);
            // 
            // alterarSenhaToolStripMenuItem
            // 
            this.alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            this.alterarSenhaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.alterarSenhaToolStripMenuItem.Text = "Alterar Senha";
            this.alterarSenhaToolStripMenuItem.Click += new System.EventHandler(this.AlterarSenhaToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSLUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(270, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(664, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TSLUsuario
            // 
            this.TSLUsuario.Name = "TSLUsuario";
            this.TSLUsuario.Size = new System.Drawing.Size(649, 17);
            this.TSLUsuario.Spring = true;
            this.TSLUsuario.Text = "Usuário: ";
            this.TSLUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::QrAguas.Properties.Resources.qrAguasIconeGota;
            this.pictureBox1.Location = new System.Drawing.Point(270, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(664, 538);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // treeView
            // 
            this.treeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.TreeViewImageList;
            this.treeView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.treeView.Location = new System.Drawing.Point(0, 24);
            this.treeView.Name = "treeView";
            treeNode14.ImageIndex = 1;
            treeNode14.Name = "Node0";
            treeNode14.SelectedImageIndex = 1;
            treeNode14.Text = "Cadastrar Novos Fornecedores";
            treeNode15.ImageIndex = 1;
            treeNode15.Name = "Node1";
            treeNode15.SelectedImageIndex = 1;
            treeNode15.Text = "Cadastrar Novos Produtos";
            treeNode16.ImageIndex = 1;
            treeNode16.Name = "Node2";
            treeNode16.SelectedImageIndex = 1;
            treeNode16.Text = "Cadastrar Novos Usuários";
            treeNode17.ImageIndex = 1;
            treeNode17.Name = "Node3";
            treeNode17.SelectedImageIndex = 1;
            treeNode17.Text = "Cadastrar Novas Categorias";
            treeNode18.Name = "Node0";
            treeNode18.SelectedImageIndex = -2;
            treeNode18.Text = "Cadastros";
            treeNode19.ImageIndex = -2;
            treeNode19.Name = "Node1";
            treeNode19.SelectedImageIndex = -2;
            treeNode19.Text = "Entrada de Novos Galões";
            treeNode20.ImageIndex = 1;
            treeNode20.Name = "Node6";
            treeNode20.SelectedImageIndex = 1;
            treeNode20.Text = "Venda de Produtos";
            treeNode21.Name = "Node2";
            treeNode21.Text = "Vendas";
            treeNode22.ImageIndex = 1;
            treeNode22.Name = "Node0";
            treeNode22.SelectedImageIndex = 1;
            treeNode22.Text = "Relatório de Vendas";
            treeNode23.ImageIndex = 1;
            treeNode23.Name = "Node1";
            treeNode23.SelectedImageIndex = 1;
            treeNode23.Text = "Relatório de Fornecedores";
            treeNode24.ImageIndex = 1;
            treeNode24.Name = "Node2";
            treeNode24.SelectedImageIndex = 1;
            treeNode24.Text = "Relatório de Produtos";
            treeNode25.Name = "Node3";
            treeNode25.Text = "Relatórios";
            treeNode26.ImageIndex = 0;
            treeNode26.Name = "Node0";
            treeNode26.SelectedImageIndex = 0;
            treeNode26.Text = "Qr Águas - Menu Geral";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode26});
            this.treeView.SelectedImageIndex = 0;
            this.treeView.Size = new System.Drawing.Size(270, 538);
            this.treeView.TabIndex = 0;
            this.treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView_NodeMouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(156)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(934, 562);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qr Águas - Menu Principal ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem segundoItemToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TSLUsuario;
        private System.Windows.Forms.ImageList TreeViewImageList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ToolStripMenuItem procurarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarSenhaToolStripMenuItem;
    }
}