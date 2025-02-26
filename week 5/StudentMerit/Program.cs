using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentMerit.DL;
using StudentMerit.UI;
using StudentMerit.BL;

namespace StudentMerit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentStore studentStore = new StudentStore();
            StudentUI studentUI = new StudentUI();
            DegreeUI degreeUI = new DegreeUI();
            while(true)
            {
                int option = MainMenu();
                if (option == 1)
                {
                    Student s = StudentUI.AddStudent();
                    studentStore.Add(s);
                }
                else if (option == 2)
                {
                    Degree d = degreeUI.AddDegree();
                }
                else if (option == 3){}
                else if (option == 4)
                {
                    List<Student> temp = studentStore.GetList();
                    Console.WriteLine($"Name\tAge\tFsc\tEcat\tMerit");
                    foreach (Student s in temp)
                    {
                        Console.WriteLine($"{s.Name}\t{s.Age}\t{s.Fsc}\t{s.Ecat}\t{s.Merit}");
                    }
                }
                else if (option == 5){}
                else if (option == 6){}
                else if (option == 7){}
                else if (option == 8){}
                else
                {

                }
                Console.WriteLine("Press Any key to Continue...");
                Console.ReadKey();
            }
        }
        public static int MainMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Degree Program");
            Console.WriteLine("3. Generate Merit");
            Console.WriteLine("4. View Registered Student");
            Console.WriteLine("5. View Student in a Degree Program");
            Console.WriteLine("6. Calculate Fee for all registered Student");
            Console.WriteLine("7. Exit");
            Console.Write("Enter Option : ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
