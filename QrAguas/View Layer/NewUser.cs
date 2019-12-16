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

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            bool temEspacos = txtUsuario.Text.Contains(" ");

            if (txtUsuario.Text.Length == 15) 
            {
                // Caso seja digitado o máximo de 15 caracteres o texto de aviso se torna vermelho
                lblUsuarioComentario.ForeColor = Color.Red;
            }
            else
            {
                lblUsuarioComentario.ForeColor = Color.White;
            }

            if (temEspacos) // Verifica se o texto digitado tem espaços em branco
            {
                lblUsuarioComentario.Text = "Não pode haver espaços";
                lblUsuarioComentario.ForeColor = Color.Red;
            }
            else
            {
                lblUsuarioComentario.Text = "Máx: 15 Caracteres";
                lblUsuarioComentario.ForeColor = Color.White;
            }
        }

        private void CadastrarNovoUsuario_Load(object sender, EventArgs e)
        {
            // Preenche a DropDownList com as funções cadastradas no banco de dados
            // TODO: This line of code loads data into the 'qraguasDataSet1.tipo_usuario' table. You can move, or remove it, as needed.
            this.tipo_usuarioTableAdapter1.Fill(this.qraguasDataSet1.tipo_usuario);

        }
    }
}
