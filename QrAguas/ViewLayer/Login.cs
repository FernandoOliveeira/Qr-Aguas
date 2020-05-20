﻿using QrAguas.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Security.Cryptography;

namespace QrAguas.View_Layer
{
    public partial class Login : Form
    {
        Thread thread;

        public Login()
        {
            InitializeComponent();
        }
        
        public static string NomeUsuario { get; private set; }
        public static int  TipoUsuario { get; private set; }
        public static int IdUsuario { get; private set; }

        #region código para tornar o form "arrastavel" 
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        LoginMethods LoginMethods = new LoginMethods();


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

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            // Gera um HashMd5 e armazena na variavel senha
            string senha = LoginMethods.GerarMd5(txtSenha.Text.Trim());

            if (LoginMethods.VerificarLogin(txtUsuario.Text.Trim(), senha))
            {
                
                NomeUsuario = txtUsuario.Text.Trim();
                TipoUsuario = LoginMethods.VerificarTipoUsuario(NomeUsuario);
                IdUsuario = LoginMethods.VerificarIdUsuario(NomeUsuario);

                // Abrir o form MainForm e fechar o atual
                this.Close();
                thread = new Thread(AbrirMainForm);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
              }
            else
            {
                MessageBox.Show("Usuario ou senha inválidos", "Usuario ou senha inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void AbrirMainForm() 
        {
            Application.Run(new MainForm());
        }

        private void PressionarEnter_KeyDown(object sender, KeyEventArgs e)
        {
            ActiveForm.AcceptButton = btnEntrar;

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
