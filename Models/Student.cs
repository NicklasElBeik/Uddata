using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uddata.Models
{
    sealed class Student : BaseClass
    {
        public int Warnings { get; set; }
        public override string ToString()
        {
            return $"Elev {Name} har ID: {Id} og bliver undervist i {SubjectName}, hvor han har fået {Grade}. {Name} har {Warnings} advarsler";
        }
        public List<Student> students = new List<Student>();
    }
}
