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

        Functions functions = new Functions();

        Cart cart = new Cart();

        private void SellProduct_Load(object sender, EventArgs e)
        {
            // Inicia o carrinho de compras com os títulos das colunas e o valor total da compra em 0

            DGVCarrinho.DataSource = cart.Produtos;

            DGVCarrinho.Columns[0].HeaderText = "Código do Produto";
            DGVCarrinho.Columns[3].HeaderText = "Valor Unitário";
            DGVCarrinho.Columns[3].DefaultCellStyle.Format = "0.00##";

            lblTotal.Text = "Total: " + cart.Total().ToString("F2") + "R$";

        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            
            Product produto = functions.ProcurarProduto(int.Parse(txtCodProduto.Text.Trim()));

            OrderProduct order = new OrderProduct(
                produto.CodigoProduto,
                produto,
                (int)txtQuantidade.Value,
                produto.Preco

                );
            
            // Adiciona o novo produto ao carrinho
            cart.AddProduto(order);

            lblTotal.Text = "Total: " + cart.Total().ToString("F2") + "R$";
        }
    }
}
