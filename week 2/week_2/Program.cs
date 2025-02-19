using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
    class Student
    {
        public string sname;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float aggregate;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.sname = "bappa jani";
            student.matricMarks = 1078f;
            student.fscMarks = 1129f;
            student.ecatMarks = 333f;
            student.aggregate = 93.34f;
            Console.WriteLine(student.aggregate);
        }
    }
}

