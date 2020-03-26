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

        private void MainForm_Load(object sender, EventArgs e)
        {
            TSLUsuario.Text = "Usuário: " + Login.NomeUsuario;


            if (Login.TipoUsuario.Equals(2)) // Caso o usuário seja do tipo 2 (Auxiliar), algumas telas são restritas para acesso
            {
                treeView.Nodes.Remove(treeView.Nodes[0].Nodes[0].Nodes[2]); // Cadastrar Novo Usuário
            }

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

        private void TreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // Abre o form desejado com base em qual nó foi clicado no treeView
            switch (e.Node.Text)
            {
                #region Cadastros
                case "Cadastrar Novos Fornecedores":

                    bool registerProviderOpen = false;

                    // Início: Este bloco de código impede que sejam abertos múltiplos forms iguais
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form.Text.Equals("Qr Águas - Cadastro de Fornecedores"))
                        {
                            registerProviderOpen = true;
                            form.BringToFront();
                            break;
                        }
                    }
                    if (registerProviderOpen == false)
                    {
                        RegisterProvider registerProviders = new RegisterProvider();
                        registerProviders.Show();
                    }
                    // Fim
                    break;



                case "Cadastrar Novos Produtos":

                    bool registerProductOpen = false;

                    // Início: Este bloco de código impede que sejam abertos múltiplos forms iguais
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form.Text.Equals("Qr Águas - Cadastro de Produtos"))
                        {
                            registerProductOpen = true;
                            form.BringToFront();
                            break;
                        }
                    }
                    if (registerProductOpen == false)
                    {
                        RegisterProduct registerProduct = new RegisterProduct();
                        registerProduct.Show();
                    }
                    // Fim
                    break;



                case "Cadastrar Novos Usuários":

                    bool registerUserOpen = false;

                    // Início: Este bloco de código impede que sejam abertos múltiplos forms iguais
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form.Text.Equals("Qr Águas - Cadastro de Usuários"))
                        {
                            registerUserOpen = true;
                            form.BringToFront();
                            break;
                        }
                    }
                    if (registerUserOpen == false)
                    {
                        RegisterUser objCadastrarUsuario = new RegisterUser();
                        objCadastrarUsuario.Show();
                    }
                    // Fim
                    break;

                case "Cadastrar Novas Categorias":

                    bool registerCategoryOpen = false;

                    // Início: Este bloco de código impede que sejam abertos múltiplos forms iguais
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form.Text.Equals("Qr Águas - Cadastro de Categorias"))
                        {
                            registerCategoryOpen = true;
                            form.BringToFront();
                            break;
                        }
                    }
                    if (registerCategoryOpen == false)
                    {
                        RegisterCategory registerCategory = new RegisterCategory();
                        registerCategory.Show();
                    }
                   // Fim
                    break;

                #endregion


                #region Relatórios
                case "Relatório de Produtos":
                    ProductReport productReport = new ProductReport();
                    productReport.Show();
                    break;
                #endregion
            }


        }

        private void AlterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
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
