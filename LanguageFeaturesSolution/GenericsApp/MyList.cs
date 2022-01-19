using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsApp
{
    public delegate bool CompareFn<S>(S a, S b);
    public class MyList<T> : IEnumerable<T> where T:IComparable<T>
    {
        T[] _arr;
        int _position;
        int _arraySize;
        public int Position
        {
            get { return _position; }
        }
        public int ArraySize
        {
            get { return _arraySize; }
        }
        public T this[int pos]
        {
            get
            {
                if (pos <_position)
                {
                    return _arr[pos];
                }
                else
                {
                    throw new ArgumentNullException("Position Not Valid");
                }
            }
        }
        public MyList()
        {
             _position=0;
             _arraySize=3;
            _arr = new T[_arraySize];
        }
        public void Add(T value)
        {
            _arr[_position++] = value;
            if (_arraySize == _position)
            {
                _arraySize = _arraySize + 3;
                T[] temp = new T[_arraySize];
                for (int i=0;i<_position;i++)
                {
                    temp[i] = _arr[i];
                }
                _arr = temp;
            }
        }
        public void Sort()
        {
            for (int i = 0; i < _position; i++)
            {
                for (int j = i+1; j < _position; j++)
                {
                    if (_arr[i].CompareTo(_arr[j])>0)
                    {
                        T temp;
                        temp = _arr[i];
                        _arr[i] = _arr[j];
                        _arr[j] = temp;
                    }
                }
            }
        }
        public void GenericSort(CompareFn<T> obj)
        {
            for (int i = 0; i < _position; i++)
            {
                for (int j = i + 1; j < _position; j++)
                {
                    if (obj(_arr[i],_arr[j]))
                    {
                        T temp;
                        temp = _arr[i];
                        _arr[i] = _arr[j];
                        _arr[j] = temp;
                    }
                }
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i=0;i< _position;i++)
            {
                yield return _arr[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
