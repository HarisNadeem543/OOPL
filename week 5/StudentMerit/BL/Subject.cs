using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentMerit.BL
{
    public class Subject
    {
        public int Code;
        public string Name;
        public int CH;
        public int FeeCH;

        public Subject(int code, string name, int ch, int feeCH)
        {
            this.Code = code;
            this.Name = name;
            this.CH = ch;
            this.FeeCH = feeCH;
        }
    }
}
