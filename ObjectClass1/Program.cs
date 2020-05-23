using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClass1
{
    public enum Days
    {
        SUNDAY,
        MONDAY,
        TUESDAY,
        WEDNESDAY,
        THURSDAY,
        FRIDAY,
        SATURDAY
    };

    public enum Season
    {
        WINTER = 10,
        SPRING,
        SUMMER,
        FALL
    };

    public struct Rectangle
    {
        public int width, height;

        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
        }

        public void areaOfRectangle()
        {
            Console.WriteLine("Area of the rectangle (" + width + ", " + height + ") is: " + (width * height));
        }
    }

    public static class MyMath
    {
        public static float PI = 3.14f;
        public static int cube(int n)
        {
            return n * n * n;
        }
    }
    public class Account
    {
        public int accno;
        public String name;
        public static float rateOfInterest;
        public static int count = 0;

        public Account(int accno, String name)
        {
            this.accno = accno;
            this.name = name;
            count++;
        }

        static Account()
        {
            rateOfInterest = 6.66f;
        }

        public void display()
        {
            Console.WriteLine(accno + " " + name + " " + rateOfInterest);
        }
    }
    public class EmployeeWC
    {
        public int id;
        public String name;
        public float salary;

        public EmployeeWC(int id, String name, float salary)
        {
            Console.WriteLine("Constructor invoked");
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        ~EmployeeWC()
        {
            Console.WriteLine("Destructor invoked");
        }

        public void display()
        {
            Console.WriteLine(id + " " + name + " " + salary);
        }
    }

    public class Employee
    {
        public int m_id;
        public String m_name;
        public float m_salary;

        public void insert(int id, String name, float salary)
        {
            m_id = id;
            m_name = name;
            m_salary = salary;
        }

        public void display()
        {
            Console.WriteLine(m_id + " " + m_name + " " + m_salary);
        }
    }

    public class Student
    {
        public int m_id;
        public String m_name;

        public void insert(int i, String n)
        {
            m_id = i;
            m_name = n;
        }

        public void display()
        {
            Console.WriteLine(m_id + " " + m_name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student();
            s1.insert(1, "Alibaba");
            s2.insert(2, "Benjamin");
            s1.display();
            s2.display();

            Employee e1 = new Employee();
            Employee e2 = new Employee();
            e1.insert(1, "Ali", 100.5f);
            e2.insert(2, "Bali", 210.5f);
            e1.display();
            e2.display();

            EmployeeWC e3 = new EmployeeWC(3, "Cali", 321f);
            EmployeeWC e4 = new EmployeeWC(4, "Dali", 234.5f);
            e3.display();
            e4.display();

            Account a1 = new Account(1, "Acc");
            Account a2 = new Account(2, "Bacc");
            a1.display();
            a2.display();
            Console.WriteLine("Total Account objects: " + Account.count);

            Console.WriteLine("The value of pi is: " + MyMath.PI);
            Console.WriteLine("Cube of 3 is: " + MyMath.cube(3));

            Rectangle r1 = new Rectangle();
            r1.width = 4;
            r1.height = 5;
            Console.WriteLine("Area of the rectangle (4, 5) is: " + (r1.width * r1.height));

            Rectangle r2 = new Rectangle(5,6);
            r2.areaOfRectangle();

            int x = (int)Season.WINTER;
            int y = (int)Season.SUMMER;
            Console.WriteLine("WINTER = {0}", x);
            Console.WriteLine("SUMMER = {0}", y);

            int dx = (int)Days.SUNDAY;
            int dy = (int)Days.MONDAY;
            int dz = (int)Days.SATURDAY;
            Console.WriteLine("SUNDAY = {0}", dx);
            Console.WriteLine("MONDAY = {0}", dy);
            Console.WriteLine("SATURDAY = {0}", dz);

            foreach(string s in Enum.GetNames(typeof(Days)))
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();

            foreach(Days d in Enum.GetValues(typeof(Days)))
            {
                Console.Write(d + " ");
            }
        }
    }
}
