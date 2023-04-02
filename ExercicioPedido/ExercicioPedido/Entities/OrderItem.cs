using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPedido.Entities
{
    internal class OrderItem
    {
        public double Price { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(double price, int quantity, Product product)
        {
            Price = price;
            Quantity = quantity;
            Product = product;
        }

        public double SubTotal()
        { 
            return Price * Quantity; 
        }

        public override string ToString()
        {
            return Product.name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
