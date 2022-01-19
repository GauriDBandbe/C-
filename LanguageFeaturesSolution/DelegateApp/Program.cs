using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorHandler _objCH = new CalculatorHandler(Calculator.Add);
            _objCH += new CalculatorHandler(Calculator.Subtract);
            _objCH += new CalculatorHandler(Calculator.Multiply);
            _objCH += new CalculatorHandler(Calculator.Devide);
            _objCH(50, 25);

            Account[] _accArray =
            {
                new Account(101,"Ram",30000),
                new Account(102,"Sonam",120000),
                new Account(103,"Hari",20000),
                new Account(104,"Ash",90000),
                new Account(105,"Sunil",70000),
            };

            //standard
            //// CompareFunc _del = new CompareFunc(CompareByBalance);

            ////Anonymous method
            //CompareFunc _del = delegate (Object obj1, Object obj2)
            //  {
            //      if ((obj1 as Account).Balance > (obj2 as Account).Balance)
            //      {
            //          return true;
            //      }
            //      else
            //      {
            //          return false;
            //      }
            //  };

            //Lambda
            //CompareFunc _del =  (Object obj1, Object obj2)=>
            //{
            //    if ((obj1 as Account).Balance > (obj2 as Account).Balance)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //};

            //for (int i = 0; i < _accArray.Length; i++)
            //{
            //    Console.WriteLine(_accArray[i]);
            //}

            //Console.WriteLine("\n");


            //SortClass.Sort(_accArray, _del);
            SortClass.Sort(_accArray, (Object obj1, Object obj2) =>
            {
                if ((obj1 as Account).Balance > (obj2 as Account).Balance)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });
            for (int i = 0; i < _accArray.Length; i++)
            {
                Console.WriteLine(_accArray[i]);
            }

            Console.WriteLine("\n");

            Account _acc = new Account(101, "Ram", 30000);
            // _acc.BalanceChange += new BalanceChangeHandler(_acc_BalanceChange);
            //_acc.BalanceChange +=   _acc_BalanceChange;
            //Anonymous method
            _acc.BalanceChange += delegate (int aid, string hn, decimal bal, decimal change)
             {
                 Console.WriteLine("{0},{1},{2},{3}", aid, hn, bal, change);
             };


            Console.WriteLine(_acc);
            _acc.Deposite(8000);
            Console.WriteLine(_acc);
            Console.Read();
        }

        private static void _acc_BalanceChange(int aid, string hn, decimal bal, decimal change)
        {
           Console.WriteLine("{0},{1},{2},{3}",aid,hn,bal,change );
        }
        //public static bool CompareByBalance(object obj1,object obj2)
        //{
        //    if ((obj1 as Account).Balance >(obj2 as Account).Balance)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
