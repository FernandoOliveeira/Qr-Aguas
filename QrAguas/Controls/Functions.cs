using MySql.Data.MySqlClient;
using QrAguas.BusinessLayer;
using QrAguas.Models;
using QrAguas.Models.SellProductEntities;
using QrAguas.View_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QrAguas.Controls
{
    class Functions : BlDataVerification
    {
        #region Funções Genéricas

        public string GerarMd5(string senha)
        {
            MD5 md5Hash = MD5.Create();

            // Criptografa a senha passada como parâmetro
            byte[] senhaCriptografada = md5Hash.ComputeHash(Encoding.Default.GetBytes(senha));

            // Cria um StringBuilder para passarmos os bytes gerados
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < senhaCriptografada.Length; i++)
            {
                stringBuilder.Append(senhaCriptografada[i].ToString("x2"));
            }

            // Retorna o valor criptografado como string
            return stringBuilder.ToString();
        }

        public bool VerificarLogin(string usuario, string senha)
        {
            DataTable consultarLogin = new DataTable();

            string queryUsuarioSenha = "SELECT NOME_USUARIO, SENHA FROM USUARIOS WHERE NOME_USUARIO = @USUARIO AND ATIVO = TRUE";

            MySqlCommand command = new MySqlCommand(queryUsuarioSenha, AbrirBanco());
            command.Parameters.AddWithValue("@USUARIO", usuario);
            MySqlDataReader reader = command.ExecuteReader();

            consultarLogin.Load(reader);

            string usuarioBanco = "";
            string senhaBanco = "";

            foreach (DataRow row in consultarLogin.Rows)
            {
                usuarioBanco = row["NOME_USUARIO"].ToString();
                senhaBanco = row["SENHA"].ToString();

                if (usuarioBanco.Equals(usuario) && senhaBanco.Equals(senha))
                {
                    FecharBanco(AbrirBanco());
                    return true;
                }
            }

            FecharBanco(AbrirBanco());

            return false;
        }

        #endregion

        #region Form RegisterProduct

        public bool CadastrarNovoProduto(NewProduct objProduto)
        {
            string queryCadastrarProduto = "INSERT INTO PRODUTOS VALUES(NULL, @COD_PRODUTO, @NOME_PRODUTO, @DESCRICAO, @QUANTIDADE, @PRECO_COMPRA, @PRECO_VENDA, @ID_FORNECEDORES, @ID_USUARIOS, @ID_CATEGORIAS, @DATA_FABRICACAO, @DATA_VALIDADE, @DATA_CADASTRO) ";

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

        #endregion

        #region Form SearchUser

        public DataTable ProcurarUsuario(string nomeUsuario)
        {
            DataTable dataTable = new DataTable();

            string queryProcurarUsuario = "SELECT U.ID_USUARIOS, U.NOME_USUARIO, T.DESCRICAO, U.DATA_CADASTRO, U.CADASTRADO_POR, U.ATIVO FROM USUARIOS U, TIPO_USUARIO T WHERE U.ID_TIPO_USUARIO = T.ID_TIPO_USUARIO AND U.NOME_USUARIO = @NOME_USUARIO AND U.ID_TIPO_USUARIO > @ID_TIPO_USUARIO";

            
            MySqlCommand command = new MySqlCommand(queryProcurarUsuario, AbrirBanco());

            command.Parameters.AddWithValue("@NOME_USUARIO", nomeUsuario);
            command.Parameters.AddWithValue("@ID_TIPO_USUARIO", Login.TipoUsuario);

            MySqlDataReader reader = command.ExecuteReader();

            dataTable.Load(reader);

            return dataTable;

        }

        public bool AtivarDesativarUsuario(int idUsuario, bool ativo)
        {
            string queryAtivarDesativarUsuario = "UPDATE USUARIOS SET ATIVO = @ATIVO WHERE ID_USUARIOS = @ID_USUARIOS";

            MySqlCommand command = new MySqlCommand(queryAtivarDesativarUsuario, AbrirBanco());

            command.Parameters.AddWithValue("@ATIVO", ativo);
            command.Parameters.AddWithValue("@ID_USUARIOS", idUsuario);

            int rowCount = command.ExecuteNonQuery();

            return rowCount != 0 ? true : false;
        }

        #endregion

        #region Form SellProduct

        public Product ProcurarProduto(int codigoProduto)
        {
            DataTable dadosProduto = new DataTable();

            string queryProcurarProduto = "SELECT NOME_PRODUTO, PRECO_VENDA, QUANTIDADE FROM PRODUTOS WHERE COD_PRODUTO = @CodigoProduto";

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

        #endregion
    }
}
