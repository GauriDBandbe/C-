using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApp
{
    public delegate void CalculatorHandler(int a,int b);
   public class Calculator
    {
        public static void Add(int x, int y)
        {
            Console.WriteLine("Addition is: "+ (x+y));
        }
        public static void Subtract(int x, int y)
        {
            Console.WriteLine("Substraction is: " + (x - y));
        }
        public static void Multiply(int x, int y)
        {
            Console.WriteLine("Multiplication is: " + (x * y));
        }
        public static void Devide(int x, int y)
        {
            Console.WriteLine("Dividation is: " + (x / y));
        }
    }
}
