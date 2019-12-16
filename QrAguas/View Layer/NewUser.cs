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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        Functions functions = new Functions();

        private void NewUser_Load(object sender, EventArgs e)
        {
            // Preenche a DropDownList com os cargos cadastrados no banco de dados
            this.tipo_usuarioTableAdapter1.Fill(this.qraguasDataSet1.tipo_usuario);

            lblConfirmarSenhaAviso.Text = "";

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

            if (txtUsuario.Text.Contains(" "))// Verifica se o texto digitado tem espaços em branco
            {
                lblUsuarioAviso.Text = "Não pode haver espaços";
                lblUsuarioAviso.ForeColor = Color.Red;
                btnCadastrar.Enabled = false;
            }
            else if (functions.VerificarNomeUsuario(txtUsuario.Text.Trim())) // Verifica se o nome de usuario já existe
            {
                lblUsuarioAviso.Text = "Este nome de usuário já existe";
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtConfirmarSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
