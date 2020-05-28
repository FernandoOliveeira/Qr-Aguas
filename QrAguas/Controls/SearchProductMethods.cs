using MySql.Data.MySqlClient;
using QrAguas.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrAguas.Controls
{
    class SearchProductMethods : BlDataVerification
    {
        public bool ExcluirProduto(int idProduto)
        {
            string queryExcluirProduto = "UPDATE PRODUTOS SET DELETADO = TRUE WHERE ID_PRODUTOS = @ID_PRODUTOS";

            MySqlCommand command = new MySqlCommand(queryExcluirProduto, AbrirBanco());
            command.Parameters.AddWithValue("@ID_PRODUTOS", idProduto);

            int rowCount = command.ExecuteNonQuery();

            FecharBanco(AbrirBanco());

            return rowCount != 0 ? true : false;
        }

        
    }
}
