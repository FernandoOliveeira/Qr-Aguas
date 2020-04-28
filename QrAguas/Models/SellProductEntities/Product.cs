namespace QrAguas.Models
{
    class Product
    {
        public string NomeProduto { get; set; }
        public double Preco { get; set; }

        // Construtores
        public Product()
        {
        }

        public Product(string nomeProduto, double preco)
        {
            NomeProduto = nomeProduto;
            Preco = preco;
        }

        public override string ToString()
        {
            return NomeProduto;
        }
    }
}
