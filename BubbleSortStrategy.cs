using Lab5_4.Interfaces;
using System;

namespace Lab5_4
{
    public class BubbleSortStrategy<T> : ISortStrategy<T> where T : IComparable<T>
    {
        public T[] Sort(T[] data)
        {
            int n = data.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (data[j].CompareTo(data[j + 1]) > 0)
                    {
                        T temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }
            return data;
        }
    }
}
