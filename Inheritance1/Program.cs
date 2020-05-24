using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    public class Address
    {
        public string addressLine, city, state;
        public Address(string addressLine, string city, string state)
        {
            this.addressLine = addressLine;
            this.city = city;
            this.state = state;
        }
    }
    public class Animal
    {
        public void eat()
        {
            Console.WriteLine("<Eating>");
        }
    }

    public class Dog : Animal
    {
        public void bark()
        {
            Console.WriteLine("<Barking>");
        }
    }

    public class Shiba : Dog
    {
        public void meme()
        {
            Console.WriteLine("<Meme>");
        }
    }
    public class Employee1
    {
        public int id;
        public string name;
        public Address address;
        
        public Employee1(int id, string name, Address address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }

        public void display()
        {
            Console.WriteLine(id + " " + name + " " + address.addressLine + " " + address.city + " " + address.state);
        }
    }

    public class Employee
    {
        public float salary = 54321f;
    }

        public class Programmer : Employee
    {
        public float bonus = 12345f;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Programmer p1 = new Programmer();

            Console.WriteLine("Salary: " + p1.salary);
            Console.WriteLine("Bonus: " + p1.bonus);

            Dog d1 = new Dog();
            d1.eat();
            d1.bark();

            Shiba s1 = new Shiba();
            s1.eat();
            s1.bark();
            s1.meme();

            Console.WriteLine();

            Address a1 = new Address("123/4", "Grad", "State5");
            Employee1 e11 = new Employee1(1, "A name", a1);
            e11.display();
        }
    }
}
