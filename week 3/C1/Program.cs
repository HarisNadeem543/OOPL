using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace C1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClockType c = new ClockType();
            DateTime currentTime = DateTime.Now;
            c.DisplayElapsedTime(currentTime);
            c.DisplayRemainingTime(currentTime);
            ClockType c1 = new ClockType();
            c1.H = 12;
            c1.M = 12;
            c1.S = 12;
            ClockType c2 = new ClockType();
            c2.H = 4;
            c2.M = 20;
            c2.S = 5;
            c1.Difference(c2);
        }
    }
    class ClockType
    {
        public int H;
        public int M;
        public int S;
        public ClockType()
        {
            H = 0;
            M = 0;
            S = 0;
        }
        public ClockType(int h)
        {
            this.H = h;
        }
        public ClockType(int h, int m)
        {
            this.H = h;
            this.M = m;
        }
        public ClockType(int h, int m, int s)
        {
            this.H = h;
            this.M = m;
            this.S = s;
        }
        public void DisplayElapsedTime(DateTime now)
        {
            this.H = now.Hour;
            this.M = now.Minute;
            this.S = now.Second;
            Console.Write("Elapsed time : ");
            this.Display();
        }
        public void DisplayRemainingTime(DateTime now)
        {
            int timeInSec = now.Hour * 3600 + now.Minute * 60 + now.Second;
            int remainInSec = 24 * 3600 - timeInSec;
            this.S = remainInSec % 60;
            this.M = remainInSec/60%60;
            this.H = remainInSec/3600%60;
            Console.Write("Elapsed time : ");
            this.Display();
        }
        public void Difference(ClockType c)
        {
            int one = this.H*3600 + this.M*60 + this.S;
            int two = c.H * 3600 + c.M * 60 + c.S;
            int diff = Math.Max(one, two) - Math.Min(one, two);
            Console.WriteLine($"{diff / 3600 % 60}:{diff / 60 % 60}:{diff % 60}");
        }
        public void Display()
        {
            Console.WriteLine($"{this.H}:{this.M}:{this.S}");
        }

    }
}
