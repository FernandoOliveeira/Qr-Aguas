using MySql.Data.MySqlClient;
using QrAguas.BusinessLayer;
using QrAguas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace QrAguas.Controls
{
    class UpdateProviderMethods : BlDataVerification
    {
        public bool AtualizarFornecedor(NewProvider objFornecedor, int idFornecedor)
        {
            string queryAtualizarFornecedor = "UPDATE FORNECEDORES SET RAZAO_SOCIAL = @RAZAO_SOCIAL, CNPJ = @CNPJ, ENDERECO = @ENDERECO, NUMERO = @NUMERO, BAIRRO = @BAIRRO, CIDADE = @CIDADE, COMPLEMENTO = @COMPLEMENTO, UF = @UF, TELEFONE = @TELEFONE, CELULAR = @CELULAR, CEP = @CEP, EMAIL = @EMAIL WHERE ID_FORNECEDORES = @ID_FORNECEDORES";

            MySqlCommand command = new MySqlCommand(queryAtualizarFornecedor, AbrirBanco());

            command.Parameters.AddWithValue("@RAZAO_SOCIAL", objFornecedor.RazaoSocial);
            command.Parameters.AddWithValue("@CNPJ", objFornecedor.Cnpj);
            command.Parameters.AddWithValue("@ENDERECO", objFornecedor.Endereco);
            command.Parameters.AddWithValue("@NUMERO", objFornecedor.Numero);
            command.Parameters.AddWithValue("@BAIRRO", objFornecedor.Bairro);
            command.Parameters.AddWithValue("@CIDADE", objFornecedor.Cidade);
            command.Parameters.AddWithValue("@COMPLEMENTO", objFornecedor.Complemento);
            command.Parameters.AddWithValue("@UF", objFornecedor.Uf);
            command.Parameters.AddWithValue("@TELEFONE", objFornecedor.Telefone);
            command.Parameters.AddWithValue("@CELULAR", objFornecedor.Celular);
            command.Parameters.AddWithValue("@CEP", objFornecedor.Cep);
            command.Parameters.AddWithValue("@EMAIL", objFornecedor.Email);
            command.Parameters.AddWithValue("@ID_FORNECEDORES", idFornecedor);

            int rowCount = command.ExecuteNonQuery();

            FecharBanco(AbrirBanco());

            return rowCount != 0 ? true : false; 
        }

        public bool ValidarCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            cnpj = cnpj.Trim().Replace(".", "").Replace("-", "").Replace("/", "");

            if (cnpj.Length != 14)
            {
                return false;
            }


            string tempCnpj = cnpj.Substring(0, 12);
            int soma = 0;

            for (int i = 0; i < 12; i++)
            {
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            }


            int resto = (soma % 11);

            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }


            string digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
            {
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            }

            resto = (soma % 11);

            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }


            digito = digito + resto.ToString();

            return cnpj.EndsWith(digito);
        }

        public bool ValidarEmail(string email)
        {
            try
            {
                MailAddress emailValido = new MailAddress(email);

                return emailValido.Equals(email);
            }
            catch (Exception)
            {

                return false;
            }
        }

    }
}
