using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASKS
{
    public class SA2
    {
        public void sa2()
        {
            int option = 0;
            while (option != -1)
            {
                Console.Clear();
                calculator C = new calculator();
                Console.Write("Enter number 1: ");
                float n1;
                C.n1 = int.Parse(Console.ReadLine());
                Console.Write("Enter number 2: ");
                float n2;
                C.n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("\n1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.Write("Enter option(-1 to quit) : ");
                option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    float sum = C.Add();
                    Console.WriteLine($"Sum : {sum}");
                }
                else if (option == 2)
                {
                    float minus = C.Subtract();
                    Console.WriteLine($"Subtract : {minus}");
                }
                else if (option == 3)
                {
                    float prod = C.Multiply();
                    Console.WriteLine($"Product : {prod}");
                }
                else if (option == 4)
                {
                    if (C.n2 == 0) Console.WriteLine("Division not possible.");
                    else Console.Write($"Quotient : {C.Divide()}");
                }
                else
                {
                    Console.WriteLine("wrong option.");
                }
                Console.ReadKey();
            }
        }
    }
    class calculator
    {
        public float n1;
        public float n2;
        public calculator()
        {

        }
        public float Add()
        {
            return (n1 + n2);
        }
        public float Subtract()
        {
            return (n1 - n2);
        }
        public float Multiply()
        {
            return (n1 * n2);
        }
        public float Divide()
        {
            return (n1 / n2);
        }
    }

}
