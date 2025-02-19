using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASKS
{
    public class SA3
    {
        public void sa3()
        {
            ATM a = new ATM();
            List<string> li = new List<string>();
            a.balance = 10000f;
            int option = 0;
            while (option != -1)
            {
                Console.Clear();
                Console.WriteLine("1. Withdraw");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Check balance");
                Console.WriteLine("4. View history");
                Console.Write("Enter you option(-1 to quit): ");
                option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Console.Write("Enter amount to withdraw: $");
                    a.money = float.Parse(Console.ReadLine());
                    store(option, a.money, a.balance,li);
                    a.Withdraw();
                    Console.ReadKey();
                }
                else if (option == 2)
                {
                    Console.Write("Enter amount to deposit: $");
                    a.money = float.Parse(Console.ReadLine());
                    store(option,a.money,a.balance,li);
                    a.Deposit();
                    Console.ReadKey();
                }
                else if (option == 3)
                {
                    a.CheckBalance();
                    Console.ReadKey();
                }
                else if (option == 4)
                {
                    for (int i = 0; i < li.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {li[i]}");
                    }
                    Console.ReadKey();
                }
                else if(option == -1) { }
                else
                {
                    Console.WriteLine("wrong input");
                    Console.ReadKey();
                }
            }
        }
        public void store(int option,float money,float balance,List<string> li)
        {
            Dictionary<int, string> var = new Dictionary<int, string>();
            var[1] = "withdrown";
            var[2] = "deposited";
            var[3] = "from";
            var[4] = "to";
            string record = $"${money} {var[option]} {var[option+2]} bank when balance was ${balance}";
            li.Add(record);
        }
    }
    class ATM
    {
        public float balance;
        public float money;
        public ATM()
        {

        }
        public void Withdraw()
        {
            if (balance >= money) balance -= money;
            else Console.WriteLine("not enough cash in vault");
        }
        public void Deposit()
        {
            balance += money;
        }
        public void CheckBalance()
        {
            Console.WriteLine($"Balance : ${balance}");
        }
    }

}
