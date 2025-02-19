using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2
{
    internal class Product
    {
        public string Name;
        public string Category;
        public float Price;
        public int Stock;
        public int MinStock;
        public static List<Product> products = new List<Product>();
        public Product()
        {
            this.Name = "";
            this.Category = "";
            this.Price = 0f;
            this.Stock = 0;
            this.MinStock = 0;
        }
        public Product(string name)
        {
            this.Name = name;
        }
        public Product(string name, string cat)
        {
            this.Name = name;
            this.Category = cat;
        }
        public Product(string name, string cat, float price)
        {
            this.Name = name;
            this.Category = cat;
            this.Price = price;
        }
        public Product(string name, string cat, float price, int stock)
        {
            this.Name = name;
            this.Category = cat;
            this.Price = price;
            this.Stock = stock;
        }
        public Product(string name, string cat, float price, int stock, int min)
        {
            this.Name = name;
            this.Category = cat;
            this.Price = price;
            this.Stock = stock;
            this.MinStock = min;
        }
        public Product(Product P)
        {
            this.Name = P.Name;
            this.Category = P.Category;
            this.Price = P.Price;
            this.Stock = P.Stock;
            this.MinStock = P.MinStock;
        }
        public static Product CheckMax()
        {
            Product P0 = new Product(Product.products[0]);
            foreach (Product P in Product.products)
            {
                if (P.Price > P0.Price)
                {
                    P0 = P;
                }
            }
            return P0;
        }
        public static void DisplayToBeOrdered()
        {
            Console.WriteLine("Name\t\tCategories\t\tPrice\tStock\tMinimum Stock");
            foreach (Product P in Product.products)
            {
                if (P.Stock < P.MinStock)
                {
                    P.Display();
                    Console.WriteLine("");
                }
            }
        }
        public static void DisplayTax()
        {
            Console.WriteLine("Name\t\tCategories\t\tPrice\tStock\tMinimum Stock\tTax");
            foreach (Product P in Product.products)
            {
                float Tax;
                P.Display();
                if (P.Category.ToUpper() == "GROCERY")
                {
                    Tax = P.Price * 0.1f;
                }
                else if (P.Category.ToUpper() == "FRESH FRUIT")
                {
                    Tax = P.Price * 0.05f;
                }
                else
                {
                    Tax = P.Price * 0.15f;
                }
                Console.WriteLine($"\t\t{Tax}");
            }
        }
        public static void DisplayAll()
        {
            Console.WriteLine("Name\t\tCategories\t\tPrice\tStock\tMinimum Stock");
            foreach (Product P in Product.products)
            {
                P.Display();
                Console.WriteLine("");
            }
        }
        public void Display()
        {
            Console.Write($"{this.Name}\t\t{this.Category}\t\t{this.Price}\t{this.Stock}\t{this.MinStock}");
        }
    }
}
