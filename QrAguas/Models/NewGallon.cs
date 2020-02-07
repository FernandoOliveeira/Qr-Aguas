using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrAguas.Models
{
    class NewGallon
    {
        public string CodigoProduto { get; set; }
        public string  NomeProduto { get; set; }
        public double PrecoCompra { get; set; }
        public string Fornecedor { get; set; }
        public string Descricao { get; set; }
        public double PrecoVenda { get; set; }
        public DateTime DataFabricao { get; set; }

        public DateTime DataValidade { get; set; }


        private void CalcularDataValidade()
        {
            // TODO: Adicionar mais 3 anos à data de fabricação e atribuir o valor à data de validade
        }
    }
}
