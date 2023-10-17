using Lab5_4.Interfaces;
using System;

namespace Lab5_4
{
    public class LinearSearchStrategy<T> : ISearchStrategy<T> where T : IComparable<T>
    {
        public T FindMax(T[] data)
        {
            if (data.Length == 0)
                throw new InvalidOperationException("Array is empty.");

            T max = data[0];
            for (int i = 1; i < data.Length; i++)
            {
                if (data[i].CompareTo(max) > 0)
                {
                    max = data[i];
                }
            }
            return max;
        }

        public T FindMin(T[] data)
        {
            if (data.Length == 0)
                throw new InvalidOperationException("Array is empty.");

            T min = data[0];
            for (int i = 1; i < data.Length; i++)
            {
                if (data[i].CompareTo(min) < 0)
                {
                    min = data[i];
                }
            }
            return min;
        }
    }
}
