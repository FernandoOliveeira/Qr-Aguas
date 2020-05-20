using QrAguas.Controls;
using QrAguas.Models;
using QrAguas.Models.SellProductEntities;
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
    public partial class SellProduct : Form
    {
        public SellProduct()
        {
            InitializeComponent();
        }

        SellProductMethods ProductMethods = new SellProductMethods();

        Cart cart = new Cart();
        Product produto;
        OrderProduct order;

        private void SellProduct_Load(object sender, EventArgs e)
        {
            // Valores minimo e máximo do form
            this.MinimumSize = new Size(1050,601);

            // Inicia o carrinho de compras com os títulos das colunas 
            DGVCarrinho.DataSource = cart.Produtos;

            // Formatação dos títulos das colunas
            DGVCarrinho.Columns[0].HeaderText = "Código do Produto";
            DGVCarrinho.Columns[3].HeaderText = "Valor Unitário";
            DGVCarrinho.Columns[3].DefaultCellStyle.Format = "0.00##";

            AtualizarTotal();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {

            try
            {
                produto = ProductMethods.ProcurarProduto(int.Parse(txtCodProduto.Text.Trim()));

                if (String.IsNullOrEmpty(produto.NomeProduto))
                {
                    MessageBox.Show("Produto não encontrado. \nVerifique se o código esta correto.", "Produto não encotrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (txtQuantidade.Value > produto.QuantidadeBanco)
                {
                    MessageBox.Show("Quantidade digita inválida \nQuantidade em estoque: " + produto.QuantidadeBanco, "Quantidade inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    order = new OrderProduct(
                    produto.CodigoProduto,
                    produto,
                    (int)txtQuantidade.Value,
                    produto.Preco

                    );

                    // Adiciona o novo produto ao carrinho
                    cart.AddProduto(order);

                    txtCodProduto.Text = "";
                    txtQuantidade.Value = 1;

                    AtualizarTotal();
                }

                
            }
            catch (Exception)
            {

                MessageBox.Show("Produto não encontrado. \nVerifique se o código esta correto.", "Produto não encotrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            if (cart.Produtos.Any())
            {
                cart.HoraVenda = DateTime.Now;

                if (ProductMethods.VenderProduto(cart, order))
                {
                    MessageBox.Show("Venda realizada com sucesso !", "Venda realizada com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparCampos();
                    AtualizarTotal();
                }
            }
            else
            {
                MessageBox.Show("Não há itens na lista de compras !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {

            try
            {
                string nomeProduto = DGVCarrinho.SelectedRows[0].Cells[1].Value.ToString();

                int produto = DGVCarrinho.CurrentCell.RowIndex;

                DialogResult resposta = MessageBox.Show("Deseja remover o item: " + nomeProduto.ToUpper() + " ?", "Remover item", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (resposta == DialogResult.Yes)
                {
                    cart.RemoverProduto(produto);
                    AtualizarTotal();

                    MessageBox.Show("Produto removido com sucesso !", "Produto Removido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                }


            }
            catch (Exception )
            {

                MessageBox.Show("Nenhum item selecionado ! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning
);
            }
            
            

        }

        private void PressionarEnter_KeyDown(object sender, KeyEventArgs e)
        {
            ActiveForm.AcceptButton = btnAdicionar;

        }

        private void AtualizarTotal()
        {
            lblTotal.Text = "Total: " + cart.Total().ToString("F2") + "R$";
        }
        
        private void LimparCampos()
        {
            txtCodProduto.Text = "";
            txtQuantidade.Value = 1;

            cart.Produtos.Clear();
        }
    }
}
