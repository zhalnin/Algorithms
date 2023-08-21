using Algorithm.DataStructures;
using System.Linq;

namespace Algorithm.Models;

public class HeapSort<T> : AlgorithmBase<T>
where T : IComparable<T>, IComparable
{
    protected override void MakeSort()
    {
        var tree = new Heap<T>(Items);
        Items = (List<T>)tree.Order().ToList();
    }
}
