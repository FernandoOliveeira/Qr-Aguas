using MySql.Data.MySqlClient;
using QrAguas.View_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrAguas.Controls
{
    class UpdateCategoryMethods : Connection
    {
        public bool AtualizarCategoria(int idCategoria, string nomeCategoria)
        {
            string queryEditarCategoria = "UPDATE CATEGORIAS SET NOME_CATEGORIA = @NOME_CATEGORIA, ATUALIZADO_POR = @ATUALIZADO_POR, DATA_ATUALIZACAO = @DATA_ATUALIZACAO WHERE ID_CATEGORIAS = @ID_CATEGORIAS";

            MySqlCommand command = new MySqlCommand(queryEditarCategoria, AbrirBanco());

            command.Parameters.AddWithValue("@NOME_CATEGORIA", nomeCategoria);
            command.Parameters.AddWithValue("@ATUALIZADO_POR", Login.IdUsuario);
            command.Parameters.AddWithValue("@DATA_ATUALIZACAO", DateTime.Now);
            command.Parameters.AddWithValue("@ID_CATEGORIAS", idCategoria);

            int rowCount = command.ExecuteNonQuery();

            FecharBanco(AbrirBanco());

            return rowCount != 0 ? true : false;
        }

    }
}
