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
            s
            dataTable.Load(reader);

            FecharBanco(AbrirBanco());

            return dataTable;
        }

    }
}
