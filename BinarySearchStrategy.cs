using Lab5_4.Interfaces;
using System;

namespace Lab5_4
{
    public class BinarySearchStrategy<T> : ISearchStrategy<T> where T : IComparable<T>
    {
        public T FindMax(T[] data)
        {
            if (data.Length == 0)
                throw new InvalidOperationException("Array is empty.");

            Array.Sort(data);
            return data[data.Length - 1];
        }

        public T FindMin(T[] data)
        {
            if (data.Length == 0)
                throw new InvalidOperationException("Array is empty.");

            Array.Sort(data);
            return data[0];
        }
    }
}
