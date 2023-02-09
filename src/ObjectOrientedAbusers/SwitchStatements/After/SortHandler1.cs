namespace ObjectOrientedAbusers.SwitchStatements.After;

public class SortHandler1
{
    private readonly Dictionary<string, ISortAlgorithm> _sortAlgorithms;

    public SortHandler1()
    {
        _sortAlgorithms = new Dictionary<string, ISortAlgorithm>()
        {
            {"Merge", new MergeSortAlgorithm()},
            {"Quick", new QuickSortAlgorithm()},
            {"Bubble", new BubbleSortAlgorithm()}
        };
    }

    public long[] Sort(long[] items, string algorithm)
    {
        if (_sortAlgorithms.ContainsKey(algorithm) == false)
            throw new NotSupportedException(algorithm);

        var sortAlgorithm = _sortAlgorithms[algorithm];
        
        return sortAlgorithm.Sort(items);
    }
}