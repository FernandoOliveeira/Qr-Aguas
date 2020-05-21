using MySql.Data.MySqlClient;
using QrAguas.View_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrAguas.Controls
{
    class SearchUserMethods : Connection
    {
        #region Form SearchUser

        public DataTable ProcurarUsuario(string nomeUsuario)
        {
            DataTable dataTable = new DataTable();

            string queryProcurarUsuario = "SELECT U.ID_USUARIOS, U.NOME_USUARIO, T.DESCRICAO, U.DATA_CADASTRO, U.CADASTRADO_POR, U.ATIVO FROM USUARIOS U, TIPO_USUARIO T WHERE U.ID_TIPO_USUARIO = T.ID_TIPO_USUARIO AND U.NOME_USUARIO LIKE '%" + nomeUsuario +"%' AND U.ID_TIPO_USUARIO > @ID_TIPO_USUARIO ORDER BY U.NOME_USUARIO";


            MySqlCommand command = new MySqlCommand(queryProcurarUsuario, AbrirBanco());

            command.Parameters.AddWithValue("@ID_TIPO_USUARIO", Login.TipoUsuario);

            MySqlDataReader reader = command.ExecuteReader();

            dataTable.Load(reader);

            FecharBanco(AbrirBanco());

            return dataTable;

        }

        public bool AtivarDesativarUsuario(int idUsuario, bool ativo)
        {
            string queryAtivarDesativarUsuario = "UPDATE USUARIOS SET ATIVO = @ATIVO WHERE ID_USUARIOS = @ID_USUARIOS";

            MySqlCommand command = new MySqlCommand(queryAtivarDesativarUsuario, AbrirBanco());

            command.Parameters.AddWithValue("@ATIVO", ativo);
            command.Parameters.AddWithValue("@ID_USUARIOS", idUsuario);

            int rowCount = command.ExecuteNonQuery();

            FecharBanco(AbrirBanco());

            return rowCount != 0 ? true : false;
        }

        #endregion

    }
}
