using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsApp
{
    public class Program3
    {
        static void Main3(string[] args)
        {
            MyList<int> _objMyList = new MyList<int>();
            _objMyList.Add(34);
            _objMyList.Add(35);
            _objMyList.Add(23);
            _objMyList.Add(90);

            for (int i=0;i<_objMyList.Position;i++)
            {
                Console.WriteLine(_objMyList[i]);
            }
            //Console.WriteLine("\n");
            //MyList<string> _objMyList2 = new MyList<string>();
            //_objMyList2.Add("Cat");
            //_objMyList2.Add("Dog");
            //_objMyList2.Add("Lion");
            //_objMyList2.Add("Tiger");
            //_objMyList2.Add("Cow");


            //for (int i = 0; i < _objMyList2.Position; i++)
            //{
            //    Console.WriteLine(_objMyList2[i]);
            //}

            //Console.WriteLine("---------------By Using Interface--------------------------");
            //foreach (var item in _objMyList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");
            //Console.WriteLine("---------------After sorting--------------------------");
            //_objMyList.Sort();
            //foreach (var item in _objMyList)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("\n");
            Console.WriteLine("---------------For Generic sorting--------------------------");
            CompareFn<int> _delobj = delegate (int a, int b)
            {
               if (a > b)
               {
                   return true;
               }
               else
               {
                   return false;
               }
            };
            foreach (var item in _objMyList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
            _objMyList.GenericSort(_delobj);
            foreach (var item in _objMyList)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
