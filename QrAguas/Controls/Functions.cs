using MySql.Data.MySqlClient;
using QrAguas.BusinessLayer;
using QrAguas.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QrAguas.Controls
{
    class Functions : BlNewUser
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


        public bool VerificarLogin(string usuario, string senha)
        {
            DataTable consultarLogin = new DataTable();

            string queryUsuarioSenha = "SELECT NOME_USUARIO, SENHA, ID_TIPO_USUARIO FROM USUARIOS";

            MySqlCommand command = new MySqlCommand(queryUsuarioSenha, AbrirBanco());
            MySqlDataReader reader = command.ExecuteReader();

            consultarLogin.Load(reader);

            string usuarioBanco = "";
            string senhaBanco = "";

            foreach (DataRow row in consultarLogin.Rows)
            {
                usuarioBanco = row["NOME_USUARIO"].ToString();
                senhaBanco = row["SENHA"].ToString();

                if (usuarioBanco == usuario && senhaBanco == senha)
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

    }
}
