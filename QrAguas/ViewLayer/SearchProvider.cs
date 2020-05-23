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

namespace QrAguas.ViewLayer
{
    public partial class SearchProvider : Form
    {
        public SearchProvider()
        {
            InitializeComponent();
        }

        public bool FornecedorAtualizado { private get; set; }

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
                #region Botão Excluir 
                case "Excluir":

                    DialogResult respostaExcluir = MessageBox.Show("Deseja excluir o fornecedor " + nomeFornecedor.ToUpper() + " ?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                    if (respostaExcluir == DialogResult.Yes)
                    {
                        try
                        {
                            if (ProviderMethods.ExcluirFornecedor(idFornecedor))
                            {
                                // Atualiza os dados no DGVFornecedores
                                this.fORNECEDORESTableAdapter.FillByDeletadoFalse(this.qrAguasRemoteDBDataSet.FORNECEDORES);

                                MessageBox.Show("Fornecedor excluído com sucesso !", "Excluído com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                
                            }
                        }
                        catch (Exception error)
                        {

                            MessageBox.Show("Erro ao tentar excluir. \nErro: " + error, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }

                    break;
                #endregion

                #region Botão Editar
                case "Editar":

                    DialogResult respostaEditar = MessageBox.Show("Deseja editar as informações do fornecedor " + nomeFornecedor.ToUpper() + " ?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (respostaEditar == DialogResult.Yes)
                    {
                        UpdateProvider updateProvider = new UpdateProvider
                        {
                            IdFornecedor = idFornecedor,
                            RazaoSocial = nomeFornecedor,
                            Cnpj = DGVFornecedores.SelectedRows[0].Cells[2].Value.ToString(),
                            Endereco = DGVFornecedores.SelectedRows[0].Cells[3].Value.ToString(),
                            Numero = (int)DGVFornecedores.SelectedRows[0].Cells[4].Value,
                            Bairro = DGVFornecedores.SelectedRows[0].Cells[5].Value.ToString(),
                            Cidade = DGVFornecedores.SelectedRows[0].Cells[6].Value.ToString(),
                            Complemento = DGVFornecedores.SelectedRows[0].Cells[7].Value.ToString(),
                            Uf = DGVFornecedores.SelectedRows[0].Cells[8].Value.ToString(),
                            Telefone = DGVFornecedores.SelectedRows[0].Cells[9].Value.ToString(),
                            Celular = DGVFornecedores.SelectedRows[0].Cells[10].Value.ToString(),
                            Cep = DGVFornecedores.SelectedRows[0].Cells[11].Value.ToString(),
                            Email = DGVFornecedores.SelectedRows[0].Cells[12].Value.ToString(),
                        };
                        updateProvider.ShowDialog();

                    }

                    break;
                    #endregion
            }

        }
    }
}
