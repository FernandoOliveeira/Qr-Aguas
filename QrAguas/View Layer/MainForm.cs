using QrAguas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QrAguas.View_Layer
{
    public partial class MainForm : Form
    {
        Thread thread;

        public MainForm()
        {
            InitializeComponent();
        }

        
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ao fechar o menu principal é exibido um diálogo, perguntando se o usuário
            // deseja sair ou encerrar a sessão para entrar com outro login e senha

            Logout logout = new Logout();

            DialogResult resposta = logout.ShowDialog();

            if (resposta == DialogResult.OK)
            {
                thread = new Thread(AbrirFormLogin);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else if(resposta == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }

        }

        private void treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //toolStripMenuItem1.Text = Login.NomeUsuario;

            //menuStrip1.Items["Cadastrar Novo Usuário"].Visible = true;
            TSLUsuario.Text = "Usuário: " + Login.NomeUsuario;

            TSLData.Text = DateTime.Now.ToLongDateString();
            TSLHora.Text = DateTime.Now.ToLongTimeString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Atualiza a data e hora a cada segundo
            TSLData.Text = DateTime.Now.ToLongDateString();
            TSLHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterUser objCadastrarUsuario = new RegisterUser();
            objCadastrarUsuario.Show();
        }

        private void AbrirFormLogin()
        {
            Application.Run(new Login());
        }
    }
}
