namespace ObjectOrientedAbusers.SwitchStatements.After;

public class SortHandler2
{
    private readonly List<ISortAlgorithm> _sortAlgorithms = new()
    {
        new MergeSortAlgorithm(),
        new QuickSortAlgorithm(),
        new BubbleSortAlgorithm()
    };

    public long[] Sort(long[] items, ISortAlgorithm algorithm)
    {
        var sortAlgorithm = _sortAlgorithms.First(x=> x.Name == algorithm.Name);
        return sortAlgorithm.Sort(items);
    }
}