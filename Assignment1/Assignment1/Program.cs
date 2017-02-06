using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student();
            std1.FirstName = "Bharath";
            std1.LastName = "Sontam";

            Student std2 = new Student();
            std2.FirstName = "Sarath";
            std2.LastName = "Sontam";

            Console.WriteLine("Studnet 1 fullname: {0}", std1.GetFullName());
            Console.WriteLine("Studnet 2 fullname: {0}", std2.GetFullName());
            Console.WriteLine("No.of students: {0}", Student.Count);

            Console.ReadKey();
        }
    }

    public class Student
    {
        public static int Count = 0;

        public Student()
        {
            Count++;
        }

        public string FirstName;
        public string LastName;

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
