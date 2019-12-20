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
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Cadastro de Fornecedores", 1, 1);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Cadastro de Galões", 1, 1);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Cadastros", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Entrada de Novos Galões", -2, -2);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Venda de Galões", 1, 1);
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Vendas", new System.Windows.Forms.TreeNode[] {
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Qr Águas - Menu Geral", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode13});
            this.TreeViewImageList = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.segundoItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSLUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSLData = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSLHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // segundoItemToolStripMenuItem
            // 
            this.segundoItemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarUsuárioToolStripMenuItem,
            this.alterarSenhaToolStripMenuItem});
            this.segundoItemToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.segundoItemToolStripMenuItem.Name = "segundoItemToolStripMenuItem";
            this.segundoItemToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.segundoItemToolStripMenuItem.Text = "Opções";
            // 
            // cadastrarUsuárioToolStripMenuItem
            // 
            this.cadastrarUsuárioToolStripMenuItem.Name = "cadastrarUsuárioToolStripMenuItem";
            this.cadastrarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarUsuárioToolStripMenuItem.Text = "Cadastrar Usuário";
            this.cadastrarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.cadastrarUsuárioToolStripMenuItem_Click);
            // 
            // alterarSenhaToolStripMenuItem
            // 
            this.alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            this.alterarSenhaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alterarSenhaToolStripMenuItem.Text = "Alterar Senha";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSLUsuario,
            this.TSLData,
            this.TSLHora});
            this.statusStrip1.Location = new System.Drawing.Point(251, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(757, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TSLUsuario
            // 
            this.TSLUsuario.Name = "TSLUsuario";
            this.TSLUsuario.Size = new System.Drawing.Size(247, 17);
            this.TSLUsuario.Spring = true;
            this.TSLUsuario.Text = "Usuário: ";
            // 
            // TSLData
            // 
            this.TSLData.Name = "TSLData";
            this.TSLData.Size = new System.Drawing.Size(247, 17);
            this.TSLData.Spring = true;
            this.TSLData.Text = "Data";
            // 
            // TSLHora
            // 
            this.TSLHora.Name = "TSLHora";
            this.TSLHora.Size = new System.Drawing.Size(247, 17);
            this.TSLHora.Spring = true;
            this.TSLHora.Text = "Hora";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::QrAguas.Properties.Resources.qrAguasIconeGota;
            this.pictureBox1.Location = new System.Drawing.Point(251, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(757, 538);
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
            treeNode8.ImageIndex = 1;
            treeNode8.Name = "Node1";
            treeNode8.SelectedImageIndex = 1;
            treeNode8.Text = "Cadastro de Fornecedores";
            treeNode9.ImageIndex = 1;
            treeNode9.Name = "Node3";
            treeNode9.SelectedImageIndex = 1;
            treeNode9.Text = "Cadastro de Galões";
            treeNode10.Name = "Node0";
            treeNode10.SelectedImageIndex = -2;
            treeNode10.Text = "Cadastros";
            treeNode11.ImageIndex = -2;
            treeNode11.Name = "Node0";
            treeNode11.SelectedImageIndex = -2;
            treeNode11.Text = "Entrada de Novos Galões";
            treeNode12.ImageIndex = 1;
            treeNode12.Name = "Node6";
            treeNode12.SelectedImageIndex = 1;
            treeNode12.Text = "Venda de Galões";
            treeNode13.Name = "Node5";
            treeNode13.Text = "Vendas";
            treeNode14.ImageIndex = 0;
            treeNode14.Name = "Node0";
            treeNode14.SelectedImageIndex = 0;
            treeNode14.Text = "Qr Águas - Menu Geral";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode14});
            this.treeView.SelectedImageIndex = 0;
            this.treeView.Size = new System.Drawing.Size(251, 538);
            this.treeView.TabIndex = 0;
            this.treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(156)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(1008, 562);
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
        private System.Windows.Forms.ToolStripStatusLabel TSLData;
        private System.Windows.Forms.ToolStripStatusLabel TSLHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList TreeViewImageList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ToolStripMenuItem cadastrarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarSenhaToolStripMenuItem;
    }
}