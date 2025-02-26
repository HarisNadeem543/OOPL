using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMerit.BL
{
    public class Degree
    {
        public string Name;
        public int Duration;
        public int Seats;
        public int SubjectNumber;
        public List<Subject> SubjectList = new List<Subject>();

        public Degree(string name, int duration, int seats, int subjectNumber, List<Subject> subjectList)
        {
            Name = name;
            Duration = duration;
            Seats = seats;
            SubjectNumber = subjectNumber;
            foreach(Subject s in subjectList)
            {
                SubjectList.Add(s);
            }
        }
    }
}
