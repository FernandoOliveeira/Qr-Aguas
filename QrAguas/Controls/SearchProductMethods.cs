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
            string queryExcluirProduto = "UPTADE PRODUTOS SET DELETADO = TRUE WHERE ID_PRODUTO = @ID_PRODUTO";

            MySqlCommand command = new MySqlCommand(queryExcluirProduto, AbrirBanco());
            command.Parameters.AddWithValue("@ID_PRODUTO", idProduto);

            int rowCount = command.ExecuteNonQuery();

            return rowCount != 0 ? true : false;
        }

        
    }
}
