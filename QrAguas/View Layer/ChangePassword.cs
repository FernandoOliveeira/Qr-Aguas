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

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = Login.NomeUsuario; // TextBox Usuário recebe o Nome de Usuário logado no sistema

        }
        
        private void txtNovaSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtNovaSenha.Text.Equals(txtConfirmarSenha.Text))
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

        private void txtConfirmarSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmarSenha.Text.Equals(txtNovaSenha.Text))
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

        
    }
}
