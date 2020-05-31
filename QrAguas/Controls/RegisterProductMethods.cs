using MySql.Data.MySqlClient;
using QrAguas.BusinessLayer;
using QrAguas.Models;
using QrAguas.View_Layer;
using System;

namespace QrAguas.Controls
{
    class RegisterProductMethods : BlDataVerification
    {

        public bool CadastrarNovoProduto(NewProduct objProduto)
        {
            string queryCadastrarProduto = "INSERT INTO PRODUTOS(ID_PRODUTOS, COD_PRODUTO, NOME_PRODUTO, DESCRICAO, QUANTIDADE, PRECO_COMPRA, PRECO_VENDA, ID_FORNECEDORES, ID_USUARIOS, ID_CATEGORIAS, DATA_FABRICACAO, DATA_VALIDADE, DATA_CADASTRO) VALUES(NULL, @COD_PRODUTO, @NOME_PRODUTO, @DESCRICAO, @QUANTIDADE, @PRECO_COMPRA, @PRECO_VENDA, @ID_FORNECEDORES, @ID_USUARIOS, @ID_CATEGORIAS, @DATA_FABRICACAO, @DATA_VALIDADE, @DATA_CADASTRO) ";

            MySqlCommand command = new MySqlCommand(queryCadastrarProduto, AbrirBanco());

            command.Parameters.AddWithValue("@COD_PRODUTO", objProduto.CodigoProduto);
            command.Parameters.AddWithValue("@NOME_PRODUTO", objProduto.NomeProduto);
            command.Parameters.AddWithValue("@DESCRICAO", objProduto.Descricao);
            command.Parameters.AddWithValue("@QUANTIDADE", objProduto.Quantidade);
            command.Parameters.AddWithValue("@PRECO_COMPRA", objProduto.PrecoCompra);
            command.Parameters.AddWithValue("@PRECO_VENDA", objProduto.PrecoVenda);
            command.Parameters.AddWithValue("@ID_FORNECEDORES", objProduto.Fornecedor);
            command.Parameters.AddWithValue("@ID_USUARIOS", Login.IdUsuario);
            command.Parameters.AddWithValue("@ID_CATEGORIAS", objProduto.Categoria);
            command.Parameters.AddWithValue("@DATA_FABRICACAO", objProduto.DataFabricao);
            command.Parameters.AddWithValue("@DATA_VALIDADE", objProduto.DataValidade);
            command.Parameters.AddWithValue("@DATA_CADASTRO", DateTime.Now);

            int rowCount = command.ExecuteNonQuery();

            FecharBanco(AbrirBanco());

            return rowCount != 0 ? true : false;

        }

    }
}
