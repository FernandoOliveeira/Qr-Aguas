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

        // Propriedade utilizada como flag
        // Caso o form UpdateCategory realize a atualização de alguma categoria, esta propriedade recebe o valor de true
        public static bool UpdateCategoryResultado { private get; set; }

        Functions functions = new Functions();

        private void RegisterCategory_Load(object sender, EventArgs e)
        {
            
            // Atualiza e insere dados no DataGridView
            this.categoriasTableAdapter.Fill(this.qraguasDataSet.categorias);
            
            // Flag recebe valor false na inicialização do form
            UpdateCategoryResultado = false;

            

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // "Evento de click" no botão Excluir no DataGridView
            if (DGVCategorias.Columns[e.ColumnIndex].Name.Equals("Excluir"))
            {
                int idCategoria = (int) DGVCategorias.SelectedRows[0].Cells[0].Value;
                string nomeCategoria = DGVCategorias.SelectedRows[0].Cells[1].Value.ToString();

                DialogResult resposta = MessageBox.Show("Deseja excluir a categoria '" + nomeCategoria + "' ?", "Excluir Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (resposta.Equals(DialogResult.Yes))
                {
                    try
                    {
                        functions.DeletarCategoria(idCategoria);

                        MessageBox.Show("Categoria excluída com sucesso.", "Excluído com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Atualiza e insere dados no DataGridView
                        this.categoriasTableAdapter.Fill(this.qraguasDataSet.categorias);
                        UpdateCategoryResultado = false;

                    }
                    catch (Exception erro)
                    {

                        MessageBox.Show("Erro ao excluir a categoria.\nErro: " + erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }

            // "Evento de click" no botão Atualizar no DataGridView
            if (DGVCategorias.Columns[e.ColumnIndex].Name.Equals("Atualizar"))
            {
                int idCategoria = (int)DGVCategorias.SelectedRows[0].Cells[0].Value;
                string nomeCategoria = DGVCategorias.SelectedRows[0].Cells[1].Value.ToString();

                DialogResult resposta = MessageBox.Show("Deseja atualizar a categoria '" + nomeCategoria + "' ?", "Atualizar Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (resposta.Equals(DialogResult.Yes))
                {
                    UpdateCategory updateCategory = new UpdateCategory
                    {
                        IdCategoria = idCategoria,
                        Categoria = nomeCategoria
                    };

                    updateCategory.ShowDialog();

                    if (UpdateCategoryResultado.Equals(true))
                    {
                        UpdateCategoryResultado = false;

                        // Atualiza e insere dados no DataGridView
                        this.categoriasTableAdapter.Fill(this.qraguasDataSet.categorias);
                        UpdateCategoryResultado = false;
                    }
                }
                
            }
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            if (CamposVazios())
            {
                MessageBox.Show("O campo 'Categoria' está vazio", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (functions.CadastrarNovaCategoria(txtNovaCategoria.Text.Trim()))
                    {
                        MessageBox.Show("Nova Categoria cadastrada com sucesso", "Cadastrado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Atualiza e insere dados no DataGridView
                        this.categoriasTableAdapter.Fill(this.qraguasDataSet.categorias);
                        UpdateCategoryResultado = false;

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
