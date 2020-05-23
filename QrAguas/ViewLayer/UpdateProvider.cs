using QrAguas.Controls;
using QrAguas.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QrAguas.ViewLayer
{
    public partial class UpdateProvider : Form
    {
        public UpdateProvider()
        {
            InitializeComponent();
        }

        public int IdFornecedor { private get; set; }
        public string RazaoSocial { get; internal set; }
        public string Cnpj { get; internal set; }
        public string Endereco { get; internal set; }
        public int Numero { get; internal set; }
        public string Bairro { get; internal set; }
        public string Cidade { get; internal set; }
        public string Complemento { get; internal set; }
        public string Uf { get; internal set; }
        public string Telefone { get; internal set; }
        public string Celular { get; internal set; }
        public string Cep { get; internal set; }
        public string Email { get; internal set; }


        NewProvider AtualizarFornecedor;

        UpdateProviderMethods updateProviderMethods = new UpdateProviderMethods();

        private void UpdateProvider_Load(object sender, EventArgs e)
        {
            txtBairro.Text = Bairro;
            txtCelular.Text = Celular;
            txtCep.Text = Cep;
            txtCidade.Text = Cidade;
            txtCnpj.Text = Cnpj;
            txtComplemento.Text = Complemento;
            txtEmail.Text = Email;
            txtEndereco.Text = Endereco;
            txtNumero.Text = Numero.ToString();
            txtRazaoSocial.Text = RazaoSocial;
            txtTelefone.Text = Telefone;
            txtUf.Text = Uf;
        }

        private async void BtnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                await ConsultarCep(txtCep.Text.Replace("-", ""));
            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao realizar a consulta. \nVerifique se o CEP foi digitado corretamente.", "Erro na consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public async Task ConsultarCep(string cep)
        {
            try
            {
                ICepApiService cepClient = RestService.For<ICepApiService>("https://viacep.com.br/");

                CepResponse endereco = await cepClient.CepResposta(cep);

                txtBairro.Text = endereco.Bairro;
                txtCidade.Text = endereco.Cidade;
                txtComplemento.Text = endereco.Complemento;
                txtEndereco.Text = endereco.Logradouro;
                txtUf.Text = endereco.Uf;
            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao realizar a consulta. \nVerifique a sua conexão com a internet.", "Erro na consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite somente números no textBox
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Permite somente um ponto 
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TxtNumero_TextChanged(object sender, EventArgs e)
        {
            // Caso o textBox que recebe o número do local, não esteja preenchido, 
            // o mesmo recebe o valor null, para que não haja erro de 
            // exceções na hora da verificação
            if (txtNumero.Text.Equals(""))
            {
                txtNumero.Text = null;
            }
        }

        private void TxtUf_TextChanged(object sender, EventArgs e)
        {
            // Faz com que o campo UF receba somente letras
            if (!Regex.IsMatch(txtUf.Text, "^[a-zA-Z]"))
            {
                txtUf.Text = null;
            }
        }

        private void ConsultarCep_KeyDown(object sender, KeyEventArgs e)
        {
            ActiveForm.AcceptButton = btnConsultar;
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text == "")
            {
                txtNumero.Text = "0";
            }

            try
            {
                AtualizarFornecedor = new NewProvider
                {
                    Bairro = txtBairro.Text.Trim(),
                    Celular = txtCelular.Text.Trim(),
                    Cep = txtCep.Text.Trim(),
                    Cidade = txtCidade.Text.Trim(),
                    Cnpj = txtCnpj.Text.Trim(),
                    Complemento = txtComplemento.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Endereco = txtEndereco.Text.Trim(),
                    Numero = int.Parse(txtNumero.Text.Trim()),
                    RazaoSocial = txtRazaoSocial.Text.Trim(),
                    Telefone = txtTelefone.Text.Trim(),
                    Uf = txtUf.Text.Trim()
                };

                // Verifica se os campos obrigatórios foram preenchidos corretamente
                if (updateProviderMethods.VerificarDadosFornecedores(AtualizarFornecedor))
                {
                    // Validação de CNPJ
                    if (updateProviderMethods.ValidarCnpj(txtCnpj.Text))
                    {
                        // Caso o campo email não esteja vazio
                        if (txtEmail.Text.Trim().Length != 0)
                        {
                            // Validação do E-mail
                            if (updateProviderMethods.ValidarEmail(txtEmail.Text.Trim()))
                            {
                                // Cadastrar fornecedor
                                if (updateProviderMethods.AtualizarFornecedor(AtualizarFornecedor, IdFornecedor))
                                {
                                    MessageBox.Show("Fornecedor atualizado com sucesso !", "Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    SearchProvider.FornecedorAtualizado = true;
                                    Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("E-mail inválido.", "E-mail inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            // Cadastrar fornecedor
                            if (updateProviderMethods.AtualizarFornecedor(AtualizarFornecedor, IdFornecedor))
                            {
                                MessageBox.Show("Fornecedor atualizado com sucesso !", "Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                SearchProvider.FornecedorAtualizado = true;
                                Close();
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("CNPJ inválido.", "CNPJ inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Um ou mais campos obrigatórios* estão vazios ou incompletos.", "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao atualizar \nErro: " + error, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            
        }

    }
}
