using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_management
{
    class InventoryManager
    {
        private List<Product> products = new List<Product>();


        public void AddProduct(Product product)
        {
            products.Add(product);
            Console.WriteLine($"Produkten : '{product.Name}' har lagts till ");
        }

        public void UpdateStock(int productNumber, int newStock)
        {
            Product productToUpdate = products.Find(p => p.ProductNumber == productNumber);

            if (productToUpdate != null)
            {
                productToUpdate.Stock = newStock;
                Console.WriteLine($"Lagersaldot för produkt '{productToUpdate.Name}' har uppdaterats");

            }
            else
            {
                Console.WriteLine($"Ingen produkt med produktnummer :{productNumber} hittades ");
            }

        }
        public void RemoveStock (int productNumber)
        {
            Product productToRemove = products.Find(p =>p.ProductNumber == productNumber);

            if (productToRemove != null)
            {
                products.Remove(productToRemove);
                Console.WriteLine($"Produkten {productToRemove} har tagits bort.");
            }
            else
            {
                Console.WriteLine($"Ingen produkt på nummer {productNumber} hittades.");
            }
        }

        public void ShowProducts()
        {
            if ( products.Count == 0 )
            {
                Console.WriteLine("Finns inga produkter på lager");
            }
            else
            {
                Console.WriteLine("Produkter i lager :");
                foreach (Product product in products)
                {
                    Console.WriteLine(product);
                }
            }
        }
        public void SearchProduct(string searchTerm)
        {
            List<Product> foundProducts = products.FindAll(p => p.Name.ToLower().Contains(searchTerm));

            if (foundProducts.Count > 0)
            {
                Console.WriteLine("Produkter hittade: ");
                foreach (Product product in foundProducts)
                {
                    Console.WriteLine(product);
                }
            }
            else
            {
                Console.WriteLine($"Ingen produkt med namnet '{searchTerm} hittades. ");
            }
        }
        public void SearchProduct(int productNumber)
        {
            Product foundProduct = products.Find(p => p.ProductNumber == productNumber);
            if (foundProduct != null)
            {
                Console.WriteLine($"Produkt hittad: {foundProduct}");
            }
            else
            {
                Console.WriteLine($"Ingen produkt med produktnummer {productNumber} hittades");
            }
        }
    }
}
