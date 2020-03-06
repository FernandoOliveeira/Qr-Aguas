using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrAguas.Models
{
    class NewProduct
    {
        public string CodigoProduto { get; set; }
        public string NomeProduto { get; set; }
        public double PrecoCompra { get; set; }
        public int Fornecedor { get; set; }
        public string Descricao { get; set; }
        public double PrecoVenda { get; set; }
        public int Categoria { get; set; }
        public DateTime DataFabricao { get; set; }
        public DateTime DataValidade { get; set; }


    }
}
