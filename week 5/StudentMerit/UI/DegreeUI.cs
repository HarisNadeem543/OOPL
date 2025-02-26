using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentMerit.BL;

namespace StudentMerit.UI
{
    internal class DegreeUI
    {
        SubjectUI subjectUI = new SubjectUI();
        public Degree AddDegree()
        {
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Duration:");
            int duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Seats:");
            int seats = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter how many subjects:");
            int subj = int.Parse(Console.ReadLine());
            List<Subject> temp = new List<Subject>();
            for(int i=0; i<subj; i++)
            {
                Subject s = subjectUI.Add();
                temp.Add(s);
            }
            Degree d = new Degree(name,duration,seats,subj,temp);
            return d;
        }
    }
}
