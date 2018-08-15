using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var teachers = new List<Teacher>();
            teachers.Add(new Teacher("Bob", "Smith", "13579", "Bongard"));
            teachers.Add(new Teacher("Ian", "Smith", "15498", "Bongard"));
            teachers.Add(new Teacher("Dan", "Smith", "65489", "Bongard"));
            teachers.Add(new Teacher("Dylan", "Smith", "45789", "Bongard"));
            teachers.Add(new Teacher("Troy", "Smith", "32457", "Bongard"));

            var students = new List<Student>();
            students.Add(new Student("Carl", "Smith", 15689));
            students.Add(new Student("Simon", "Smith", 24578));
            students.Add(new Student("Jacob", "Smith", 35489));
            students.Add(new Student("Seb", "Smith", 64578));
            students.Add(new Student("Connor", "Smith", 65984));

            Console.WriteLine("*******TEACHERS*******\n");
            foreach(var x in teachers)
            {
                Console.WriteLine(x.GetTeachDeets());
            }

            Console.WriteLine("\n*******STUDENTS*******\n");
            foreach (var x in students)
            {
                Console.WriteLine(x.GetStdtDeets());
            }
        }
    }
}
