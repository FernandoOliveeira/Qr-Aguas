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
    public partial class RegisterProviders : Form
    {
        public RegisterProviders()
        {
            InitializeComponent();
        }

        Functions function = new Functions();

        private async void btnConsultar_Click(object sender, EventArgs e)
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

            ICepApiService cepClient = RestService.For<ICepApiService>("https://viacep.com.br/");

            CepResponse endereco = await cepClient.CepResposta(cep);

            txtBairro.Text = endereco.Bairro;
            txtCidade.Text = endereco.Cidade;
            txtEndereco.Text = endereco.Logradouro;
            txtUf.Text = endereco.Uf;
            
        }


    }
}
