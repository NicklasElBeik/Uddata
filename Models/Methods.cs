using System;
using Uddata.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uddata.Models
{
    class Methods
    {
        Subject subject = new Subject();
        public Subject AddSubject()
        {
            Subject d = new Subject()
            {
                SubjectId = 1,
                SubjectName = "Dansk",
                Type = SubjectType.Dan
            };
            subject.subjects.Add(d);       

            Subject m = new Subject()
            {
                SubjectId = 2,
                SubjectName = "Matematik",
                Type = SubjectType.Mat
            };

            subject.subjects.Add(m);
            Subject e = new Subject()
            {
                SubjectId = 3,
                SubjectName = "Engelsk",
                Type = SubjectType.Eng
            };
            subject.subjects.Add(e);

            Subject f = new Subject()
            {
                SubjectId = 4,
                SubjectName = "Fysik",
                Type = SubjectType.Fys
            };
            subject.subjects.Add(f);
            return subject;
        }
    }
}
