using MySql.Data.MySqlClient;
using QrAguas.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrAguas.Controls
{
    class SearchProviderMethods : BlDataVerification
    {
        public DataTable ProcurarFornecedor(string nomeFornecedor)
        {
            DataTable dataTable = new DataTable();

            string queryProcurarFornecedor = "SELECT RAZAO_SOCIAL, CNPJ, ENDERECO, NUMERO, BAIRRO, CIDADE, COMPLEMENTO, UF, TELEFONE, CELULAR, CEP, EMAIL FROM FORNECEDORES WHERE RAZAO_SOCIAL LIKE '%" + nomeFornecedor + "%'";

            MySqlCommand command = new MySqlCommand(queryProcurarFornecedor, AbrirBanco());

            MySqlDataReader reader = command.ExecuteReader();
            
            dataTable.Load(reader);

            FecharBanco(AbrirBanco());

            return dataTable;
        }

        public bool ExcluirFornecedor(int idFornecedor)
        {
            string queryExcluirFornecedor = "UPDATE FORNECEDORES SET DELETADO = TRUE WHERE ID_FORNECEDORES = @ID_FORNECEDORES";

            MySqlCommand command = new MySqlCommand(queryExcluirFornecedor, AbrirBanco());
            command.Parameters.AddWithValue("@ID_FORNECEDORES", idFornecedor);

            int rowCount = command.ExecuteNonQuery();

            FecharBanco(AbrirBanco());

            return rowCount != 0 ? true : false;
        }

    }
}
