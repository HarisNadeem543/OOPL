using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentMerit.BL;

namespace StudentMerit.DL
{
    public class StudentStore
    {
        public List<Student> StudentsList = new List<Student>();

        public void Add(Student s)
        {
            StudentsList.Add(s);
        }
        public List<Student> GetList()
        {
            return StudentsList;
        }
    }
}
