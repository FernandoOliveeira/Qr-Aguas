using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QrAguas.Controls
{
    class LoginMethods : Connection
    {
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

        public int VerificarIdUsuario(string usuario)
        {
            DataTable consultarIdUsuario = new DataTable();

            string queryVerificarIdUsuario = "SELECT ID_USUARIOS FROM USUARIOS WHERE NOME_USUARIO = @NOME_USUARIO";

            MySqlCommand command = new MySqlCommand(queryVerificarIdUsuario, AbrirBanco());
            command.Parameters.AddWithValue("@NOME_USUARIO", usuario);
            MySqlDataReader reader = command.ExecuteReader();

            consultarIdUsuario.Load(reader);

            int idUsuario = 0;

            foreach (DataRow row in consultarIdUsuario.Rows)
            {
                idUsuario = int.Parse(row["ID_USUARIOS"].ToString());
            }

            FecharBanco(AbrirBanco());

            return idUsuario;
        }

        public int VerificarTipoUsuario(string usuario)
        {
            DataTable consultarTipoUsuario = new DataTable();

            string queryTipoUsuario = "SELECT ID_TIPO_USUARIO FROM USUARIOS WHERE NOME_USUARIO = @USUARIO";

            MySqlCommand command = new MySqlCommand(queryTipoUsuario, AbrirBanco());
            command.Parameters.AddWithValue("@USUARIO", usuario);
            MySqlDataReader reader = command.ExecuteReader();

            consultarTipoUsuario.Load(reader);

            int tipoUsuario = 0;

            foreach (DataRow row in consultarTipoUsuario.Rows)
            {
                tipoUsuario = int.Parse(row["ID_TIPO_USUARIO"].ToString());

            }

            FecharBanco(AbrirBanco());

            return tipoUsuario;
        }

        public bool VerificarLogin(string usuario, string senha)
        {
            DataTable consultarLogin = new DataTable();

            string queryUsuarioSenha = "SELECT NOME_USUARIO, SENHA FROM USUARIOS WHERE NOME_USUARIO = @USUARIO AND ATIVO = TRUE";

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

    }
}
