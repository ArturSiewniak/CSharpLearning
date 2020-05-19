using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStatement1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            
            if (num % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd number");
            }

            Console.WriteLine("Enter a grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());

            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Wrong grade");
            }
            else if (grade >= 0 && grade < 50)
            {
                Console.WriteLine("Exam not passed");
            }
            else
            {
                Console.WriteLine("Exam passed");
            }

            Console.WriteLine("Enter a number(for switch): ");
            int forSwitch = Convert.ToInt32(Console.ReadLine());

            switch(forSwitch)
            {
                case 10: 
                    Console.WriteLine("It's 10");
                    break;
                case 20: 
                    Console.WriteLine("It's 20");
                    break;
                case 30: 
                    Console.WriteLine("It's 30");
                    break;
                default: 
                    Console.WriteLine("It's not 10, 20 or 30");
                    break;
            }

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(i + " " + j);
                }
            }

            //for (;;) {} infinite for loop

            int forWhile = 1;
            while(forWhile <= 10)
            {
                Console.WriteLine(forWhile);
                forWhile++;
            }

            int forNestedWhile1 = 1;
            while (forNestedWhile1 <= 3)
            {
                int forNestedWhile2 = 1;
                while (forNestedWhile2 <= 3)
                {
                    Console.WriteLine(forNestedWhile1 + " " + forNestedWhile2);
                    forNestedWhile2++;
                }

                forNestedWhile1++;
            }

            //while (true) {} infinite while loop

            int forDoWhile = 1;
            do
            {
                Console.WriteLine(forDoWhile);
                forDoWhile++;
            } while (forDoWhile <= 10);

            int forNestedDoWhile1 = 1;
            do
            {
                int forNestedDoWhile2 = 1;

                do
                {
                    Console.WriteLine(forNestedDoWhile1 + " " + forNestedDoWhile2);
                    forNestedDoWhile2++;
                } while (forNestedDoWhile2 <= 3);

                forNestedDoWhile1++;
            } while (forNestedDoWhile1 <= 3);

            //do {} while(true) infinite do while loop

            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    break;
                }

                Console.WriteLine(i);
            }

            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    if(i == 2 && j == 2)
                    {
                        break;
                    }

                    Console.WriteLine(i + " " + j);
                }
            }

            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }

                Console.WriteLine(i);
            }

            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    if (i == 2 && j == 2)
                    {
                        continue;
                    }

                    Console.WriteLine(i + " " + j);
                }
            }

        ineligible:
            Console.WriteLine("You aren't eligible to vote");

            int age = 18;
            if (age < 18)
            {
                goto ineligible;
            }
            else
            {
                Console.WriteLine("You are eligible to vote");
            }
            
        }
    }
}
