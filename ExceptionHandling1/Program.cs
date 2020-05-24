using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling1
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(String message) : base (message)
        {

        }
    }
    class Program
    {
        static void validate(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Must be older than 18 years of age");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                int a = 10, b = 0, c = a / b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Finally block");
            }
            Console.WriteLine("Rest of the code");

            try
            {
                validate(15);
            }
            catch (InvalidAgeException e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Rest of the code again");

            //checked   //unchecked {} by default
            //{
                int val = int.MaxValue;
                Console.WriteLine(val + 2);

            //}

            try
            {
                int[] arr = new int[5];
                arr[10] = 25;
            }
            catch (SystemException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
