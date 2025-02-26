using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentMerit.DL;
using StudentMerit.BL;

namespace StudentMerit.UI
{
    public class StudentUI
    {
        public static Student AddStudent()
        {
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Fsc Marks:");
            int fsc = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ecat Marks:");
            int ecat = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter How Many Preferences:");
            int pref = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Degree Preferences:");
            List<string> temp = new List<string>();
            for(int i=0 ; i<pref; i++)
            {
                string var = Console.ReadLine();
                temp.Add(var);
            }
            Student s = new Student(name,age,fsc,ecat,pref,temp);
            return s;
        }
    }
}
