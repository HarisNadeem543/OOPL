using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TASKS
{
    public class C1
    {
        public void c1()
        {
            List<Student> li = new List<Student>();
            while (true)
            {
                int option = menu();
                if(option == 1) 
                {
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter matric marks(out of 1100): ");
                    float matric = int.Parse(Console.ReadLine());
                    Console.Write("Enter fsc marks(out of 570): ");
                    float fsc = int.Parse(Console.ReadLine());
                    Console.Write("Enter ecat marks(out of 400): ");
                    float ecat = int.Parse(Console.ReadLine());
                    Student s = new Student(name, matric, fsc, ecat);
                    li.Add(s);
                }
                else if (option == 2)
                {
                    Console.WriteLine($"Name \t- Matric \t- Fsc \t- Ecat");
                    foreach (Student st in li)
                    {
                        Console.WriteLine($"{st.Name} \t- {st.Matric} \t\t- {st.Fsc} \t- {st.Ecat}");
                    }
                }
                else if (option == 3)
                {
                    foreach(Student st in li)
                    {
                        Console.WriteLine($"Aggregate if {st.Name} : {st.AggCalculate()}");
                    }
                }
                else if (option == 4)
                {
                    Dictionary<float, string> map = new Dictionary<float, string>();
                    foreach(Student st in li)
                    {
                        float a = st.AggCalculate();
                        map[a] = st.Name;
                    }
                    var extra = map.OrderByDescending(k => k.Key);
                    int count = 0;
                    foreach (var kvp in extra)
                    {
                        Console.WriteLine($"{count+1}. {kvp.Value} : {kvp.Key}");
                        count++;
                        if (count == 3) break;
                    }
                }
                else if (option == 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong Input");
                }
                Console.ReadKey();
            }
        }
        public int menu()
        {
            Console.Clear();
            Console.WriteLine("1. Add student");
            Console.WriteLine("2. Show students");
            Console.WriteLine("3. Calculate aggregate");
            Console.WriteLine("4. Top student");
            Console.WriteLine("5. Exit");
            Console.Write("Your option : ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
    }
    class Student 
    {
        public string Name;
        public float Matric;
        public float Fsc;
        public float Ecat;
        public float Agg;
        public Student() { }
        public Student(string name, float matric, float fsc, float ecat)
        {
            Name = name;
            Matric = matric;
            Fsc = fsc;
            Ecat = ecat;
        }
        public float AggCalculate()
        {
            float ans = (Matric / 1100 * 25) + (Fsc / 570 * 45) + (Ecat / 400 * 30);
            return ans;
        }

    }
}
