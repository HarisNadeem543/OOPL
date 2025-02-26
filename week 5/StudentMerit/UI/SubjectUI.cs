using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentMerit.BL;

namespace StudentMerit.UI
{
    public class SubjectUI
    {
        public Subject Add()
        {
            Console.WriteLine("Enter Subject Code:");
            int code = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Subject Name:");
            string sname = Console.ReadLine();
            Console.WriteLine("Enter Subject CH:");
            int CH = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Subject Fee:");
            int fee = int.Parse(Console.ReadLine());
            Subject s = new Subject(code, sname, CH, fee);
            return s;
        } 
    }
}
