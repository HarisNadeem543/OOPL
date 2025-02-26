using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool main = true;
            while (main)
            {
                string option = Menu();
                if (option == "1")
                {
                    Book b = new Book();
                    Console.WriteLine("Enter Name:");
                    b.Title = Console.ReadLine();
                    Console.WriteLine("Enter Number of authors:");
                    b.CountAuthors = int.Parse(Console.ReadLine());
                    for(int i=0; i<b.CountAuthors; i++)
                    {
                        Console.WriteLine($"Enter Author {i+1}:");
                        string temp = Console.ReadLine();
                        b.Author.Add(temp);
                    }
                    Console.WriteLine("Enter ISBN:");
                    b.ISBN = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter publisher:");
                    b.Publisher = Console.ReadLine();
                    Console.WriteLine("Enter price:");
                    b.Price = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Stock:");
                    b.Stock = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Year:");
                    b.Year = int.Parse(Console.ReadLine());
                    Book.Books.Add(b);
                }
                else if (option == "2")
                {
                    Book.DisplayBooks();
                }
                else if (option == "3") { }
                else if (option == "4") { }
                else
                {
                    Console.WriteLine("Invalid input");
                }
                Console.ReadKey();
            }
        }
        public static string Menu()
        {
            Console.Clear();
            Console.WriteLine("1. Add Book.");
            Console.WriteLine("2. View Book.");
            Console.WriteLine("3. Update Book.");
            Console.WriteLine("4. delete Book.");
            Console.Write("Your Option : ");
            string option = Console.ReadLine();
            return option;
        }
    }
}
