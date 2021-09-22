using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uddata.Models
{
    sealed class Teacher : BaseClass
    {
        public bool CoffeeClub { get; set; }
        public override string ToString()
        {
            if (CoffeeClub) return $"Lærer {Name} har ID: {Id} og underviser i {SubjectName}. {Name} er medlem af kaffeklubben";
            else return $"Lærer {Name} har ID: {Id} og underviser i {SubjectName}. {Name} er ikke medlem af kaffeklubben";
        }
        public List<Teacher> teachers = new List<Teacher>();
    }
}
