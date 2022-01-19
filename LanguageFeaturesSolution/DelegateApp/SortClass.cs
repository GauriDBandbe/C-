using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApp
{
    public delegate bool CompareFunc(Object Obj1, Object Obj2);
   public class SortClass
    {
        public static void Sort(object[] objArr, CompareFunc LhsAndRhs )
        {
            for(int i=0;i< objArr.Length-1; i++)
            {
                if (LhsAndRhs(objArr[i],objArr[i+1]))
                {
                    object t = objArr[i];
                    objArr[i] = objArr[i + 1];
                    objArr[i + 1] = t;
                    i = -1;
                }
            }
        }
    }
}
