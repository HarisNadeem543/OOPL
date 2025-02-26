using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace StudentMerit.BL
{
    public class Student
    {
        public string Name;
        public int Age;
        public int Fsc;
        public int Ecat;
        public int Pref;
        public float Merit;
        public List<string> Preferrences = new List<string>();
        public string SelectedDegree;

        public Student(string name ,int age ,int fsc ,int ecat ,int pref ,List<string> preference)
        {
            this.Name = name;
            this.Age = age;
            this.Fsc = fsc;
            this.Ecat = ecat;
            this.Merit = (Fsc/11 + Ecat/4)/2;
            this.Pref = pref;
            foreach(string s in preference)
            {
                this.Preferrences.Add(s);
            }
            this.SelectedDegree = null;
        }
    }
}
