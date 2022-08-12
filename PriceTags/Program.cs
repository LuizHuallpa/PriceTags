using System;
using System.Collections.Generic;
using PriceTags.Entities;

namespace PriceTags
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());


                switch (ch)
                {
                    case 'c':
                        products.Add(new Product(name, price));
                        break;
                    case 'u':
                        Console.Write("Manufacture date (MM/DD/YYYY): ");
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        products.Add(new UsedProduct(name, price, date));
                        break;
                    case 'i':
                        Console.Write("Importation fee: ");
                        double fee = double.Parse(Console.ReadLine());
                        products.Add(new ImportedProduct(name, price, fee));
                        break;
                    default:
                        Console.WriteLine("Wrong char!!");
                        break;

                }

            }

            foreach (Product p in products)
            {
                Console.WriteLine(p.PriceList());
            }


        }
    }
}
