using Algorithm.DataStructures;

namespace Algorithm.Models;

public class TreeSort<T> : AlgorithmBase<T>
    where T : IComparable<T>, IComparable
{
    protected override void MakeSort()
    {
        var tree = new Tree<T>(Items);
        Items = tree.InOrder();
    }
}
