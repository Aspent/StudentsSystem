using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new StudentsRepository();

            var student = new Student("John", "Smith", "IT");
            students.AddStudent(student);
            foreach (var stud in students.Students)
            {
                Console.WriteLine("{0} - {1} {2}", stud.Group, stud.FirstName, stud.LastName);
            }
        }
    }
}
