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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Exibe uma mensagem caso seja clicado no botão SAIR
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair ?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
