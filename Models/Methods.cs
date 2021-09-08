using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uddata.Models
{
    class Methods
    {
        public void SubjectListMethod()
        {
            List<Subject> subjects = new List<Subject>();
            subjects.Add(new Subject() { SubjectName = "Dansk", SubjectId = 1, Type = SubjectType.Dan });
            subjects.Add(new Subject() { SubjectName = "MateMatik", SubjectId = 2, Type = SubjectType.Mat });
            subjects.Add(new Subject() { SubjectName = "Engelsk", SubjectId = 3, Type = SubjectType.Eng });
            subjects.Add(new Subject() { SubjectName = "Fysik", SubjectId = 4, Type = SubjectType.Fys });

            foreach (Subject subject in subjects)
            {
                Console.WriteLine(subject);
            }
        }
    }
}
