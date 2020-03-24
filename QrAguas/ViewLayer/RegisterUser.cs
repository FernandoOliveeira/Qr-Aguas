using QrAguas.Controls;
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
    public partial class RegisterUser : Form
    {
        public RegisterUser()
        {
            InitializeComponent();
        }

        Functions functions = new Functions();
        

        private void LimparCampos()
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
            txtConfirmarSenha.Text = "";
        }

        // Verificação de campos vazios
        private bool CamposVazios()
        {
            if (txtUsuario.Text.Trim().Equals("") ||
                txtSenha.Text.Trim().Equals("") ||
                txtConfirmarSenha.Text.Trim().Equals(""))
            {
                return true;
            }

            return false;
        }

        private void RegisterUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qraguasDataSet.tipo_usuario' table. You can move, or remove it, as needed.
            this.tipo_usuarioTableAdapter.Fill(this.qraguasDataSet.tipo_usuario);

            lblConfirmarSenhaAviso.Text = "As senhas devem ser idênticas";
            
            // btnCadastrar só é habilitado caso haja dado inserido no campo txtUsuario
            btnCadastrar.Enabled = false;
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Length < 5)
            {
                lblUsuarioAviso.Text = "Nome de usuário muito curto";
                lblUsuarioAviso.ForeColor = Color.Red;
                btnCadastrar.Enabled = false;
            }

            else if (txtUsuario.Text.Contains(" ") || txtUsuario.Text.Contains(" "))// Verifica se o texto digitado tem espaços em branco ou o caracter ALT+255
            {
                lblUsuarioAviso.Text = "Não pode haver espaços";
                lblUsuarioAviso.ForeColor = Color.Red;
                btnCadastrar.Enabled = false;
            }

            else if (txtUsuario.Text.Length == 15)
            {
                // Caso seja digitado o máximo de 15 caracteres o texto de aviso se torna vermelho
                lblUsuarioAviso.ForeColor = Color.Red;

            }
            else
            {
                lblUsuarioAviso.Text = "Máx: 15 Caracteres";
                lblUsuarioAviso.ForeColor = Color.White;
                btnCadastrar.Enabled = true;
            }

        }

        private void TxtSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtSenha.Text.Trim().Equals(txtConfirmarSenha.Text))
            {
                lblConfirmarSenhaAviso.Text = "As senhas devem ser idênticas";
                lblConfirmarSenhaAviso.ForeColor = Color.White;
                btnCadastrar.Enabled = true;
            }
            else
            {
                lblConfirmarSenhaAviso.Text = "As senhas devem ser idênticas";
                lblConfirmarSenhaAviso.ForeColor = Color.Red;

            }
        }

        private void TxtConfirmarSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmarSenha.Text.Trim().Equals(txtSenha.Text))
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

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (CamposVazios())
            {
                MessageBox.Show("Um ou mais campos estão vazios", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                if (functions.VerificarNomeUsuario(txtUsuario.Text.Trim())) // Verifica se o nome de usuario já existe
                {
                    MessageBox.Show("Nome de usuário já cadastrado", "Nome de usuário existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        NewUser objNovoUsuario = new NewUser
                        {
                            NomeUsuario = txtUsuario.Text.Trim(),
                            Senha = functions.GerarMd5(txtConfirmarSenha.Text),
                            IdTipoUsuario = (int)CBFuncao.SelectedValue,
                            CadastradoPor = Login.NomeUsuario
                        };

                        if (functions.VerificarDadosUsuario(objNovoUsuario))
                        {
                            functions.AbrirBanco();
                            functions.CadastrarNovoUsuario(objNovoUsuario);
                            functions.FecharBanco(functions.AbrirBanco());

                            MessageBox.Show("Usuário cadastrado com sucesso !", "Usuário Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LimparCampos();
                        }
                        else
                        {
                            MessageBox.Show("Um ou mais campos estão vazios", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Um ou mais campos estão vazios\nPreencha todos os campos antes de continuar.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
        }

        

    }
}
