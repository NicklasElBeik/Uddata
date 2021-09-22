using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uddata.Models
{
    public enum SubjectType {Dan, Mat, Eng, Fys}
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public SubjectType Type { get; set; }
        public List<Subject> subjects = new List<Subject>();
        public int? Grade { get; set; }
        public override string ToString()
        {
            return $"Subject ID: {SubjectId}    Subject Name: {SubjectName}\nSubject Type: {Type}        Grade: {Grade}\n\n";
        }
    }
}
