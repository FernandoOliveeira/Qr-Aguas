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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QrAguas.View_Layer
{
    public partial class RegisterProvider : Form
    {
        public RegisterProvider()
        {
            InitializeComponent();
        }

        Functions function = new Functions();

        private void RegisterProvider_Load(object sender, EventArgs e)
        {
            txtNumero.Text = null;
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

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                NewProvider objNewProvider = new NewProvider
                {
                    RazaoSocial = txtRazaoSocial.Text.Trim(),
                    Cnpj = txtCnpj.Text,
                    Endereco = txtEndereco.Text.Trim(),
                    Numero = int.Parse(txtNumero.Text),
                    Bairro = txtBairro.Text.Trim(),
                    Cidade = txtCidade.Text.Trim(),
                    Complemento = txtComplemento.Text.Trim(),
                    Uf = txtUf.Text,
                    Telefone = txtTelefone.Text,
                    Celular = txtCelular.Text,
                    Cep = txtCep.Text,
                    Email = txtEmail.Text.Trim()

                };

                // Verifica se os campos obrigatórios foram preenchidos corretamente
                if (function.VerificarDadosFornecedores(objNewProvider))
                {
                    // Validação de CNPJ
                    if (function.ValidarCnpj(txtCnpj.Text))
                    {
                        // Caso o campo email não esteja vazio
                        if (txtEmail.Text.Trim().Length != 0)
                        {
                            // Validação do E-mail
                            if (function.ValidarEmail(txtEmail.Text.Trim()))
                            {
                                // Cadastrar fornecedor
                                if (function.CadastrarNovoFornecedor(objNewProvider))
                                {
                                    MessageBox.Show("Fornecedor cadastrado com sucesso !", "Cadastro Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            if (function.CadastrarNovoFornecedor(objNewProvider))
                            {
                                MessageBox.Show("Fornecedor cadastrado com sucesso !", "Cadastro Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                MessageBox.Show("Um ou mais campos obrigatórios* estão vazios ou incompletos \n erro: " + error, "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            



        }

        private void TxtNumero_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero.Text.Equals(""))
            {
                txtNumero.Text = null;
            }
        }

        
    }
}
