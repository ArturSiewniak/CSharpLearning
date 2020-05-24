using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties1
{
    public class Employee
    {
        private string name;
        private static int counter;

        public Employee()
        {
            counter++;
        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value + ")))))";
            }
        }

        public static int Counter
        {
            get
            {
                return counter;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();
            Employee e3 = new Employee();
            Employee e4 = new Employee();
            e1.Name = "Nice name :";
            Console.WriteLine("Employee name: " + e1.Name);
            Console.WriteLine("Number of employees: " + Employee.Counter);
        }
    }
}
