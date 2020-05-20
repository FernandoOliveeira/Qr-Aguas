using MySql.Data.MySqlClient;
using QrAguas.BusinessLayer;
using QrAguas.Models;
using QrAguas.View_Layer;
using System;
using System.Net.Mail;

namespace QrAguas.Controls
{
    class RegisterProvidersMethods : BlDataVerification
    {
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

        public bool CadastrarNovoFornecedor(NewProvider objFornecedor)
        {
            string queryCadastrarFonecedor = "INSERT INTO FORNECEDORES (RAZAO_SOCIAL, CNPJ, ENDERECO, NUMERO, BAIRRO, CIDADE, COMPLEMENTO, UF, TELEFONE, CELULAR, CEP, EMAIL, ID_USUARIOS) VALUES (@RAZAO_SOCIAL, @CNPJ, @ENDERECO, @NUMERO, @BAIRRO, @CIDADE, @COMPLEMENTO, @UF, @TELEFONE, @CELULAR, @CEP, @EMAIL, @ID_USUARIOS)";

            MySqlCommand command = new MySqlCommand(queryCadastrarFonecedor, AbrirBanco());

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
            command.Parameters.AddWithValue("@ID_USUARIOS", Login.IdUsuario);

            int rowCount = command.ExecuteNonQuery();

            FecharBanco(AbrirBanco());

            return rowCount != 0 ? true : false;
        }

    }
}
