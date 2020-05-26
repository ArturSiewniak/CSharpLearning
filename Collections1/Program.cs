using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections1
{
    class Program
    {
        static void Main(string[] args)
        {
            var namesList = new List<string>() { "Ali", "Bali", "Cali", "Dali" };
            
            foreach (var name in namesList)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            var namesHashSet = new HashSet<string>() { "Ali", "Bali", "Cali", "Dali", "Ali" };  //Ali at the end won't be added because it's not unique

            foreach (var name in namesHashSet)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            var namesSortedSet = new SortedSet<string>() { "Bali", "Dali", "Cali", "Ali" };  //Ali at the end won't be added because it's not unique

            foreach (var name in namesSortedSet)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            var namesStack = new Stack<string>();
            namesStack.Push("Ali");
            namesStack.Push("Bali");
            namesStack.Push("Cali");
            namesStack.Push("Dali");

            foreach (var name in namesStack)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Peek element: " + namesStack.Peek());
            Console.WriteLine("Pop element: " + namesStack.Pop());
            Console.WriteLine("Peek element: " + namesStack.Peek());

            Console.WriteLine();

            var namesQueue = new Queue<string>();
            namesQueue.Enqueue("Ali");
            namesQueue.Enqueue("Bali");
            namesQueue.Enqueue("Cali");
            namesQueue.Enqueue("Dali");

            foreach (var name in namesQueue)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Peek element: " + namesQueue.Peek());
            Console.WriteLine("Dequeue element: " + namesQueue.Dequeue());
            Console.WriteLine("Peek element: " + namesQueue.Peek());

            Console.WriteLine();

            var namesLinkedList = new LinkedList<string>();
            namesLinkedList.AddLast("Ali");
            namesLinkedList.AddLast("Bali");
            namesLinkedList.AddLast("Cali");
            namesLinkedList.AddFirst("Dali");

            LinkedListNode<String> node = namesLinkedList.Find("Cali");
            namesLinkedList.AddBefore(node, "Eali");
            namesLinkedList.AddAfter(node, "Fali");

            foreach(var name in namesLinkedList)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            Dictionary<string, string> namesDictionary = new Dictionary<string, string>();
            namesDictionary.Add("1", "Ali");
            namesDictionary.Add("2", "Bali");
            namesDictionary.Add("3", "Cali");
            namesDictionary.Add("4", "Dali");

            foreach(KeyValuePair<string, string> kv in namesDictionary)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }

            Console.WriteLine();

            SortedDictionary<string, string> namesSortedDictionary = new SortedDictionary<string, string>();
            namesSortedDictionary.Add("4", "Dali");
            namesSortedDictionary.Add("3", "Cali");
            namesSortedDictionary.Add("2", "Bali");
            namesSortedDictionary.Add("1", "Ali");

            foreach (KeyValuePair<string, string> kv in namesSortedDictionary)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }

            Console.WriteLine();

            SortedList<string, string> namesSortedList = new SortedList<string, string>();  //Basically the same as sorted dictionary but takes up less memory, dictionary is faster however
            namesSortedList.Add("4", "Dali");
            namesSortedList.Add("3", "Cali");
            namesSortedList.Add("2", "Bali");
            namesSortedList.Add("1", "Ali");

            foreach (KeyValuePair<string, string> kv in namesSortedList)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }

            Console.WriteLine();
        }
    }
}
