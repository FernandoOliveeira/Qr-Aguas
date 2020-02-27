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

namespace QrAguas.View_Layer
{
    public partial class RegisterCategory : Form
    {
        public RegisterCategory()
        {
            InitializeComponent();
        }

        Functions functions = new Functions();

        private void RegisterCategory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_0ybkkaeekeDataSet.categorias' table. You can move, or remove it, as needed.
            this.categoriasTableAdapter.Fill(this._0ybkkaeekeDataSet.categorias);
            dataGridView1.DataSource = functions.ConsultarCategorias();

        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            if (CamposVazios())
            {
                MessageBox.Show("O campo 'Categoria' está vazio", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (functions.CadastrarNovaCategoria(txtNovaCategoria.Text.Trim()))
                    {
                        MessageBox.Show("Nova Categoria cadastrada com sucesso", "Cadastrado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dataGridView1.DataSource = functions.ConsultarCategorias();

                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar nova categoria", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception error)
                {

                    MessageBox.Show("Erro ao cadastrar nova categoria \nErro: " + error, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private bool CamposVazios()
        {
            return txtNovaCategoria.Text.Trim().Equals("") ? true : false;

        }
    }
}
