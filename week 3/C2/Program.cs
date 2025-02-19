using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool main = true;
            while (main)
            {
                int option = Menu();
                if (option == 1)
                {
                    Product P = new Product();
                    Console.WriteLine("Name:");
                    P.Name = Console.ReadLine();
                    Console.WriteLine("Category:");
                    P.Category = Console.ReadLine();
                    Console.WriteLine("Price:");
                    P.Price = float.Parse(Console.ReadLine());
                    Console.WriteLine("Stock Quantity:");
                    P.Stock = int.Parse(Console.ReadLine());
                    Console.WriteLine("Minimum Stock Quantity:");
                    P.MinStock = int.Parse(Console.ReadLine());
                    Product.products.Add(P);
                }
                else if (option == 2)
                {
                    Product.DisplayAll();
                }
                else if (option == 3)
                {
                    Product P = Product.CheckMax();
                    P.Display();
                    Console.WriteLine("");
                }
                else if (option == 4)
                {
                    Product.DisplayTax();
                }
                else if (option == 5)
                {
                    Product.DisplayToBeOrdered();
                }
                Console.ReadKey();
            }
        }
        public static int Menu()
        {
            Console.Clear();
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. View All Products");
            Console.WriteLine("3. Find Product with the Highest Unit Price");
            Console.WriteLine("4. View Sales Tax of All Products.");
            Console.WriteLine("5. Products to be Ordered.");
            Console.Write("Your option: ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        
    }
}
