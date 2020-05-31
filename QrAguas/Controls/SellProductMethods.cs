using MySql.Data.MySqlClient;
using QrAguas.Models;
using QrAguas.Models.SellProductEntities;
using QrAguas.View_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrAguas.Controls
{
    class SellProductMethods : Connection
    {
        public Product ProcurarProduto(int codigoProduto)
        {
            DataTable dadosProduto = new DataTable();

            string queryProcurarProduto = "SELECT NOME_PRODUTO, PRECO_VENDA, QUANTIDADE FROM PRODUTOS WHERE COD_PRODUTO = @CodigoProduto AND DELETADO = FALSE";

            MySqlCommand command = new MySqlCommand(queryProcurarProduto, AbrirBanco());
            command.Parameters.AddWithValue("@CodigoProduto", codigoProduto);

            MySqlDataReader reader = command.ExecuteReader();

            dadosProduto.Load(reader);

            Product product = new Product
            {
                CodigoProduto = codigoProduto
            };

            foreach (DataRow row in dadosProduto.Rows)
            {
                product.NomeProduto = row["NOME_PRODUTO"].ToString();
                product.Preco = double.Parse(row["PRECO_VENDA"].ToString());
                product.QuantidadeBanco = int.Parse(row["QUANTIDADE"].ToString());
            }

            FecharBanco(AbrirBanco());

            return product;
        }

        public bool VenderProduto(Cart cart, OrderProduct order)
        {
            // Primeiro: Inserir a venda na tabela VENDAS
            string queryInserirVenda = "INSERT INTO VENDAS VALUES (NULL, @ID_USUARIOS, @DATA_VENDA)";

            MySqlCommand commandInserirVenda = new MySqlCommand(queryInserirVenda, AbrirBanco());
            commandInserirVenda.Parameters.AddWithValue("@ID_USUARIOS", Login.IdUsuario);
            commandInserirVenda.Parameters.AddWithValue("@DATA_VENDA", cart.HoraVenda);

            if (commandInserirVenda.ExecuteNonQuery() == 1)
            {
                // Segundo: Para cada item na lista de produtos, será inserido um registro na tabela Vendas_Produtos
                foreach (OrderProduct produto in cart.Produtos)
                {
                    // Registra as vendas na tabela VENDAS_PRODUTOS
                    string queryRegistrarProdVendidos = "INSERT INTO VENDAS_PRODUTOS (ID_VENDAS, ID_PRODUTOS, QUANTIDADE_PRODUTOS, PRECO_PRODUTO) SELECT MAX(V.ID_VENDAS), P.ID_PRODUTOS, @QUANTIDADE, P.PRECO_VENDA FROM VENDAS V, PRODUTOS P WHERE P.COD_PRODUTO = @COD_PRODUTO";

                    MySqlCommand commandVenda = new MySqlCommand(queryRegistrarProdVendidos, AbrirBanco());
                    commandVenda.Parameters.AddWithValue("@QUANTIDADE", produto.Quantidade);
                    commandVenda.Parameters.AddWithValue("@COD_PRODUTO", produto.CodigoProduto);

                    commandVenda.ExecuteNonQuery();

                    // Faz a busca da quantidade de cada item, no banco
                    DataTable dadosProduto = new DataTable();

                    string queryProcuraQtd = "SELECT QUANTIDADE FROM PRODUTOS WHERE COD_PRODUTO = @CodigoProduto";

                    MySqlCommand commandProcuraQtd = new MySqlCommand(queryProcuraQtd, AbrirBanco());
                    commandProcuraQtd.Parameters.AddWithValue("@CodigoProduto", produto.CodigoProduto);

                    MySqlDataReader reader = commandProcuraQtd.ExecuteReader();

                    dadosProduto.Load(reader);

                    int quantidadeBanco = 0;

                    foreach (DataRow row in dadosProduto.Rows)
                    {
                        quantidadeBanco = int.Parse(row["QUANTIDADE"].ToString());
                    }


                    int quantidadeAtual = quantidadeBanco - produto.Quantidade;


                    // Atualiza os produtos com as quantidade atuais
                    string queryAtualizaQtd = "UPDATE PRODUTOS SET QUANTIDADE = @QUANTIDADE WHERE COD_PRODUTO = @COD_PRODUTO";

                    MySqlCommand commandAtualizaQtd = new MySqlCommand(queryAtualizaQtd, AbrirBanco());
                    commandAtualizaQtd.Parameters.AddWithValue("@QUANTIDADE", quantidadeAtual);
                    commandAtualizaQtd.Parameters.AddWithValue("@COD_PRODUTO", produto.CodigoProduto);

                    commandAtualizaQtd.ExecuteNonQuery();
                }

                FecharBanco(AbrirBanco());
                return true;

            }

            FecharBanco(AbrirBanco());
            return false;
        }

    }
}
