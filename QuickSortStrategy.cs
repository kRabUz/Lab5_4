using Lab5_4.Interfaces;
using System;

namespace Lab5_4
{
    public class QuickSortStrategy<T> : ISortStrategy<T> where T : IComparable<T>
    {
        public T[] Sort(T[] data)
        {
            QuickSort(data, 0, data.Length - 1);
            return data;
        }

        private void QuickSort(T[] data, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(data, low, high);
                QuickSort(data, low, pivotIndex - 1);
                QuickSort(data, pivotIndex + 1, high);
            }
        }

        private int Partition(T[] data, int low, int high)
        {
            T pivot = data[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (data[j].CompareTo(pivot) <= 0)
                {
                    i++;
                    T temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                }
            }
            T temp2 = data[i + 1];
            data[i + 1] = data[high];
            data[high] = temp2;
            return i + 1;
        }
    }
}
