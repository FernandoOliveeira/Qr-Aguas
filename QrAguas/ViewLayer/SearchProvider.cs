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
    public partial class SearchProvider : Form
    {
        public SearchProvider()
        {
            InitializeComponent();
        }

        SearchProviderMethods ProviderMethods = new SearchProviderMethods();

        private void SearchProvider_Load(object sender, EventArgs e)
        {
            // Define o tamanho minimo do form
            this.MinimumSize = new Size(1050, 500);

            // Atualiza os dados no DGVFornecedores
            this.fORNECEDORESTableAdapter.FillByDeletadoFalse(this.qrAguasRemoteDBDataSet.FORNECEDORES);
        }

        private void BtnProcurar_Click(object sender, EventArgs e)
        {
            // Realiza a busca dos fornecedores e insere o resultado no DataGridView
            DGVFornecedores.DataSource = ProviderMethods.ProcurarFornecedor(txtFornecedor.Text.Trim());
        }

        private void TxtFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            ActiveForm.AcceptButton = btnProcurar;
        }

        private void DGVFornecedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int idFornecedor = (int)DGVFornecedores.SelectedRows[0].Cells[0].Value;
            string nomeFornecedor = DGVFornecedores.SelectedRows[0].Cells[1].Value.ToString();


            switch (DGVFornecedores.Columns[e.ColumnIndex].HeaderText)
            {
                case "Excluir":

                    DialogResult respostaExcluir = MessageBox.Show("Deseja excluir o fornecedor " + nomeFornecedor.ToUpper() + " ?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                    break;


                case "Editar":

                    DialogResult respostaEditar = MessageBox.Show("Deseja editar as informações do fornecedor " + nomeFornecedor.ToUpper() + " ?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    break;

            }

        }
    }
}
