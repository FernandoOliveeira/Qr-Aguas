using MySql.Data.MySqlClient;
using QrAguas.View_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrAguas.Controls
{
    class RegisterCategoryMethods : Connection
    {

        public bool CadastrarNovaCategoria(string categoria)
        {
            string queryCadastrarCategoria = "INSERT INTO CATEGORIAS (NOME_CATEGORIA, ID_USUARIOS) VALUES (@NOME_CATEGORIA, @ID_USUARIOS)";

            MySqlCommand command = new MySqlCommand(queryCadastrarCategoria, AbrirBanco());

            command.Parameters.AddWithValue("@NOME_CATEGORIA", categoria);
            command.Parameters.AddWithValue("@ID_USUARIOS", Login.IdUsuario);

            int rowCount = command.ExecuteNonQuery();

            FecharBanco(AbrirBanco());

            return rowCount != 0 ? true : false;
        }

        public bool DeletarCategoria(int idCategoria)
        {
            string queryDeletarCategoria = "DELETE FROM CATEGORIAS WHERE ID_CATEGORIAS = @ID_CATEGORIAS";

            MySqlCommand command = new MySqlCommand(queryDeletarCategoria, AbrirBanco());

            command.Parameters.AddWithValue("ID_CATEGORIAS", idCategoria);

            int rowCount = command.ExecuteNonQuery();

            FecharBanco(AbrirBanco());

            return rowCount != 0 ? true : false;
        }

        public bool AtivarDesativarCategoria(int idCategoria, bool ativo)
        {
            // Caso o a categoria já esteja ativa, então será desativada e vice e versa.

            string queryAtivarDesativar = "UPDATE CATEGORIAS SET ATIVO = @ATIVO WHERE ID_CATEGORIAS = @ID_CATEGORIAS";

            MySqlCommand command = new MySqlCommand(queryAtivarDesativar, AbrirBanco());

            command.Parameters.AddWithValue("@ATIVO", ativo);
            command.Parameters.AddWithValue("@ID_CATEGORIAS", idCategoria);

            int rowCount = command.ExecuteNonQuery();

            return rowCount != 0 ? true : false;
        }


    }
}
