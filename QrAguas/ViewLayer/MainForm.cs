using QrAguas.ViewLayer;
using System;
using System.Threading;
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


            if (Login.TipoUsuario != 1)  // Caso o usuário não seja do tipo 1 (ADM), algumas telas são restritas 
            {
                // Cadastrar Novo Usuário
                treeView.Nodes.Remove(treeView.Nodes[0].Nodes[0].Nodes[2]);
                // Sessão de Consultas
                treeView.Nodes.Remove(treeView.Nodes[0].Nodes[3]); 
                // Procurar Usuário
                procurarUsuarioToolStripMenuItem.Visible = false;
            }

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ao fechar o menu principal é exibido um diálogo, perguntando se o usuário deseja sair ou encerrar a sessão para entrar com outro login e senha

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
            // Abre o form com base em qual nó foi clicado no treeView
            switch (e.Node.Text)
            {
                #region Cadastros
                case "Cadastrar Novos Fornecedores":

                    bool registerProviderOpen = false;

                    // Início: Este bloco de código impede que sejam abertos múltiplos forms iguais
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form.Name == "RegisterProvider")
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
                        if (form.Name == "RegisterProduct")
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
                        if (form.Name == "RegisterUser")
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
                        if (form.Name == "RegisterCategory")
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

                #region Vendas
                case "Venda de Produtos":

                    bool sellProductOpen = false;

                    // Início: Este bloco de código impede que sejam abertos múltiplos forms iguais
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form.Name == "SellProduct")
                        {
                            sellProductOpen = true;
                            form.BringToFront();
                            break;
                        }
                    }
                    if (sellProductOpen == false)
                    {
                        SellProduct sellProduct = new SellProduct();
                        sellProduct.Show();
                    }
                    // Fim
                    break;
                #endregion

                #region Qr Code
                case "Gerar Novo Qr Code":

                    bool generateQrCodeOpen = false;

                    // Início: Este bloco de código impede que sejam abertos múltiplos forms iguais
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form.Name == "GenerateQrCode")
                        {
                            generateQrCodeOpen = true;
                            form.BringToFront();
                            break;
                        }
                    }
                    if (generateQrCodeOpen == false)
                    {
                        GenerateQrCode generateQrCode = new GenerateQrCode();
                        generateQrCode.Show();
                    }
                    // Fim
                    break;
                #endregion

                #region Consultas

                case "Consultar Fornecedores":

                    bool SearchProviderOpen = false;

                    // Início: Este bloco de código impede que sejam abertos múltiplos forms iguais
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form.Name == "SearchProvider")
                        {
                            SearchProviderOpen = true;
                            form.BringToFront();
                            break;
                        }
                    }
                    if (SearchProviderOpen == false)
                    {
                        SearchProvider searchProvider = new SearchProvider();
                        searchProvider.Show();
                    }
                    // Fim
                    break;

                #endregion

                #region Relatórios

                case "Relatório de Produtos":
                    ReportProduct productReport = new ReportProduct();
                    productReport.Show();
                    break;

                case "Relatório de Fornecedores":
                    ReportProvider reportProvider = new ReportProvider();
                    reportProvider.Show();
                    break;

                #endregion
            }

        }

        private void AlterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.Show();
        }

        private void ProcurarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchUser searchUser = new SearchUser();
            searchUser.Show();
        }

        private void AbrirFormLogin()
        {
            Application.Run(new Login());
        }

    }
}
