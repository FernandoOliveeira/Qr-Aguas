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

        RegisterCategoryMethods RegisterCategoryMethods = new RegisterCategoryMethods();

        private void RegisterCategory_Load(object sender, EventArgs e)
        {
            
            // Atualiza e insere dados no DataGridView
            this.cATEGORIASTableAdapter.Fill(this.qrAguasRemoteDBDataSet.CATEGORIAS);
            
            // Flag recebe valor false na inicialização do form
            UpdateCategoryResultado = false;

            // Define o tamanho minimo do form
            this.MinimumSize = new Size(600, 401);
            

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // "Evento de click" no botão Atualizar no DataGridView
            if (DGVCategorias.Columns[e.ColumnIndex].Name.Equals("Atualizar"))
            {
                // Quando clicado no botão Atualizar do DataGridView os dados de toda a linha são atribuídos em variáveis
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

                    if (UpdateCategoryResultado == true)
                    {
                        UpdateCategoryResultado = false;

                        // Atualiza e insere dados no DataGridView
                        this.cATEGORIASTableAdapter.Fill(this.qrAguasRemoteDBDataSet.CATEGORIAS);
                        UpdateCategoryResultado = false;
                    }
                }
                
            }

            // "Evento de click" no checkbox Ativo no DataGridView
            if (DGVCategorias.Columns[e.ColumnIndex].HeaderText.Equals("Ativo"))
            {
                // Quando clicado no checkbox do DataGridView os dados de toda a linha são atribuídos em variáveis
                int idCategoria = (int)DGVCategorias.SelectedRows[0].Cells[0].Value;
                string nomeCategoria = DGVCategorias.SelectedRows[0].Cells[1].Value.ToString();

                // Recebe o valor booleano da coluna ATIVO
                bool ativo = DGVCategorias.SelectedRows[0].Cells[2].Value.Equals(true) ? false : true;

                // Caso o usuário esteja ativo a string recebe DESATIVAR e vice e versa
                string ativarDesativar = ativo == false ? "DESATIVAR" : "ATIVAR";

                
                DialogResult resposta = MessageBox.Show("Deseja " + ativarDesativar + " a categoria '" + nomeCategoria + "' ? \n(Categorias desativadas não aparecem no cadastro de produtos)", ativarDesativar + " Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (resposta == DialogResult.Yes)
                {
                    string ativarDesativarResposta = ativarDesativar == "DESATIVAR" ? "Desativada" : "Ativada";

                    try
                    {
                        if (RegisterCategoryMethods.AtivarDesativarCategoria(idCategoria, ativo))
                        {

                            MessageBox.Show("Categoria " + ativarDesativarResposta + " com sucesso.", ativarDesativarResposta + " com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Atualiza e insere dados no DataGridView
                            this.cATEGORIASTableAdapter.Fill(this.qrAguasRemoteDBDataSet.CATEGORIAS);

                        }
                        else
                        {
                            MessageBox.Show("Erro ao " + ativarDesativarResposta + " a categoria.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    catch (Exception erro)
                    {

                        MessageBox.Show("Erro ao realizar esta operação.\nErro: " + erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    if (RegisterCategoryMethods.CadastrarNovaCategoria(txtNovaCategoria.Text.Trim()))
                    {
                        MessageBox.Show("Nova Categoria cadastrada com sucesso", "Cadastrado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Atualiza e insere dados no DataGridView
                        this.cATEGORIASTableAdapter.Fill(this.qrAguasRemoteDBDataSet.CATEGORIAS);
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
            return txtNovaCategoria.Text.Trim() == "" ? true : false;

        }

       
    }
}
