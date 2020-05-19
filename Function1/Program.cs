using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function1
{
    class Program
    {
        public void Show()
        {
            Console.WriteLine("A non parametrized function");
        }

        public void ShowString(string msg)
        {
            Console.WriteLine("A parametrized void function: " + msg);
        }

        public string ShowMessage(string msg)
        {
            Console.WriteLine("A parametrizzed function with return value(string)");
            return msg;
        }

        public void PassByValue(int val)
        {
            val *= val;
            Console.WriteLine("Val inside the function: " + val);
        }

        public void PassByReference(ref int val)
        {
            val *= val;
            Console.WriteLine("ValRef inside the function: " + val);
        }

        public void ShowOutSingle(out int val)
        {
            int lol = 5;
            val = lol;
            val *= val;
        }

        public void ShowOutMulti(out int val1, out int val2)
        {
            int lol = 5;
            val1 = lol;
            val2 = 20;

            val1 *= val1;
            val2 *= val2;
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Show();
            program.ShowString("lol");
            string message = program.ShowMessage("lmao");
            Console.WriteLine("Using returned value from previous function: " + message);

            int val = 50;
            Console.WriteLine("Val before calling the function: " + val);
            program.PassByValue(val);
            Console.WriteLine("Val after calling the function: " + val);

            int valRef = 50;
            Console.WriteLine("ValRef before calling the function: " + valRef);
            program.PassByReference(ref valRef);
            Console.WriteLine("ValRef after calling the function: " + valRef);

            int valOutSingle = 55;
            Console.WriteLine("ValOutSingle before passing out: " + valOutSingle);
            program.ShowOutSingle(out valOutSingle);
            Console.WriteLine("ValOutSingle after passing out: " + valOutSingle);

            int valOutMulti1 = 66;
            int valOutMulti2 = 77;
            Console.WriteLine("ValOutMulti1 & 2 before passing out: " + valOutMulti1 + " " + valOutMulti2);
            program.ShowOutMulti(out valOutMulti1, out valOutMulti2);
            Console.WriteLine("ValOutMulti1 & 2 after passing out: " + valOutMulti1 + " " + valOutMulti2);
        }


    }
}
