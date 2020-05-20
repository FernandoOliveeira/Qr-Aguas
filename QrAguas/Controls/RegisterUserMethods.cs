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
    class RegisterUserMethods : BlDataVerification
    {
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
            string queryCadastrarUsuario = "INSERT INTO USUARIOS (NOME_USUARIO, SENHA, ID_TIPO_USUARIO, CADASTRADO_POR, ID_UNICO, DATA_CADASTRO) VALUES ( @NOME_USUARIO, @SENHA, @ID_TIPO_USUARIO, @CADASTRADO_POR, UUID(), @DATA_CADASTRO)";

            MySqlCommand command = new MySqlCommand(queryCadastrarUsuario, AbrirBanco());

            command.Parameters.AddWithValue("@NOME_USUARIO", objNovoUsuario.NomeUsuario);
            command.Parameters.AddWithValue("@SENHA", objNovoUsuario.Senha);
            command.Parameters.AddWithValue("@ID_TIPO_USUARIO", objNovoUsuario.IdTipoUsuario);
            command.Parameters.AddWithValue("@CADASTRADO_POR", objNovoUsuario.CadastradoPor);
            command.Parameters.AddWithValue("@DATA_CADASTRO", DateTime.Now);

            int rowCount = command.ExecuteNonQuery();

            FecharBanco(AbrirBanco());

            return rowCount != 0 ? true : false;
        }

    }
}
