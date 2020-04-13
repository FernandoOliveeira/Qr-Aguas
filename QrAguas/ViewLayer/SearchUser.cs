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

namespace QrAguas.ViewLayer
{
    public partial class SearchUser : Form
    {
        public SearchUser()
        {
            InitializeComponent();
        }

        Functions functions = new Functions();

        private void SearchUser_Load(object sender, EventArgs e)
        {
            // Insere os dados no DGVUsuarios
            this.dataGridViewUsuariosTableAdapter.FillDGVUsuarios(this.qraguasDataSet.DataGridViewUsuarios);
            
        }

        private void BtnProcurar_Click(object sender, EventArgs e)
        {
            DGVUsuarios.DataSource = functions.ProcurarUsuario(txtUsuario.Text.Trim());
        }

        private void TxtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            ActiveForm.AcceptButton = btnProcurar;
        }
    }
}
