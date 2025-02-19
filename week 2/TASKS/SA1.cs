using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASKS
{
    public class SA1
    {
        public void sa1()
        {
            Transaction T1 = new Transaction();
            T1.ID = "1";
            T1.ProductName = "garam aande";
            T1.Amount = 100;
            T1.Time = "12:12:12";
            T1.Date = "2024-01-01";
            Transaction T2 = new Transaction(T1);
            Console.WriteLine("Original object before change: ");
            T1.display();
            Console.WriteLine("Copied object before change: ");
            T2.display();
            T1.ProductName = "Thande aande";
            T1.Amount = 12;
            T2.ProductName = "Thande roti";
            T2.Amount = 15;
            Console.WriteLine("Original object after change: ");
            T1.display();
            Console.WriteLine("Copied object after change: ");
            T2.display();
        }
        class Transaction
        {
            public string ID;
            public string ProductName;
            public int Amount;
            public string Time;
            public string Date;
            public Transaction()
            {

            }
            public Transaction(Transaction T)
            {
                ID = T.ID;
                ProductName = T.ProductName;
                Amount = T.Amount;
                Time = T.Time;
                Date = T.Date;
            }
            public void display()
            {
                Console.WriteLine($"{ID}-{ProductName}-{Amount}-{Time}-{Date}");
            }
        }
    }
}
