using QrAguas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QrAguas.View_Layer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Exibe uma mensagem caso seja clicado no botão SAIR
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair ?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
           
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //menuStrip1.Items["Cadastrar Novo Usuário"].Visible = true;
            TSLUsuario.Text = "Usuário: " + Login.NomeUsuario;

            TSLData.Text = DateTime.Now.ToLongDateString();
            TSLHora.Text = DateTime.Now.ToLongTimeString();

        }
   
        private void timer1_Tick(object sender, EventArgs e)
        {
            TSLData.Text = DateTime.Now.ToLongDateString();
            TSLHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterUser objCadastrarUsuario = new RegisterUser();
            objCadastrarUsuario.Show();
        }
    }
}
