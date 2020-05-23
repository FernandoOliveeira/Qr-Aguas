using MySql.Data.MySqlClient;
using QrAguas.BusinessLayer;
using QrAguas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrAguas.Controls
{
    class UpdateProviderMethods : BlDataVerification
    {
        public bool AtualizarFornecedor(NewProvider objFornecedor, int idFornecedor)
        {
            string queryAtualizarFornecedor = "UPDATE FORNECEDORES SET RAZAO_SOCIAL = @RAZAO_SOCIAL, CNPJ = @CNPJ, ENDERECO = @ENDERECO, NUMERO = @NUMERO, BAIRRO = @BAIRRO, CIDADE = @CIDADE, COMPLEMENTO = @COMPLEMENTO, UF = @UF, TELEFONE = @TELEFONE, CELULAR = @CELULAR, CEP = @CEP, EMAIL = @EMAIL WHERE ID_FORNECEDORES = @ID_FORNECEDORES";

            MySqlCommand command = new MySqlCommand(queryAtualizarFornecedor, AbrirBanco());

            command.Parameters.AddWithValue("@RAZAO_SOCIAL", objFornecedor.RazaoSocial);
            command.Parameters.AddWithValue("@CNPJ", objFornecedor.Cnpj);
            command.Parameters.AddWithValue("@ENDERECO", objFornecedor.Endereco);
            command.Parameters.AddWithValue("@NUMERO", objFornecedor.Numero);
            command.Parameters.AddWithValue("@BAIRRO", objFornecedor.Bairro);
            command.Parameters.AddWithValue("@CIDADE", objFornecedor.Cidade);
            command.Parameters.AddWithValue("@COMPLEMENTO", objFornecedor.Complemento);
            command.Parameters.AddWithValue("@UF", objFornecedor.Uf);
            command.Parameters.AddWithValue("@TELEFONE", objFornecedor.Telefone);
            command.Parameters.AddWithValue("@CELULAR", objFornecedor.Celular);
            command.Parameters.AddWithValue("@CEP", objFornecedor.Cep);
            command.Parameters.AddWithValue("@EMAIL", objFornecedor.Email);
            command.Parameters.AddWithValue("@ID_FORNECEDORES", idFornecedor);

            int rowCount = command.ExecuteNonQuery();

            FecharBanco(AbrirBanco());

            return rowCount != 0 ? true : false; 
        }
    }
}
