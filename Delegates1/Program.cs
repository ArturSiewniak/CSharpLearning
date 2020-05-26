using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate int Calculator(int n);

namespace Delegates1
{
    class Program
    {
        static int number = 100;
        public static int add(int n)
        {
            number = number + n;
            return number;
        }

        public static int mul(int n)
        {
            number = number * n;
            return number;
        }

        public static int getNumber()
        {
            return number;
        }

        static void Main(string[] args)
        {
            Calculator c1 = new Calculator(add);
            Calculator c2 = new Calculator(mul);
            c1(20);
            Console.WriteLine("C1 delegate: " + getNumber());
            c2(2);
            Console.WriteLine("C2 delegate: " + getNumber());
        }
    }
}
