using System;
using System.Collections;
using System.Collections.Generic;

namespace lab07_brian
{
    class Inventory<T> : IEnumerable
    {
        T[] items = new T[9];
        int count = 0;

        public void Add(T item)
        {
            if (count == items.Length)
            {
                Array.Resize(ref items, items.Length * 2);
            }
            items[count] = item;
            count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}