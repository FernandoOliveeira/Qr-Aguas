using QrAguas.Controls;
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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        Functions functions = new Functions();
        ChangePasswordMethods ChangePasswordMethods = new ChangePasswordMethods();

        private void LimparCampos()
        {
            lblSenhaAtualAviso.Text = "";

            txtSenhaAtual.Text = "";
            txtNovaSenha.Text = "";
            txtConfirmarSenha.Text = "";
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = Login.NomeUsuario; // TextBox Usuário recebe o Nome de Usuário logado no sistema

            lblConfirmarSenhaAviso.Text = "As senhas devem ser idênticas";
            lblSenhaAtualAviso.Text = "";
        }
        
        private void TxtNovaSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtNovaSenha.Text.Trim().Equals(txtConfirmarSenha.Text))
            {
                lblConfirmarSenhaAviso.Text = "As senhas devem ser idênticas";
                lblConfirmarSenhaAviso.ForeColor = Color.White;

            }
            else
            {
                lblConfirmarSenhaAviso.Text = "As senhas devem ser idênticas";
                lblConfirmarSenhaAviso.ForeColor = Color.Red;

            }
        }

        private void TxtConfirmarSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmarSenha.Text.Trim().Equals(txtNovaSenha.Text))
            {
                lblConfirmarSenhaAviso.Text = "As senhas devem ser idênticas";
                lblConfirmarSenhaAviso.ForeColor = Color.White;

            }
            else
            {
                lblConfirmarSenhaAviso.Text = "As senhas devem ser idênticas";
                lblConfirmarSenhaAviso.ForeColor = Color.Red;

            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            // Se um mais campos estiverem vazios, aparecerá uma mensagem de erro
            if (txtSenhaAtual.Text.Trim().Equals("") ||
                txtNovaSenha.Text.Trim().Equals("") ||
                txtConfirmarSenha.Text.Trim().Equals(""))
            {
                MessageBox.Show("Um ou mais campos estão vazios.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Se a Nova Senha for diferente da Confirmação de senha, aparecerá uma mensagem de erro
                if (!txtConfirmarSenha.Text.Trim().Equals(txtNovaSenha.Text.Trim()))
                {
                    MessageBox.Show("As senhas devem ser idênticas.", "Senhas Incompatíveis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string senhaAtualMd5 = functions.GerarMd5(txtSenhaAtual.Text.Trim());

                    // Verifica se a senha digitada no campo "Senha Atual" é a mesma que esta no banco
                    if (functions.VerificarLogin(Login.NomeUsuario, senhaAtualMd5))
                    {
                        string novaSenhaMd5 = functions.GerarMd5(txtConfirmarSenha.Text.Trim());

                        if (ChangePasswordMethods.AlterarSenha(novaSenhaMd5, Login.NomeUsuario))
                        {
                            MessageBox.Show("Senha alterada com sucesso !", "Senha alterada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LimparCampos();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao alterar a senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        lblSenhaAtualAviso.Text = "Senha incorreta";
                        lblSenhaAtualAviso.ForeColor = Color.Red;

                        MessageBox.Show("A Senha Atual está incorreta.", "Senha Incorreta", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    }
                }
            }
            
        }
    }
}
