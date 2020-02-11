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
            switch (e.Node.Text)
            {
                case "Cadastro de Galões":
                    RegisterGallon registerGallon = new RegisterGallon();
                    registerGallon.Show();
                    break;

                case "Cadastrar Novo Usuário":
                    RegisterUser objCadastrarUsuario = new RegisterUser();
                    objCadastrarUsuario.Show();
                    break;
            }
                
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //toolStripMenuItem1.Text = Login.NomeUsuario;

            //menuStrip1.Items["Cadastrar Novo Usuário"].Visible = true;
            TSLUsuario.Text = "Usuário: " + Login.NomeUsuario;


        }

        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.Show();
        }

        private void AbrirFormLogin()
        {
            Application.Run(new Login());
        }

    }
}
