namespace QrAguas.Models.SellProductEntities
{
    class OrderProduct
    {
        // Composição da classe Product
        public int CodigoProduto { get; set; }
        public Product Produto { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        


        // Construtores
        public OrderProduct()
        {
        }

        public OrderProduct(int codigoProduto, Product produto, int quantidade, double preco)
        {
            CodigoProduto = codigoProduto;
            Produto = produto;
            Quantidade = quantidade;
            Preco = preco;
        }




        // Métodos
        public double SubTotal()
        {
            return Preco * Quantidade;
        }
    }
}
