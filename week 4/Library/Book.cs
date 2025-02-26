using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Book
    {
        public string Title;
        public int CountAuthors;
        public List<string> Author = new List<string>();
        public int ISBN;
        public string Publisher;
        public int Price;
        public int Stock;
        public int Year;
        public static List<Book> Books = new List<Book>();

        public static void DisplayBooks()
        {
            foreach (Book B in Book.Books)
            {
                Console.Write($"{B.Title}");
                foreach (String A in B.Author)
                {
                    Console.Write($" - {A}");
                }
                Console.WriteLine($"{B.ISBN} - {B.Publisher} - {B.Price} - {B.Stock} - {B.Year}");
            }
        }
    }
}
