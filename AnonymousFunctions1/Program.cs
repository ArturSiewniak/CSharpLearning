using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousFunctions1
{
    class Program
    {
        delegate int Square(int num);
        public delegate void AnonymousFun();
        static void Main(string[] args)
        {
            Square GetSquare = x => x * x;
            int i = GetSquare(5);
            Console.WriteLine("Square: " + i);

            AnonymousFun fun = delegate ()
            {
                Console.WriteLine("This is anonymous function");
            };
            fun();
        }
    }
}
