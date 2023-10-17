using Lab5_4.Interfaces;
using System;

namespace Lab5_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int[] numbers1 = new int[] { 5, 2, 8, 9, 1, 13, 22, 17, 6 };
            IReceiver<int> receiver = new Receiver<int>();
            receiver.SetSortStrategy(new BubbleSortStrategy<int>());
            receiver.Sort(numbers1);
            Console.WriteLine("Сортування бульбашкою: " + string.Join(", ", numbers1));

            int[] numbers2 = new int[] { 15, 12, 18, 19, 1, 13, 2, 7, 6 };
            receiver.SetSortStrategy(new QuickSortStrategy<int>());
            receiver.Sort(numbers2);
            Console.WriteLine("Швидке сортування:     " + string.Join(", ", numbers2));

            int[] numbers3 = new int[] { 25, 2, 4, 9, 1, 23, 14, 24, 6 };
            receiver.SetSortStrategy(new InsertionSortStrategy<int>());
            receiver.Sort(numbers3);
            Console.WriteLine("Сортування вставками:  " + string.Join(", ", numbers3));

            numbers2 = new int[] { 15, 12, 18, 19, 1, 13, 2, 7, 6 };
            Console.WriteLine("Бінарний пошук:");
            receiver.SetSearchStrategy(new BinarySearchStrategy<int>());
            Console.WriteLine($"Max = {receiver.FindMax(numbers2)}");
            Console.WriteLine($"Max = {receiver.FindMin(numbers2)}");

            numbers3 = new int[] { 25, 2, 4, 9, 1, 23, 14, 24, 6 };
            Console.WriteLine("Лінійний пошук:");
            receiver.SetSearchStrategy(new LinearSearchStrategy<int>());
            Console.WriteLine($"Max = {receiver.FindMax(numbers3)}");
            Console.WriteLine($"Max = {receiver.FindMin(numbers3)}");
            Console.ReadKey();
        }
    }
}
