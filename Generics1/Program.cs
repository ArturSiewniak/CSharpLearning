using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics1
{
    class GenericClass<T>
    {
        public GenericClass(T msg)
        {
            Console.WriteLine(msg);
        }

        
    }

    class GenericClass1
    {
        public void Show<T>(T msg)
        {
            Console.WriteLine(msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<string> genstring = new GenericClass<string>("This is a generic class");
            GenericClass<int> genInt = new GenericClass<int>(123);
            GenericClass<char> genChar = new GenericClass<char>('a');

            GenericClass1 genC = new GenericClass1();
            genC.Show("This is a string");
            genC.Show(321);
            genC.Show('A');
        }
    }
}
