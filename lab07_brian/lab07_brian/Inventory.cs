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

        public void Remove(T item)
        {
            T[] buffer = new T[count - 1];
            int buffercount = 0;

            foreach (T i in items)
            {
                if (i != null)
                {
                    if (!i.Equals(item))
                    {
                        buffer[buffercount] = i;
                        buffercount++;
                    }
                }
            }
            items = buffer;
            count--;
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