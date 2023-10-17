using Lab5_4.Interfaces;
using System;

namespace Lab5_4
{
    public class InsertionSortStrategy<T> : ISortStrategy<T> where T : IComparable<T>
    {
        public T[] Sort(T[] data)
        {
            for (int i = 1; i < data.Length; i++)
            {
                T key = data[i];
                int j = i - 1;

                while (j >= 0 && data[j].CompareTo(key) > 0)
                {
                    data[j + 1] = data[j];
                    j = j - 1;
                }
                data[j + 1] = key;
            }
            return data;
        }
    }
}
