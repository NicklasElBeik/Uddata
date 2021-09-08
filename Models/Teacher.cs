using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uddata.Models
{
    sealed class Teacher : Person
    //Made sealed so class cannot be inhertied from.
    {
        public bool CoffeeClub { get; set; }
        public List<Teacher> Teachers { get; set; }

        public List<Subject> Subject = new List<Subject>();
    }
}
