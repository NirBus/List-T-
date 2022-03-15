using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask4
{
    class CustomList<T> 
    {
        private T[] arr;

        public int Count
        {
            get
            {
                return arr.Length;
            }
        }

        public CustomList()
        {
            arr = new T[0];
        }

        public void Add(T item)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = item;
        }

        public T[] GetArray()
        {
            return arr;
        }
    }
}

