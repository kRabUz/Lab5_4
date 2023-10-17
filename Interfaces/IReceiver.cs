namespace Lab5_4.Interfaces
{
    public interface IReceiver<T>
    {
        void SetSortStrategy(ISortStrategy<T> strategy);

        void SetSearchStrategy(ISearchStrategy<T> strategy);

        T[] Sort(T[] data);
        T FindMax(T[] data);

        T FindMin(T[] data);
    }
}
