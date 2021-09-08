using System;
using Uddata.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uddata.Views
{
    class AddStudent
    {
        public Student GetInput()
        {
            Student student = new Student();
            Console.WriteLine("==Add new student==");
            Console.Write("Name: ");
            student.PersonName = Console.ReadLine();
            foreach (var Type in Enum.GetValues(typeof(SubjectType)))
            {
                Console.WriteLine((int)Type + " " + Type.ToString());
            }
            Console.Write("Subject: ");
            SubjectType S;
            Enum.TryParse(Console.ReadLine(), out S);
            while (!Enum.TryParse(Console.ReadLine(), out S));
            { Console.WriteLine("Wrong input. Try Again."); }
            Console.WriteLine(S);
            student.Type = S;


            return student;
        }
    }   
}
