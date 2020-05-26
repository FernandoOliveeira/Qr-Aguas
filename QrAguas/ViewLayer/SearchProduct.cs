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

        private void SearchProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qrAguasRemoteDBDataSet.SearchProductDGVProdutos' table. You can move, or remove it, as needed.
            this.searchProductDGVProdutosTableAdapter.Fill(this.qrAguasRemoteDBDataSet.SearchProductDGVProdutos);
        }
    }
}
