using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Ram";
            Console.WriteLine(name.GetType());

            var age = 34;
            Console.WriteLine(age.GetType());

            //error
           // var address ;
            //address = "Pune";

            dynamic name1 = "Shyam";
            Console.WriteLine(name1);

            dynamic address;
            address = "Pune";
            Console.WriteLine(address);

            Console.Read();
        }
    }
}
