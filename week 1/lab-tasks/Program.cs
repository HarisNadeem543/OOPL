using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace lab_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter age(1-77): ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter price of toy(1-10000): ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter price of washing machine(1-40): ");
            int p = int.Parse(Console.ReadLine());
            int sum = 0;
            int var = 10;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 1)
                {
                    sum += p;
                }
                else
                {
                    sum += var - 1;
                    var += 10;
                }
            }
            if (sum >= x)
            {
                Console.WriteLine($"Yes! {sum - x}");
            }
            else
            {
                Console.WriteLine($"No! {x - sum}");
            }
        }
    }
}
