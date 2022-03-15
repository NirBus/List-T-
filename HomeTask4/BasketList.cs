using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HomeTask4
{
    class BasketList
    {
        private Fruits[] arr;
        public int Count
        {
            get
            {
                return arr.Length;
            }
        }
        public BasketList()
        {
            arr = new Fruits[0];

        }
        public void Add(Fruits fruit)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = fruit;
        }
        public Fruits[] GetArray()
        {
            return arr;
        }
    }
}
