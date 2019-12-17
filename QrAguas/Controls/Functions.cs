using MySql.Data.MySqlClient;
using QrAguas.BusinessLayer;
using QrAguas.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrAguas.Controls
{
    class Functions : BlNewUser
    {
        #region FormLogin

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


        #region Form NewUser

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
            string queryCadastrarUsuario = "INSERT INTO USUARIOS (NOME_USUARIO, SENHA, ID_TIPO_USUARIO, CADASTRADO_POR) VALUES ( @NOME_USUARIO, @SENHA, @ID_TIPO_USUARIO, @CADASTRADO_POR)";

            MySqlCommand command = new MySqlCommand(queryCadastrarUsuario, AbrirBanco());

            command.Parameters.AddWithValue("@NOME_USUARIO", objNovoUsuario.NomeUsuario);
            command.Parameters.AddWithValue("@SENHA", objNovoUsuario.Senha);
            command.Parameters.AddWithValue("@ID_TIPO_USUARIO", objNovoUsuario.IdTipoUsuario);
            command.Parameters.AddWithValue("@CADASTRADO_POR", objNovoUsuario.CadastradoPor);

            int rowCount = command.ExecuteNonQuery();

            return rowCount != 0 ? true : false;
        }

        #endregion


    }
}
