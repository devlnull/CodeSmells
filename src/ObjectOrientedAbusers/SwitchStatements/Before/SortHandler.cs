namespace ObjectOrientedAbusers.SwitchStatements.Before;

public class SortHandler
{
    public long[] Sort(long[] items, string algorithm)
    {
        switch (algorithm)
        {
            case "Quick":
                return SortWithQuickAlgorithm(items);
            case "Merge":
                return SortWithMergeAlgorithm(items);
            case "Bubble":
                return SortWithBubbleAlgorithm(items);
            default:
                return SortWithQuickAlgorithm(items);
        }
    }

    private long[] SortWithQuickAlgorithm(long[] items)
    {
        //algorithm implementation..
        return items;
    }
    
    private long[] SortWithMergeAlgorithm(long[] items)
    {
        //algorithm implementation..
        return items;
    }
    
    private long[] SortWithBubbleAlgorithm(long[] items)
    {
        //algorithm implementation..
        return items;
    }
}