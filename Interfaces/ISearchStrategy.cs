namespace Lab5_4.Interfaces
{
    public interface ISearchStrategy<T>
    {
        T FindMax(T[] data);
        T FindMin(T[] data);
    }
}
