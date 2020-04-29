namespace QrAguas.Models
{
    class Product
    {
        public int CodigoProduto { get; set; }
        public string NomeProduto { get; set; }
        public double Preco { get; set; }

        // Construtores
        public Product()
        {
        }

        public Product(int codigoProduto, string nomeProduto, double preco)
        {
            CodigoProduto = codigoProduto;
            NomeProduto = nomeProduto;
            Preco = preco;
        }

        public override string ToString()
        {
            return NomeProduto;
        }

    }
}
