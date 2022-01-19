using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList _list = new ArrayList();
            _list.Add("Mango");
            _list.Add("Apple");
            _list.Add("Grapes");

            for (int i=0;i< _list.Count;i++)
            {
                Console.WriteLine(_list[i]);
            }
            Console.WriteLine("\n");
            foreach (var item in _list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
            Months _objMonths = new Months();
            foreach (var item in _objMonths)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
