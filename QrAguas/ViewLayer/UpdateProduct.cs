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
    public partial class UpdateProduct : Form
    {
        public UpdateProduct()
        {
            InitializeComponent();
        }

        UpdateProductMethods updateProductMethods = new UpdateProductMethods();

        public int IdProduto { get; internal set; }
        public string NomeProduto { get; internal set; }
        public string Codigo { get; internal set; }
        public string Categoria { get; internal set; }
        public string Descricao { get; internal set; }
        public int Quantidade { get; internal set; }
        public double Preco_Compra { get; internal set; }
        public double Preco_Venda { get; internal set; }
        public string Fornecedor { get; internal set; }
        public DateTime DataValidade { get; internal set; }
        public DateTime DataFabricacao { get; internal set; }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            // Insere os dados no ComboBox CBFornecedores
            this.fORNECEDORESTableAdapter.FillByComboBoxFornecedoresUpdateProduct(this.qrAguasRemoteDBDataSet.FORNECEDORES, Fornecedor);            
            // Insere os dados no ComboBox CBCategorias
            this.cATEGORIASTableAdapter.FillByComboBoxCategoriaUpdateProduct(this.qrAguasRemoteDBDataSet.CATEGORIAS, Categoria);

            txtCodProduto.Text = Codigo;
            txtDescricao.Text = Descricao;
            txtNome.Text = NomeProduto;
            txtPrecoCompra.Text = Preco_Compra.ToString("F2");
            txtPrecoVenda.Text = Preco_Venda.ToString("F2");
            txtQuantidade.Value = Quantidade;
            DTPValidade.Value = DataValidade;
            DTPFabricacao.Value = DataFabricacao;

        }

        private void SomenteNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite somente números no textBox
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // Permite somente um ponto 
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void CBCategoria_Click(object sender, EventArgs e)
        {
            // Atualiza o ComboBoxCategoria
            this.cATEGORIASTableAdapter.FillByComboBoxCategoriaUpdateProduct(this.qrAguasRemoteDBDataSet.CATEGORIAS, Categoria);

        }

        private void CBFornecedor_Click(object sender, EventArgs e)
        {
            // Atualiza o ComboBoxFornecedor
            this.fORNECEDORESTableAdapter.FillByComboBoxFornecedoresUpdateProduct(this.qrAguasRemoteDBDataSet.FORNECEDORES, Fornecedor);

        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            // Verificação para que não seja inserido valor null no objProduto.PrecoCompra
            if (txtPrecoCompra.Text.Equals(""))
            {
                txtPrecoCompra.Text = "0";
            }

            // Verificação para que não seja inserido valor null no objProduto.PrecoVenda
            if (txtPrecoVenda.Text.Equals(""))
            {
                txtPrecoVenda.Text = "0";
            }

            NewProduct product = new NewProduct
            {
                Categoria = (int)CBCategoria.SelectedValue,
                CodigoProduto = txtCodProduto.Text.Trim(),
                DataFabricao = DTPFabricacao.Value,
                DataValidade = DTPValidade.Value,
                Descricao = txtDescricao.Text.Trim(),
                Fornecedor = (int)CBFornecedor.SelectedValue,
                NomeProduto = txtNome.Text.Trim(),
                PrecoCompra = double.Parse(txtPrecoCompra.Text.Trim()),
                PrecoVenda = double.Parse(txtPrecoVenda.Text.Trim()),
                Quantidade = (int)txtQuantidade.Value
            };

            if (updateProductMethods.VerificarDadosProdutos(product))
            {
                try
                {
                    if (updateProductMethods.AtualizarProduto(IdProduto, product))
                    {
                        MessageBox.Show("Produto atualizado com sucesso !", "Atualizado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        SearchProduct.ProdutoAtualizado = true;

                        Close();

                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao atualizar o produto. \nErro: " + erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
            }
            else
            {
                MessageBox.Show("Um ou mais campos obrigatórios* estão vazios", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
