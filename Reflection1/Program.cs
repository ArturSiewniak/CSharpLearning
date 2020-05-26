using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Type type = a.GetType();
            Console.WriteLine(type);

            Type type1 = typeof(System.String);
            Console.WriteLine(type1.Assembly);
            Console.WriteLine(type1.FullName);
            Console.WriteLine(type1.BaseType);
            Console.WriteLine(type1.IsClass);
            Console.WriteLine(type1.IsEnum);
            Console.WriteLine(type1.IsInterface);

            Console.WriteLine();

            Console.WriteLine("Constructors of {0} type: ", type1);
            ConstructorInfo[] ci = type1.GetConstructors(BindingFlags.Public | BindingFlags.Instance);
            foreach(ConstructorInfo c in ci)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine();

            Console.WriteLine("Methods of {0} type: ", type1);
            MethodInfo[] mi = type1.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            foreach (MethodInfo m in mi)
            {
                Console.WriteLine(m);
            }

            Console.WriteLine();

            Console.WriteLine("Fields of {0} type: ", type1);
            FieldInfo[] fi = type1.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic);
            foreach (FieldInfo f in fi)
            {
                Console.WriteLine(f);
            }
        }
    }
}
