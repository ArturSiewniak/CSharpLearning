using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1
{
    class Program
    {
        static void printArray(int[] arr)
        {
            Console.WriteLine("Printing array elements: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static void printMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Minimum element is: " + min);
        }

        static void printMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Maximum element is: " + max);
        }

        public void ShowParams(params object[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }

        static void Main(string[] args)
        {
            int[] arr = new int[5];
            arr[0] = 10;
            arr[2] = 20;
            arr[4] = 30;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            int[] arr1 = { 10, 20, 30, 40, 50 };


            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }

            foreach (int i in arr1)
            {
                Console.WriteLine(i);
            }

            int[] arr2 = { 1, 2, 3, 4, 5 };
            int[] arr3 = { 6, 7, 8 };
            printArray(arr2);
            printArray(arr3);
            printMin(arr2);
            printMin(arr3);
            printMax(arr2);
            printMax(arr3);

            int[,] arr2D = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr2D[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[][] arrJag = new int[3][]
            {
                new int[] { 1, 2, 3, 4, 5 },
                new int[] { 6, 7, 8, 9 },
                new int[] { 10, 11, 12 }
            };

            for (int i = 0; i < arrJag.Length; i++)
            {
                for (int j = 0; j < arrJag[i].Length; j++)
                {
                    Console.Write(arrJag[i][j] + " ");
                }
                Console.WriteLine();
            }

            Program program = new Program();
            program.ShowParams("lol", 2.2, 1, 'x');

            Console.WriteLine("Argument length: " + args.Length);
            Console.WriteLine("Supplied arguments are: ");
            foreach(Object obj in args)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
