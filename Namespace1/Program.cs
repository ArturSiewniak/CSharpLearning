using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using First;
using Second;

namespace First
{
    public class Hello
    {
        public void sayHello()
        {
            Console.WriteLine("First namespace Hello!");
        }
    }
}

namespace Second
{
    public class Hello
    {
        public void sayHello()
        {
            Console.WriteLine("Second namespace Hello!");
        }
    }

    public class Welcome
    {
        public void sayWelcome()
        {
            Console.WriteLine("Second namespace Welcome!");
        }
    }
}

namespace Namespace1
{
    class Student
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
    class PrivateTest
    {
        private string name = "Private name";
        private void Msg(string msg)
        {
            Console.WriteLine("Hi, " + msg);
        }
    }
    class ProtectedInternalTest
    {
        protected internal string name = "Protected internal name";
        protected internal void Msg(string msg)
        {
            Console.WriteLine("Hi, " + msg);
        }
    }
    class InternalTest
    {
        internal string name = "Internal name";
        internal void Msg(string msg)
        {
            Console.WriteLine("Hi, " + msg);
        }
    }
    class ProtectedTest
    {
        protected string name = "Protected name";
        protected void Msg(string msg)
        {
            Console.WriteLine("Hi, " + msg);
        }
    }
    class PublicTest
    {
        public string name = "Nice name";
        public void Msg(string msg)
        {
            Console.WriteLine("Hi, " + msg);
        }
    }
    class Program : ProtectedTest
    {
        private string name = "Inside private name";
        private void Msg(string msg)
        {
            Console.WriteLine("Hi, " + msg);
        }
        static void Main(string[] args)
        {
            First.Hello h1 = new First.Hello();
            Second.Hello h2 = new Second.Hello();
            h1.sayHello();
            h2.sayHello();

            First.Hello h3 = new First.Hello();
            Welcome w3 = new Welcome();
            h3.sayHello();
            w3.sayWelcome();

            Console.WriteLine();

            PublicTest publicTest = new PublicTest();
            Console.WriteLine("Hello " + publicTest.name);
            publicTest.Msg("Nicer name");

            ProtectedTest protectedTest = new ProtectedTest();
            //Console.WriteLine("Hello " + protectedTest.name); //Inaccessible due to protected
            //protectedTest.Msg("More protected name lol");     //Inaccessible due to protected

            Program program = new Program();
            Console.WriteLine("Hello " + program.name);
            program.Msg("Even more protected name xd");

            InternalTest internalTest = new InternalTest();
            Console.WriteLine("Hello " + internalTest.name);
            internalTest.Msg("More internal name");

            ProtectedInternalTest protectedInternalTest = new ProtectedInternalTest();
            Console.WriteLine("Hello " + protectedInternalTest.name);
            protectedInternalTest.Msg("More protected internal name");

            PrivateTest privateTest = new PrivateTest();
            //Console.WriteLine("Hello " + privateTest.name); //Inaccessible due to private
            //privateTest.Msg("More protected name");         //Inaccessible due to private

            Console.WriteLine("Hello " + program.name);
            program.Msg("More inside private name");

            Student student = new Student();
            student.ID = "1";
            student.Name = "Ali Baba";
            student.Email = "Ali@Baba.com";

            Console.WriteLine("ID: " + student.ID);
            Console.WriteLine("Name: " + student.Name);
            Console.WriteLine("Email: " + student.Email);
        }
    }
}
