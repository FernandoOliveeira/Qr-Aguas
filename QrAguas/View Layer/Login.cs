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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        #region código para tornar o form "arrastavel" 
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        VerifyLogin objLogin = new VerifyLogin();

        private void Login_Load(object sender, EventArgs e)
        {
            
        }


        public void ArrastarTela_MouseDown(object sender, MouseEventArgs e)
        {
            #region código para tornar o form "arrastavel"
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
            #endregion
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
            if (objLogin.VerificarLogin(txtUsuario.Text, txtSenha.Text))
            {
                MessageBox.Show("Login Efetuado com Sucesso !!!", "Login efetuado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Usuario ou senha inválidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        #region BotaoFechar
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFechar_MouseEnter(object sender, EventArgs e)
        {
            btnFechar.BackColor = Color.FromArgb(255, 82, 82);
        }

        private void btnFechar_MouseLeave(object sender, EventArgs e)
        {
            btnFechar.BackColor = Color.FromArgb(29, 52, 97);
        }
        #endregion
        
    }
}
