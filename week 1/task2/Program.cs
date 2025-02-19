using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Xml.XPath;
using System.Collections.Specialized;
using System.Runtime.InteropServices;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\haris\\Desktop\\semester 2\\OOP\\week 1\\task2\\Customers.txt";
            if (File.Exists(path))
            {
                Console.Write("Enter minimum orders : ");
                int o = int.Parse(Console.ReadLine());
                Console.Write("Enter minimum price : ");
                int p = int.Parse(Console.ReadLine());
                StreamReader file = new StreamReader(path);
                string record;
                while((record = file.ReadLine()) != null)
                {
                    customerData c = new customerData();
                    readData(c,record);
                    if (c.check(o,p))
                    {
                        c.display();
                    }
                }

            }
            else
            {
                Console.WriteLine("Path not valid.");
            }

        }
        static void readData(customerData c,string record)
        {
            List<string> li = new List<string>();
            string word = "";
            for(int x = 0; x<record.Length; x++)
            {
                if (record[x] == '[') x++;
                if (record[x] != ' ' && record[x] != ',' && record[x] != ']')
                {
                    word += record[x];
                }
                else
                {
                    li.Add(word);
                    word = "";
                }
            }
            string name = li[0];
            int orders = int.Parse(li[1]);
            int[] prices = new int[orders];
            for(int i=2 ; i<li.Count; i++)
            {
                prices[i - 2] = Convert.ToInt32(li[i]);
            }
            c.Name = name;
            c.Orders = orders;
            c.Prices = prices;
        }
    }
    class customerData
    {
        public string Name;
        public int Orders;
        public int[] Prices;
        public customerData()
        {
           
        }
        public bool check(int o,int p)
        {
            int count = 0;
            for(int i=0; i<Orders; i++)
            {
                if (Prices[i] >= p) count++;
            }
            return (count >= o);
        }
        public void display()
        {
            Console.WriteLine($"'{Name}''");
        }
    }
}
