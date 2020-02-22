using MySql.Data.MySqlClient;
using QrAguas.BusinessLayer;
using QrAguas.Models;
using QrAguas.View_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QrAguas.Controls
{
    class Functions : BlDataVerification
    {
        #region Gerar Hash MD5


        public string GerarMd5(string senha)
        {
            MD5 md5Hash = MD5.Create();

            // Criptografa a senha passada como parâmetro
            byte[] senhaCriptografada = md5Hash.ComputeHash(Encoding.Default.GetBytes(senha));

            // Cria um StringBuilder para passarmos os bytes gerados
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < senhaCriptografada.Length; i++)
            {
                stringBuilder.Append(senhaCriptografada[i].ToString("x2"));
            }

            // Retorna o valor criptografado como string
            return stringBuilder.ToString();
        }

        #endregion


        #region Form Login

        public int VerificarTipoUsuario(string usuario)
        {
            DataTable consultarTipoUsuario = new DataTable();

            string queryTipoUsuario = "SELECT ID_TIPO_USUARIO FROM USUARIOS WHERE NOME_USUARIO = @USUARIO";

            MySqlCommand command = new MySqlCommand(queryTipoUsuario, AbrirBanco());
            command.Parameters.AddWithValue("@USUARIO", usuario);
            MySqlDataReader reader = command.ExecuteReader();

            consultarTipoUsuario.Load(reader);

            int tipoUsuario = 0;

            foreach(DataRow row in consultarTipoUsuario.Rows)
            {
                tipoUsuario = int.Parse(row["ID_TIPO_USUARIO"].ToString());

            }

            FecharBanco(AbrirBanco());

            return tipoUsuario;
        }

        public bool VerificarLogin(string usuario, string senha)
        {
            DataTable consultarLogin = new DataTable();

            string queryUsuarioSenha = "SELECT NOME_USUARIO, SENHA FROM USUARIOS WHERE NOME_USUARIO = @USUARIO";

            MySqlCommand command = new MySqlCommand(queryUsuarioSenha, AbrirBanco());
            command.Parameters.AddWithValue("@USUARIO", usuario);
            MySqlDataReader reader = command.ExecuteReader();

            consultarLogin.Load(reader);

            string usuarioBanco = "";
            string senhaBanco = "";

            foreach (DataRow row in consultarLogin.Rows)
            {
                usuarioBanco = row["NOME_USUARIO"].ToString();
                senhaBanco = row["SENHA"].ToString();

                if (usuarioBanco.Equals(usuario) && senhaBanco.Equals(senha))
                {
                    FecharBanco(AbrirBanco());
                    return true;
                }
            }

            FecharBanco(AbrirBanco());

            return false;
        }

        #endregion


        #region Form RegisterUser


        public bool VerificarNomeUsuario(string nomeUsuario)
        {
            DataTable consultarNomeUsuario = new DataTable();

            string queryNomeUsuario = "SELECT NOME_USUARIO FROM USUARIOS WHERE NOME_USUARIO = '" + nomeUsuario + "'";

            MySqlCommand command = new MySqlCommand(queryNomeUsuario, AbrirBanco());
            MySqlDataReader reader = command.ExecuteReader();

            consultarNomeUsuario.Load(reader);

            string usuarioBanco = ".";

            foreach (DataRow row in consultarNomeUsuario.Rows)
            {
                usuarioBanco = row["NOME_USUARIO"].ToString();
            }

            if (usuarioBanco == nomeUsuario)
            {
                FecharBanco(AbrirBanco());
                return true;
            }

            FecharBanco(AbrirBanco());
            return false;

        }

        public bool CadastrarNovoUsuario(NewUser objNovoUsuario)
        {
            string queryCadastrarUsuario = "INSERT INTO USUARIOS (NOME_USUARIO, SENHA, ID_TIPO_USUARIO, CADASTRADO_POR, DATA_CADASTRO) VALUES ( @NOME_USUARIO, @SENHA, @ID_TIPO_USUARIO, @CADASTRADO_POR, @DATA_CADASTRO)";

            MySqlCommand command = new MySqlCommand(queryCadastrarUsuario, AbrirBanco());

            command.Parameters.AddWithValue("@NOME_USUARIO", objNovoUsuario.NomeUsuario);
            command.Parameters.AddWithValue("@SENHA", objNovoUsuario.Senha);
            command.Parameters.AddWithValue("@ID_TIPO_USUARIO", objNovoUsuario.IdTipoUsuario);
            command.Parameters.AddWithValue("@CADASTRADO_POR", objNovoUsuario.CadastradoPor);
            command.Parameters.AddWithValue("@DATA_CADASTRO", DateTime.Now);

            int rowCount = command.ExecuteNonQuery();

            return rowCount != 0 ? true : false;
        }

        #endregion


        #region Form ChangePassword


        public bool AlterarSenha(string senha, string nomeUsuario)
        {
            string queryAlterarSenha = "UPDATE USUARIOS SET SENHA = @Senha WHERE NOME_USUARIO = @NomeUsuario";

            MySqlCommand command = new MySqlCommand(queryAlterarSenha, AbrirBanco());

            command.Parameters.AddWithValue("@Senha", senha);
            command.Parameters.AddWithValue("@NomeUsuario", nomeUsuario);

            int rowCount = command.ExecuteNonQuery();

            if (rowCount != 0)
            {
                string querySenhaAlterada = "UPDATE USUARIOS SET DATA_SENHA_ALTERADA  = @DataAtual WHERE NOME_USUARIO = @NomeUsuario";

                MySqlCommand commandSenhaAlterada = new MySqlCommand(querySenhaAlterada, AbrirBanco());

                commandSenhaAlterada.Parameters.AddWithValue("@DataAtual", DateTime.Now);
                commandSenhaAlterada.Parameters.AddWithValue("@NomeUsuario", nomeUsuario);
                commandSenhaAlterada.ExecuteNonQuery();

                return true;
            }

            return false;
        }

        #endregion


        #region Form RegisterProviders

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
            command.Parameters.AddWithValue("@UF", objFornecedor.Uf);
            command.Parameters.AddWithValue("@TELEFONE", objFornecedor.Telefone);
            command.Parameters.AddWithValue("@CELULAR", objFornecedor.Celular);
            command.Parameters.AddWithValue("@CEP", objFornecedor.Cep);
            command.Parameters.AddWithValue("@EMAIL", objFornecedor.Email);
            command.Parameters.AddWithValue("@ID_USUARIOS", Login.TipoUsuario);

            int rowCount = command.ExecuteNonQuery();

            return rowCount != 0 ? true : false;
        }

        #endregion


    }
}
