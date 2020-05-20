using QrAguas.Controls;
using QrAguas.View_Layer;
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
    public partial class SearchUser : Form
    {
        public SearchUser()
        {
            InitializeComponent();
        }

        SearchUserMethods UserMethods = new SearchUserMethods();

        private void SearchUser_Load(object sender, EventArgs e)
        {
            // Insere os dados no DGVUsuarios
            this.searchUserDGVUsuariosTableAdapter.FillDGVUsuarios(this.qrAguasRemoteDBDataSet.SearchUserDGVUsuarios, Login.TipoUsuario);
            
        }

        private void BtnProcurar_Click(object sender, EventArgs e)
        {
            // Realiza a busca de usuário 
            DGVUsuarios.DataSource = UserMethods.ProcurarUsuario(txtUsuario.Text.Trim());
        }

        private void TxtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            // Faz com que a tecla Enter funcione como trigger para o btnProcurar
            ActiveForm.AcceptButton = btnProcurar;
        }

        private void DGVUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (DGVUsuarios.Columns[e.ColumnIndex].Name)
            {
                // Checkbox do DataGridView
                #region Ativo
                case "ATIVO":
                    int idUsuarioAtivo = (int)DGVUsuarios.SelectedRows[0].Cells[0].Value;
                    string nomeUsuarioAtivo = DGVUsuarios.SelectedRows[0].Cells[1].Value.ToString();

                    // Recebe o valor booleano da coluna ATIVO, porém o valor é invertido antes de ser armazenado na variável
                    bool ativo = DGVUsuarios.SelectedRows[0].Cells[5].Value.Equals(true) ? false : true;

                    string ativarDesativar = ativo == false ? "DESATIVAR" : "ATIVAR";


                    DialogResult respostaAtivo = MessageBox.Show("Deseja " + ativarDesativar + " o usuário '" + nomeUsuarioAtivo + "' ? \n(Usuários desativados não tem acesso ao sistema e não são notificados que foram desativados)", ativarDesativar + " Usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (respostaAtivo == DialogResult.Yes)
                    {
                        string ativarDesativarResposta = ativarDesativar.Equals("DESATIVAR") ? "Desativado" : "Ativado";

                        try
                        {
                            if (UserMethods.AtivarDesativarUsuario(idUsuarioAtivo, ativo))
                            {
                                MessageBox.Show("Usuário " + ativarDesativarResposta + " com sucesso.", ativarDesativarResposta + " com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Atualiza o DGVUsuarios
                                this.searchUserDGVUsuariosTableAdapter.FillDGVUsuarios(this.qrAguasRemoteDBDataSet.SearchUserDGVUsuarios, Login.TipoUsuario);

                            }
                            else
                            {
                                MessageBox.Show("Erro ao realizar esta operação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception erro)
                        {

                            MessageBox.Show("Erro ao realizar esta operação.\nErro: " + erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;

                #endregion

                // Botão Atualizar do DataGridView
                #region Atualizar
                case "Atualizar":

                    int idUsuarioAtualizar = (int)DGVUsuarios.SelectedRows[0].Cells[0].Value;
                    string nomeUsuarioAtualizar = DGVUsuarios.SelectedRows[0].Cells[1].Value.ToString();

                    DialogResult respostaAtualizar = MessageBox.Show("Deseja atualizar o nome de usuário de " + nomeUsuarioAtualizar + " ? ", "Atualizar Usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                    break;
                #endregion
            }
        }
    }
}
