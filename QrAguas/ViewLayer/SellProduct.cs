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

        private void SellProduct_Load(object sender, EventArgs e)
        {
            Cart cart = new Cart(DateTime.Now);
            Product produto = new Product(
                "Gás 30g",
                23.55

                );

            OrderProduct order = new OrderProduct(
                5,
                produto.Preco,
                produto
                );

            cart.AddProduto(order);


            DGVCarrinho.DataSource = cart.Produtos;

            DGVCarrinho.Columns[2].HeaderText = "Preço";

        }
    }
}
