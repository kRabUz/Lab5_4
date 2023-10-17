using Lab5_4.Interfaces;

namespace Lab5_4
{
    public class Receiver<T> : IReceiver<T>
    {
        private ISortStrategy<T> _sortStrategy;
        private ISearchStrategy<T> _searchStrategy;

        public void SetSortStrategy(ISortStrategy<T> strategy)
        {
            _sortStrategy = strategy;
        }

        public void SetSearchStrategy(ISearchStrategy<T> strategy)
        {
            _searchStrategy = strategy;
        }

        public T[] Sort(T[] data)
        {
            return _sortStrategy.Sort(data);
        }
        public T FindMax(T[] data)
        {
            return _searchStrategy.FindMax(data);
        }

        public T FindMin(T[] data)
        {
            return _searchStrategy.FindMin(data);
        }
    }
}
