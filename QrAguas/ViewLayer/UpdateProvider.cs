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


        NewProvider AtualizarFornecedor = new NewProvider();


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
    }
}
