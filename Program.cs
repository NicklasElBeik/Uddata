using System;
using Uddata.Models;
using System.Collections.Generic;

namespace Uddata
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods methods = new Methods();
            Teacher teacher = new Teacher();
            Student student = new Student();
            methods.AddSubject();
            Console.WriteLine("######## Vekommen til Uddata++ ########\n\n");

            Teacher bjarne = new Teacher();
            bjarne.Id = 1; bjarne.Name = "Bjarne"; bjarne.CoffeeClub = true; bjarne.SubjectName = "Dansk og Engelsk"; 
            Teacher lars = new Teacher();
            lars.Id = 2; lars.Name = "Lars"; lars.CoffeeClub = false; lars.SubjectName = "Fysik";
            teacher.teachers.Add(bjarne);
            teacher.teachers.Add(lars);

            Student sigurd = new Student();
            sigurd.Id = 1; sigurd.Name = "Sigurd"; sigurd.SubjectName = "Dansk"; sigurd.Grade = 10; sigurd.Warnings = 1;
            student.students.Add(sigurd);

            Console.WriteLine("Lærere:\n");

            foreach (var Teacher in teacher.teachers)
            {
                Console.WriteLine(Teacher + "\n");
            }

            Console.WriteLine("\nElever:\n");

            foreach (var Student in student.students)
            {
                Console.WriteLine(Student + "\n");
            }
            

            Console.ReadKey();
        }
    }
}
