using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Student
    {
        public int No { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public string ClassNo { get; set; }

        public Class Class { get; set; }
    }
}
