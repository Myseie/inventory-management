using inventory_management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        InventoryManager manager = new InventoryManager();

        bool exit = false;


        while (!exit)
        {
            Console.WriteLine("\nVälj ett alternativ :");
            Console.WriteLine("1.Lägg till en produkt ");
            Console.WriteLine("2.Uppdatera lagersaldo");
            Console.WriteLine("3.Visa alla produkter");
            Console.WriteLine("4.Sök efter en produkt");
            Console.WriteLine("5.Ta bort en produkt");
            Console.WriteLine("6.Avsluta");

            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    Console.Write("Ange produktnummer: ");
                    int productNumber = int.Parse(Console.ReadLine());

                    Console.Write("Ange produktnamn: ");
                    string name = Console.ReadLine();

                    Console.Write("Ange lagersaldo:");
                    int stock = int.Parse(Console.ReadLine());

                    Product newProduct = new Product(productNumber, name, stock);
                    manager.AddProduct(newProduct);

                    break;

                case "2":
                    Console.Write("Ange produktnummer för att uppdatera lagersaldo :");
                    int numberToUpdate = int.Parse(Console.ReadLine());

                    Console.Write("Ange nytt lagersaldo:");
                    int newStock = int.Parse(Console.ReadLine());

                    manager.UpdateStock(numberToUpdate, newStock);

                    break;

                case "3":
                    manager.ShowProducts();
                    
                    break;

                case "4":
                    Console.Write("Vill du söka efter (1) namn eller (2) produktnummer? : ");
                    string searchOption = Console.ReadLine();

                    if (searchOption == "1")
                    {
                        Console.Write("Ange produktnamn att söka efter :");
                        string searchTerm = Console.ReadLine();
                        manager.SearchProduct(searchTerm);

                    }
                    else if (searchOption == "2") 
                    {
                        Console.Write("Ange produktnummer du vill söka efter : ");
                        int numberToSearch = int.Parse(Console.ReadLine());
                        manager.SearchProduct(numberToSearch);

                    }
                    break;

                case "5":
                    Console.Write("Ange produktnummer på produkten du vill ta bort : ");
                    int numberToRemove = int.Parse(Console.ReadLine());
                    manager.RemoveStock(numberToRemove);
                    break;

                case "6":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Ogiltligt val försök igen");
                    break;
            }
        }

    }
}