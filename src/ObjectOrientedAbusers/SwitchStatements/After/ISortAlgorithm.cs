namespace ObjectOrientedAbusers.SwitchStatements.After;

public interface ISortAlgorithm
{
    string Name { get; }
    long[] Sort(long[] items);
}