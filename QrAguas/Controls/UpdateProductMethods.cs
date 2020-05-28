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
    class UpdateProductMethods : BlDataVerification
    {
        public bool AtualizarProduto(int idProduto, NewProduct product)
        {
            string queryAtualizarProdutos = "UPDATE PRODUTOS SET COD_PRODUTO = @COD_PRODUTO, NOME_PRODUTO = @NOME_PRODUTO, DESCRICAO = @DESCRICAO, PRECO_COMPRA = @PRECO_COMPRA, PRECO_VENDA = @PRECO_VENDA, ID_FORNECEDORES = @ID_FORNECEDORES, ID_CATEGORIAS = @ID_CATEGORIAS, DATA_FABRICACAO = @DATA_FABRICACAO, DATA_VALIDADE = @DATA_VALIDADE WHERE ID_PRODUTOS = @ID_PRODUTOS";

            MySqlCommand command = new MySqlCommand(queryAtualizarProdutos, AbrirBanco());
            command.Parameters.AddWithValue("@COD_PRODUTO", product.CodigoProduto);
            command.Parameters.AddWithValue("@NOME_PRODUTO", product.NomeProduto);
            command.Parameters.AddWithValue("@DESCRICAO", product.Descricao);
            command.Parameters.AddWithValue("@PRECO_COMPRA", product.PrecoCompra);
            command.Parameters.AddWithValue("@PRECO_VENDA", product.PrecoVenda);
            command.Parameters.AddWithValue("@ID_FORNECEDORES", product.Fornecedor);
            command.Parameters.AddWithValue("@ID_CATEGORIAS", product.Categoria);
            command.Parameters.AddWithValue("@DATA_FABRICACAO", product.DataFabricao);
            command.Parameters.AddWithValue("@DATA_VALIDADE", product.DataValidade);
            command.Parameters.AddWithValue("@ID_PRODUTOS", idProduto);

            int rowCount = command.ExecuteNonQuery();

            FecharBanco(AbrirBanco());

            return rowCount != 0 ? true : false;
        }
    }
}
