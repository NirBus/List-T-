using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HomeTask4
{
    class Fruits : ICollection
    {
        public int Id;
        public string Vitamins;

        public static int count = 1;

        public int Count => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public Fruits(string vitamins)
        {
            Id = count;
            Vitamins = vitamins;
            count++;
        }
        public override string ToString()
        {
            return $"Vitamins: {Vitamins}";
        }
    }
}