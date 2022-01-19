using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp
{
   public class Months : IEnumerable,IEnumerator
   {
        string[] _mths = new string[] { "January", "February", "March", "April", "May" };
        int _currentPosition = -1;
        public Months()
        {

        }
        //Using Lambda Expression
        public object Current => _mths[_currentPosition];

        //Using Anonymous method
        //public object Current
        //{
        //    get
        //    {
        //        return _mths[_currentPosition];
        //    }
        //}
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (_currentPosition+1<_mths.Length)
            {
                ++_currentPosition;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _currentPosition=-1;
        }
    }
}
