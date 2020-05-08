using QrAguas.Models.SellProductEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace QrAguas.Models
{
    class Cart
    {
        public DateTime HoraVenda { get; set; }

        // Composição da classe OrderProduct
        public BindingList<OrderProduct> Produtos { get; set; } = new BindingList<OrderProduct>();


        // Construtores
        public Cart()
        {
        }

        public Cart(DateTime horaVenda)
        {
            HoraVenda = horaVenda;
        }


        // Métodos
        public void AddProduto(OrderProduct produto)
        {
            Produtos.Add(produto);
        }

        public void RemoverProduto(int produto)
        {
            Produtos.RemoveAt(produto);
        }


        public double Total()
        {
            double total = 0.0;

            foreach(var produto in Produtos)
            {
                total += produto.SubTotal();
            }

            return total;
        }

    }
}
