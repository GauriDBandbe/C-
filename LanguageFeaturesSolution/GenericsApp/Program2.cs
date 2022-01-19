using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsApp
{
    class Program2
    {
        static void Main2(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Vowels :A");
            list.Add("Vowels :E");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Dictionary<string, int> _obj = new Dictionary<string, int>();
            _obj.Add("Mango",40);
            _obj.Add("Apple",30);
            _obj.Add("Orange",10);
            Console.WriteLine("\n");
            Console.WriteLine("------------------For getting value of apple----------------------");
            Console.WriteLine(_obj["Apple"]);
            Console.WriteLine("------------------For getting list of fruits----------------------");
            foreach (var item in _obj.Keys)
                Console.WriteLine($"{ item}\t");
            Console.WriteLine("\n");
            Console.WriteLine("------------------For getting list of Qty----------------------");
            foreach (var item in _obj.Values)
                Console.WriteLine($"{ item}\t");
            Console.WriteLine("\n");
            //Stack<string> numbers = new Stack<string>();
            //numbers.Push("one");
            //numbers.Push("two");
            //numbers.Push("three");
            //numbers.Push("four");
            //numbers.Push("five");

            //// A stack can be enumerated without disturbing its contents.
            //foreach (string number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine("\nPopping '{0}'", numbers.Pop());
            //Console.WriteLine("Peek at next item to destack: {0}",
            //    numbers.Peek());
            //Console.WriteLine("Popping '{0}'", numbers.Pop());

            //// Create a copy of the stack, using the ToArray method and the
            //// constructor that accepts an IEnumerable<T>.
            //Stack<string> stack2 = new Stack<string>(numbers.ToArray());

            //Console.WriteLine("\nContents of the first copy:");
            //foreach (string number in stack2)
            //{
            //    Console.WriteLine(number);
            //}

            //// Create an array twice the size of the stack and copy the
            //// elements of the stack, starting at the middle of the
            //// array.
            //string[] array2 = new string[numbers.Count * 2];
            //numbers.CopyTo(array2, numbers.Count);

            //// Create a second stack, using the constructor that accepts an
            //// IEnumerable(Of T).
            //Stack<string> stack3 = new Stack<string>(array2);

            //Console.WriteLine("\nContents of the second copy, with duplicates and nulls:");
            //foreach (string number in stack3)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine("\nstack2.Contains(\"four\") = {0}",
            //    stack2.Contains("four"));

            //Console.WriteLine("\nstack2.Clear()");
            //stack2.Clear();
            //Console.WriteLine("\nstack2.Count = {0}", stack2.Count);
            Console.Read();
        }
    }
}
