﻿using MySql.Data.MySqlClient;
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
        #region Gerar Hash MD5


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

        #endregion


        #region Form Login

        public int VerificarIdUsuario(string usuario)
        {
            DataTable consultarIdUsuario = new DataTable();

            string queryVerificarIdUsuario = "SELECT ID_USUARIOS FROM USUARIOS WHERE NOME_USUARIO = @NOME_USUARIO";

            MySqlCommand command = new MySqlCommand(queryVerificarIdUsuario, AbrirBanco());
            command.Parameters.AddWithValue("@NOME_USUARIO", usuario);
            MySqlDataReader reader = command.ExecuteReader();

            consultarIdUsuario.Load(reader);

            int idUsuario = 0;

            foreach (DataRow row in consultarIdUsuario.Rows)
            {
                idUsuario = int.Parse(row["ID_USUARIOS"].ToString());
            }

            FecharBanco(AbrirBanco());

            return idUsuario;
        }

        public int VerificarTipoUsuario(string usuario)
        {
            DataTable consultarTipoUsuario = new DataTable();

            string queryTipoUsuario = "SELECT ID_TIPO_USUARIO FROM USUARIOS WHERE NOME_USUARIO = @USUARIO";

            MySqlCommand command = new MySqlCommand(queryTipoUsuario, AbrirBanco());
            command.Parameters.AddWithValue("@USUARIO", usuario);
            MySqlDataReader reader = command.ExecuteReader();

            consultarTipoUsuario.Load(reader);

            int tipoUsuario = 0;

            foreach(DataRow row in consultarTipoUsuario.Rows)
            {
                tipoUsuario = int.Parse(row["ID_TIPO_USUARIO"].ToString());

            }

            FecharBanco(AbrirBanco());

            return tipoUsuario;
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


        #region Form RegisterUser


        public bool VerificarNomeUsuario(string nomeUsuario)
        {
            DataTable consultarNomeUsuario = new DataTable();

            string queryNomeUsuario = "SELECT NOME_USUARIO FROM USUARIOS WHERE NOME_USUARIO = '" + nomeUsuario + "'";

            MySqlCommand command = new MySqlCommand(queryNomeUsuario, AbrirBanco());
            MySqlDataReader reader = command.ExecuteReader();

            consultarNomeUsuario.Load(reader);

            string usuarioBanco = ".";

            foreach (DataRow row in consultarNomeUsuario.Rows)
            {
                usuarioBanco = row["NOME_USUARIO"].ToString();
            }

            if (usuarioBanco == nomeUsuario)
            {
                FecharBanco(AbrirBanco());
                return true;
            }

            FecharBanco(AbrirBanco());
            return false;

        }

        public bool CadastrarNovoUsuario(NewUser objNovoUsuario)
        {
            string queryCadastrarUsuario = "INSERT INTO USUARIOS (NOME_USUARIO, SENHA, ID_TIPO_USUARIO, CADASTRADO_POR, ID_UNICO, DATA_CADASTRO) VALUES ( @NOME_USUARIO, @SENHA, @ID_TIPO_USUARIO, @CADASTRADO_POR, UUID(), @DATA_CADASTRO)";

            MySqlCommand command = new MySqlCommand(queryCadastrarUsuario, AbrirBanco());

            command.Parameters.AddWithValue("@NOME_USUARIO", objNovoUsuario.NomeUsuario);
            command.Parameters.AddWithValue("@SENHA", objNovoUsuario.Senha);
            command.Parameters.AddWithValue("@ID_TIPO_USUARIO", objNovoUsuario.IdTipoUsuario);
            command.Parameters.AddWithValue("@CADASTRADO_POR", objNovoUsuario.CadastradoPor);
            command.Parameters.AddWithValue("@DATA_CADASTRO", DateTime.Now);

            int rowCount = command.ExecuteNonQuery();

            FecharBanco(AbrirBanco());

            return rowCount != 0 ? true : false;
        }

        #endregion


        #region Form ChangePassword


        public bool AlterarSenha(string senha, string nomeUsuario)
        {
            string queryAlterarSenha = "UPDATE USUARIOS SET SENHA = @Senha WHERE NOME_USUARIO = @NomeUsuario";

            MySqlCommand command = new MySqlCommand(queryAlterarSenha, AbrirBanco());

            command.Parameters.AddWithValue("@Senha", senha);
            command.Parameters.AddWithValue("@NomeUsuario", nomeUsuario);

            int rowCount = command.ExecuteNonQuery();

            if (rowCount != 0)
            {
                string querySenhaAlterada = "UPDATE USUARIOS SET DATA_SENHA_ALTERADA  = @DataAtual WHERE NOME_USUARIO = @NomeUsuario";

                MySqlCommand commandSenhaAlterada = new MySqlCommand(querySenhaAlterada, AbrirBanco());

                commandSenhaAlterada.Parameters.AddWithValue("@DataAtual", DateTime.Now);
                commandSenhaAlterada.Parameters.AddWithValue("@NomeUsuario", nomeUsuario);
                commandSenhaAlterada.ExecuteNonQuery();

                FecharBanco(AbrirBanco());

                return true;
            }

            FecharBanco(AbrirBanco());

            return false;
        }

        #endregion


        #region Form RegisterProviders

        public bool ValidarCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            cnpj = cnpj.Trim().Replace(".", "").Replace("-", "").Replace("/", "");

            if (cnpj.Length != 14)
            {
                return false;
            }
                

            string tempCnpj = cnpj.Substring(0, 12);
            int soma = 0;

            for (int i = 0; i < 12; i++)
            {
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            }


            int resto = (soma % 11);

            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }
                

            string digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
            {
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            }

            resto = (soma % 11);

            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }
                

            digito = digito + resto.ToString();

            return cnpj.EndsWith(digito);
        }

        public bool ValidarEmail(string email)
        {
            try
            {
                MailAddress emailValido = new MailAddress(email);

                return emailValido.Equals(email);
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool CadastrarNovoFornecedor(NewProvider objFornecedor)
        {
            string queryCadastrarFonecedor = "INSERT INTO FORNECEDORES (RAZAO_SOCIAL, CNPJ, ENDERECO, NUMERO, BAIRRO, CIDADE, COMPLEMENTO, UF, TELEFONE, CELULAR, CEP, EMAIL, ID_USUARIOS) VALUES (@RAZAO_SOCIAL, @CNPJ, @ENDERECO, @NUMERO, @BAIRRO, @CIDADE, @COMPLEMENTO, @UF, @TELEFONE, @CELULAR, @CEP, @EMAIL, @ID_USUARIOS)";

            MySqlCommand command = new MySqlCommand(queryCadastrarFonecedor, AbrirBanco());

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
            command.Parameters.AddWithValue("@ID_USUARIOS", Login.IdUsuario);

            int rowCount = command.ExecuteNonQuery();

            FecharBanco(AbrirBanco());

            return rowCount != 0 ? true : false;
        }

        #endregion


        #region Form RegisterCategory

        public bool CadastrarNovaCategoria(string categoria)
        {
            string queryCadastrarCategoria = "INSERT INTO CATEGORIAS (NOME_CATEGORIA, ID_USUARIOS) VALUES (@NOME_CATEGORIA, @ID_USUARIOS)";

            MySqlCommand command = new MySqlCommand(queryCadastrarCategoria, AbrirBanco());

            command.Parameters.AddWithValue("@NOME_CATEGORIA", categoria);
            command.Parameters.AddWithValue("@ID_USUARIOS", Login.IdUsuario);

            int rowCount = command.ExecuteNonQuery();

            FecharBanco(AbrirBanco());

            return rowCount != 0 ? true : false;
        }

        public bool DeletarCategoria(int idCategoria)
        {
            string queryDeletarCategoria = "DELETE FROM CATEGORIAS WHERE ID_CATEGORIAS = @ID_CATEGORIAS";

            MySqlCommand command = new MySqlCommand(queryDeletarCategoria, AbrirBanco());

            command.Parameters.AddWithValue("ID_CATEGORIAS", idCategoria);

            int rowCount = command.ExecuteNonQuery();

            FecharBanco(AbrirBanco());

            return rowCount != 0 ? true : false;
        }

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

        public bool AtivarDesativarCategoria(int idCategoria, bool ativo)
        {
            // Caso o a categoria já esteja ativa, então será desativada e vice e versa.

            string queryAtivarDesativar = "UPDATE CATEGORIAS SET ATIVO = @ATIVO WHERE ID_CATEGORIAS = @ID_CATEGORIAS";

            MySqlCommand command = new MySqlCommand(queryAtivarDesativar, AbrirBanco());

            command.Parameters.AddWithValue("@ATIVO", ativo);
            command.Parameters.AddWithValue("@ID_CATEGORIAS", idCategoria);

            int rowCount = command.ExecuteNonQuery();

            return rowCount != 0 ? true : false;
        }

        #endregion


        #region Form RegisterProduct

        public bool CadastrarNovoProduto(NewProduct objProduto)
        {
            string queryCadastrarProduto = "INSERT INTO PRODUTOS VALUES(NULL, @COD_PRODUTO, @NOME_PRODUTO, @DESCRICAO, @PRECO_COMPRA, @PRECO_VENDA, @ID_FORNECEDORES, @ID_USUARIOS, @ID_CATEGORIAS, @DATA_FABRICACAO, @DATA_VALIDADE, @DATA_CADASTRO) ";

            MySqlCommand command = new MySqlCommand(queryCadastrarProduto, AbrirBanco());

            command.Parameters.AddWithValue("@COD_PRODUTO", objProduto.CodigoProduto);
            command.Parameters.AddWithValue("@NOME_PRODUTO", objProduto.NomeProduto);
            command.Parameters.AddWithValue("@DESCRICAO", objProduto.Descricao);
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

            string queryProcurarProduto = "SELECT NOME_PRODUTO, PRECO_VENDA FROM PRODUTOS WHERE COD_PRODUTO = @CodigoProduto";

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
            }

            FecharBanco(AbrirBanco());

            return product;
        }

        public bool VenderProduto(Cart cart, OrderProduct order)
        {
            // Primeiro: Inserir a venda na tabela VENDAS
            string queryInserirVenda = "INSERT INTO VENDAS VALUES (NULL, @ID_USUARIOS, @DATA_VENDA)";

            MySqlCommand command = new MySqlCommand(queryInserirVenda, AbrirBanco());
            command.Parameters.AddWithValue("@ID_USUARIOS", Login.IdUsuario);
            command.Parameters.AddWithValue("@DATA_VENDA", cart.HoraVenda);

            if (command.ExecuteNonQuery() == 1)
            {
                // Segundo: Para cada item na lista de produtos, será inserido um registro na tabela Vendas_Produtos
                foreach (OrderProduct produto in cart.Produtos)
                {
                    string queryRegistrarProdVendidos = "INSERT INTO VENDAS_PRODUTOS (ID_VENDAS, ID_PRODUTOS, QUANTIDADE_PRODUTOS, PRECO_PRODUTO) SELECT MAX(V.ID_VENDAS), P.ID_PRODUTOS, @QUANTIDADE, P.PRECO_VENDA FROM VENDAS V, PRODUTOS P WHERE P.COD_PRODUTO = @COD_PRODUTO";

                    MySqlCommand commandVenda = new MySqlCommand(queryRegistrarProdVendidos, AbrirBanco());
                    commandVenda.Parameters.AddWithValue("@QUANTIDADE", produto.Quantidade);
                    commandVenda.Parameters.AddWithValue("@COD_PRODUTO", produto.CodigoProduto);

                    commandVenda.ExecuteNonQuery();
                }

                return true;

            }

            return false;
        }

        #endregion
    }
}
