using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPedido.Entities
{
    internal class Product
    {
        public string name { get; set; }
        public double price { get; set; }

        public Product()
        {
            
        }

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
