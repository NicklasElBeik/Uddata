using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uddata.Models
{
    sealed class Student : Person
    //Made sealed so class cannot be inhertied from.
    {
        public int Warnings { get; set; }
        //public List<Student> Students { get; set; }

        public List<Student> StudentList = new List<Student>(); 
    }
}
