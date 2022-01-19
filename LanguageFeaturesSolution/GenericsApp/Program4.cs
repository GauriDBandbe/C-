using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsApp
{
   public class Program4
    {
        

        static void Main(string[] args)
        {
            MyList<Customer> _list = new MyList<Customer>();
            _list.Add(new Customer(101, "Ram", "Mumbai", 24));
            _list.Add(new Customer(102, "Shyam", "Pune", 56));
            _list.Add(new Customer(103, "Hari", "Ooty", 42));
            _list.Add(new Customer(104, "Ash", "Surat", 37));

            Console.WriteLine("---------------For sorting--------------------------");
            foreach (var item in _list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");

            _list.Sort();
            foreach (var item in _list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");

            Console.WriteLine("---------------For Generic sorting--------------------------");
            foreach (var item in _list)
            {
                Console.WriteLine(item);
            }

            CompareFn<Customer> _delobj1 = delegate (Customer a, Customer b)
            {
                if (a.Age > b.Age)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

           
            _list.GenericSort(_delobj1);
            Console.WriteLine("\n");
            foreach (var item in _list)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
