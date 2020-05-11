using QrAguas.Controls;
using QrAguas.Models;
using QrAguas.View_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrAguas.BusinessLayer
{
    class BlDataVerification : Connection
    {
        public bool VerificarDadosUsuario(NewUser usuario)
        {
            if (!String.IsNullOrEmpty(usuario.NomeUsuario) &&
                !String.IsNullOrEmpty(usuario.Senha) &&
                !String.IsNullOrEmpty(usuario.IdTipoUsuario.ToString()) &&
                !String.IsNullOrEmpty(usuario.CadastradoPor))
            {
                return true;
            }

            return false;
        }

        public bool VerificarDadosFornecedores(NewProvider fornecedor)
        {
            // Os campos Complemento, Email e Celular não estão sendo verificados pois podem ser nulos no Banco de Dados
            if (!String.IsNullOrEmpty(fornecedor.RazaoSocial) &&
                !String.IsNullOrEmpty(fornecedor.Cnpj) &&
                !String.IsNullOrEmpty(fornecedor.Endereco) &&
                !String.IsNullOrEmpty(fornecedor.Bairro) &&
                !String.IsNullOrEmpty(fornecedor.Cidade) &&
                !String.IsNullOrEmpty(fornecedor.Uf) &&
                !String.IsNullOrEmpty(fornecedor.Telefone) &&
                !String.IsNullOrEmpty(fornecedor.Cep))
            {
                if (fornecedor.Cnpj.Length == 18 && fornecedor.Telefone.Length == 14 && fornecedor.Cep.Length == 9 && fornecedor.Numero > 0) 
                {
                    return true;

                }

            }

            return false;
        }

        public bool VerificarDadosProdutos(NewProduct produto)
        {
            if (!String.IsNullOrEmpty(produto.Categoria.ToString()) &&
                !String.IsNullOrEmpty(produto.CodigoProduto) &&
                !String.IsNullOrEmpty(produto.DataFabricao.ToString()) &&
                !String.IsNullOrEmpty(produto.DataValidade.ToString()) &&
                !String.IsNullOrEmpty(produto.Quantidade.ToString()) &&
                !String.IsNullOrEmpty(produto.Descricao) &&
                !String.IsNullOrEmpty(produto.Fornecedor.ToString()) &&
                !String.IsNullOrEmpty(produto.NomeProduto) &&
                !String.IsNullOrEmpty(produto.PrecoCompra.ToString()) &&
                !String.IsNullOrEmpty(produto.PrecoVenda.ToString()))

            {
                if (produto.PrecoCompra.Equals(0) || produto.PrecoVenda.Equals(0))
                {
                    return false;
                }

                return true;
            }

            return false;
        }


    }
}
