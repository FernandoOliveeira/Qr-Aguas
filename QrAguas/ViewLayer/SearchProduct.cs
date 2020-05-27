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
    public partial class SearchProduct : Form
    {
        public SearchProduct()
        {
            InitializeComponent();
        }

        SearchProductMethods searchProductMethods = new SearchProductMethods();


        private void SearchProduct_Load(object sender, EventArgs e)
        {
            // Tamanho minimo do form
            this.MinimumSize = new Size(1050, 500);

            // Insere os dados no DGVProdutos
            this.searchProductDGVProdutosTableAdapter.Fill(this.qrAguasRemoteDBDataSet.SearchProductDGVProdutos);
        }

        private void BtnProcurar_Click(object sender, EventArgs e)
        {
            // Realiza a busca e exibe os produtos no DataGrigView com base no que foi digitado pelo usuário
            this.searchProductDGVProdutosTableAdapter.FillByNomeProduto(this.qrAguasRemoteDBDataSet.SearchProductDGVProdutos, "%" + txtFornecedor.Text.Trim() + "%");
        }

        private void DGVFornecedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idProduto = int.Parse(DGVFornecedores.SelectedRows[0].Cells[0].Value.ToString());

            string nomeProduto = DGVFornecedores.SelectedRows[0].Cells[2].Value.ToString();

            switch (DGVFornecedores.Columns[e.ColumnIndex].HeaderText)
            {
                #region Excluir
                case "Excluir":

                    DialogResult respostaExcluir = MessageBox.Show("Deseja mesmo excluir o produto " + nomeProduto.ToUpper() + " ?", "Excluir Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                    if (respostaExcluir == DialogResult.Yes)
                    {
                        try
                        {
                            if (searchProductMethods.ExcluirProduto(idProduto))
                            {
                                // Atualiza os dados no DGVProdutos
                                this.searchProductDGVProdutosTableAdapter.Fill(this.qrAguasRemoteDBDataSet.SearchProductDGVProdutos);

                                MessageBox.Show("Produto excluído com sucesso !", "Produto Excluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception error)
                        {

                            MessageBox.Show("Erro ao excluir. \nErro: " + error, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    break;
                #endregion

                case "Atualizar":

                    DialogResult respostaAtualizar = MessageBox.Show("Deseja mesmo atualizar o produto " + nomeProduto.ToUpper() + " ?", "Atualizar Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);




                    break;
            }
        }

        private void TxtFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            ActiveForm.AcceptButton = btnProcurar;
        }
    }
}
