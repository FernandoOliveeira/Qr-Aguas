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
            // Atualiza o ComboBoxCategoria
            this.categoriasTableAdapter.Fill(this.qraguasDataSet.categorias);
            
            // Atualiza o ComboBoxFornecedor
            this.fornecedoresTableAdapter.Fill(this.qraguasDataSet.fornecedores);



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

        private void CBCategoria_Click(object sender, EventArgs e)
        {
            // Atualiza o ComboBoxCategoria
            this.categoriasTableAdapter.Fill(this.qraguasDataSet.categorias);
           
        }

        private void CBFornecedor_Click(object sender, EventArgs e)
        {
            // Atualiza o ComboBoxFornecedor
            this.fornecedoresTableAdapter.Fill(this.qraguasDataSet.fornecedores);

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
                try
                {
                    if (functions.CadastrarNovoProduto(objProduto))
                    {
                        MessageBox.Show("Produto Cadastrado com sucesso !", "Cadastrado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimparCampos();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar o produto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao cadastrar o produto \nErro: " + erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Um ou mais campos obrigatórios* estão vazios", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void LimparCampos()
        {
            txtCodProduto.Text = "";
            txtNome.Text = "";
            txtPrecoCompra.Text = "";
            txtDescricao.Text = "";
            txtPrecoVenda.Text = "";
        }
    }
}
