namespace QrAguas.Models.SellProductEntities
{
    class OrderProduct
    {
        // Composição da classe Product
        public Product Produto { get; set; }

        public int Quantidade { get; set; }
        public double Preco { get; set; }

        


        // Construtores
        public OrderProduct()
        {
        }

        public OrderProduct(int quantidade, double preco, Product product)
        {
            Quantidade = quantidade;
            Preco = preco;
            Produto = product;
        }


        // Métodos
        public double SubTotal()
        {
            return Preco * Quantidade;
        }
    }
}
