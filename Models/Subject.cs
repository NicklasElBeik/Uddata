using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uddata.Models
{
    public enum SubjectType {Dan, Mat, Eng, Fys}
    class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public SubjectType Type { get; set; }
        public override string ToString()
        {
            return "ID: " + SubjectId + " Subject: " + SubjectName + " Enum: " + Type;
        }
        public int Grade { get; set; }
    }
}
