using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TASKS
{
    public class C2
    {
        public void c2()
        {
            List<Product> list = new List<Product>();
            while (true)
            {
                int option = Menu();
                if (option == 1)
                {
                    Console.Write("Enter ID: ");
                    string id = Console.ReadLine();
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Price: ");
                    int price = int.Parse(Console.ReadLine());
                    Console.Write("Enter Category: ");
                    string category = Console.ReadLine();
                    Console.Write("Enter Brand Name: ");
                    string brand = Console.ReadLine();
                    Console.Write("Enter Country: ");
                    string country = Console.ReadLine();
                    Product p = new Product(id, name, price, category, brand, country);
                    list.Add(p);
                }
                else if (option == 2)
                {
                    Console.WriteLine($"ID\tName\tPrice\tCategory\tBrand\tCountry");
                    foreach(Product p0 in list)
                    {
                        p0.display();
                    }
                }
                else if (option == 3)
                {
                    int sum = 0;
                    foreach (Product p0 in list)
                    {
                        sum += p0.Price;
                    }
                    Console.WriteLine($"Company net worth : ${sum}");
                }
                else if (option == 4) { }
                else
                {
                    Console.WriteLine("invalid input");
                }
                Console.ReadKey();
            }
        }
        public int Menu()
        {
            Console.Clear();
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Show Product");
            Console.WriteLine("3. Total Worth");
            Console.WriteLine("4. Exit");
            Console.Write("Enter option: ");
            return int.Parse(Console.ReadLine());
        }
    }
    class Product
    {
        public string ID;
        public string Name;
        public int Price;
        public string Category;
        public string Brand;
        public string Country;
        public Product() { }
        public Product(string id, string name, int price, string category, string brand, string country)
        {
            ID = id;
            Name = name;
            Price = price;
            Category = category;
            Brand = brand;
            Country = country;
        }
        public void display()
        {
            Console.WriteLine($"{ID}\t{Name}\t${Price}\t{Category}\t{Brand}\t{Country}");
        }
    }
}
