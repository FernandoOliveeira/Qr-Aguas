namespace QrAguas.Models
{
    class Product
    {
        public int CodigoProduto { get; set; }
        public string NomeProduto { get; set; }
        public double Preco { get; set; }
        public int QuantidadeBanco { get; set; }

        // Construtores
        public Product()
        {
        }

        public Product(int codigoProduto, string nomeProduto, double preco, int quantidade)
        {
            CodigoProduto = codigoProduto;
            NomeProduto = nomeProduto;
            Preco = preco;
            QuantidadeBanco = quantidade;
        }

        public override string ToString()
        {
            return NomeProduto;
        }

    }
}
