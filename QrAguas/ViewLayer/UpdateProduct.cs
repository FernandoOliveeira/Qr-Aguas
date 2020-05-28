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
    }
}
