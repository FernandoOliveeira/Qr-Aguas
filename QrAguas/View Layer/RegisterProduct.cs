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

namespace QrAguas.View_Layer
{
    public partial class RegisterProduct : Form
    {
        public RegisterProduct()
        {
            InitializeComponent();
        }

        Functions functions = new Functions();

        private void RegisterProduct_Load(object sender, EventArgs e)
        {
            // Atualiza o DropDownListFornecedores com a lista de Fornecedores
            this.fornecedoresTableAdapter.Fill(this._0ybkkaeekeDataSetRegisterProductFornecedores.fornecedores);
           
            // Atualiza o DropDownListCategorias com a lista de Categorias
            this.categoriasTableAdapter.Fill(this._0ybkkaeekeDataSetRegisterProductCategorias.categorias);


            txtPrecoCompra.Text = "0";
            txtPrecoVenda.Text = "0";

            DTPFabricacao.MaxDate = DateTime.Now;
            DTPValidade.MinDate = DateTime.Now;

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

        private void TxtCategoria_Click(object sender, EventArgs e)
        {
            // Atualiza o DropDownListCategorias com a lista de Categorias
            this.categoriasTableAdapter.Fill(this._0ybkkaeekeDataSetRegisterProductCategorias.categorias);
        }

        private void TxtFornecedor_Click(object sender, EventArgs e)
        {
            // Atualiza o DropDownListFornecedores com a lista de Fornecedores
            this.fornecedoresTableAdapter.Fill(this._0ybkkaeekeDataSetRegisterProductFornecedores.fornecedores);
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
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

            NewProduct objProduto = new NewProduct
            {
                CodigoProduto = txtCodProduto.Text.Trim(),
                NomeProduto = txtNome.Text.Trim(),
                PrecoCompra = double.Parse(txtPrecoCompra.Text.Trim()),
                Fornecedor = (int) CBFornecedor.SelectedValue,
                Descricao = txtDescricao.Text.Trim(),
                PrecoVenda = double.Parse(txtPrecoVenda.Text.Trim()),
                Categoria = (int) CBCategoria.SelectedValue,
                DataFabricao = DTPFabricacao.Value,
                DataValidade = DTPValidade.Value

            };

            if (functions.VerificarDadosProdutos(objProduto))
            {
                MessageBox.Show("Valor do Fornecedor: " + objProduto.Fornecedor + "\nValor da Categoria: " + objProduto.Categoria);
            }
            else
            {
                MessageBox.Show("Alguns campos estão vazios");
            }

        }


    }
}
