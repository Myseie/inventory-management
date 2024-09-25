using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_management
{
    class Product
    {
        public int ProductNumber { get; set; }

        public string Name { get; set; }

        public int Stock { get; set; }


        public Product(int productNumber, string name, int stock)
        {
            ProductNumber = productNumber;

            Name = name;

            Stock = stock;
        }

        public override string ToString()
        {
            return $"Produktnummer: {ProductNumber}, Namn {Name}, Lagersaldo {Stock}";
        }
    }
}
