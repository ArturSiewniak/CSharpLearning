using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Multithreading1
{
    public class MyThread
    { 
        public static void Thread1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void Thread2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(123);
            }
        }

        public static void Thread3()
        {
            Console.WriteLine("Task #1");
        }

        public static void Thread4()
        {
            Console.WriteLine("Task #2");
        }

        public void Thread5()
        {
            Thread t = Thread.CurrentThread;
            Console.WriteLine(t.Name + " is running");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Thread t = Thread.CurrentThread;
            //t.Name = "MainThread";
            //Console.WriteLine(t.Name);

            Console.WriteLine("Start of Main");

            Thread t1 = new Thread(new ThreadStart(MyThread.Thread1));
            Thread t2 = new Thread(new ThreadStart(MyThread.Thread1));
            t1.Start();
            t2.Start();

            Console.WriteLine();

            MyThread mt = new MyThread();
            Thread mt3 = new Thread(new ThreadStart(mt.Thread2));
            Thread mt4 = new Thread(new ThreadStart(mt.Thread2));
            mt3.Start();
            mt4.Start();

            Console.WriteLine();

            Thread t5 = new Thread(new ThreadStart(MyThread.Thread3));
            Thread t6 = new Thread(new ThreadStart(MyThread.Thread4));
            t5.Start();
            t6.Start();

            Console.WriteLine();

            try
            {
                t1.Abort();
                t2.Abort();
            }
            catch(ThreadAbortException e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine();

            Thread mt7 = new Thread(new ThreadStart(mt.Thread2));
            Thread mt8 = new Thread(new ThreadStart(mt.Thread2));
            Thread mt9 = new Thread(new ThreadStart(mt.Thread2));
            mt7.Start();
            mt7.Join();
            mt8.Start();
            mt9.Start();

            Console.WriteLine();

            Thread mt10 = new Thread(new ThreadStart(mt.Thread5));
            Thread mt11 = new Thread(new ThreadStart(mt.Thread5));
            Thread mt12 = new Thread(new ThreadStart(mt.Thread5));
            mt10.Name = "T10";
            mt11.Name = "T11";
            mt12.Name = "T12";

            mt12.Priority = ThreadPriority.Highest;
            mt11.Priority = ThreadPriority.Normal;
            mt10.Priority = ThreadPriority.Lowest;

            mt10.Start();
            mt11.Start();
            mt12.Start();

            Console.WriteLine();

            Console.WriteLine("End of main");

        }
    }
}