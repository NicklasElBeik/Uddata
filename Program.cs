using System;
using Uddata.Models;
using Uddata.Views;
using System.Collections.Generic;

namespace Uddata
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Teacher teacher = new Teacher();
            Subject subject = new Subject();
            Methods methods= new Methods();
            AddStudent addStudent = new AddStudent();
            Console.WriteLine("Hello World!");
            //methods.SubjectListMethod();
            addStudent.GetInput();
            

            //student.StudentList.Add(new Student() { PersonId = 1, PersonName = "Lars", SubjectId = 1, SubjectName = "Dansk", Grade = 12 });
            //Console.WriteLine(student.StudentList);
            Console.ReadKey();
        }
    }
}
