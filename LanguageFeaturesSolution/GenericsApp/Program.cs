using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsApp
{
    class Program
    {
        static void Main1(string[] args)
        {
            int a = 30;
            int b = 40;
            float c = 33.33f;
            float d = 44.44f;
            //Console.WriteLine("a={0} ,b={1}", a, b);
            //Swap(ref a,ref b);
            //Console.WriteLine("a={0} ,b={1}", a, b);

            //Console.WriteLine("c={0} ,d={1}", c, d);
            //Swap(ref c, ref d);
            //Console.WriteLine("c={0} ,d={1}", c, d);

            Console.WriteLine("a={0} ,b={1}", a, b);
            GenericSwap(ref a, ref b);
            Console.WriteLine("a={0} ,b={1}", a, b);

            Console.WriteLine("c={0} ,d={1}", c, d);
            GenericSwap(ref c, ref d);
            Console.WriteLine("c={0} ,d={1}", c, d);
            Console.Read();
        }
        static void Swap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
        static void Swap(ref float x, ref float y)
        {
            float temp;
            temp = x;
            x = y;
            y = temp;
        }
        static void Swap(ref object x, ref object y)
        {
            object temp;
            temp = x;
            x = y;
            y = temp;
        }
        static void GenericSwap<T>(ref T x,ref T y)
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
        }
    }
    public class PgmMyList<T>
    {
        T _data;
        public PgmMyList(T data)
        {

        }
    }
}
