using System.Diagnostics;

namespace Algorithm.Models;

public class AlgorithmBase<T>
{
    public int SwapCount { get; protected set; } = 0;
    public int ComparisonCount { get; protected set; } = 0;
    public List<T> Items { get; set; } = new List<T>();

    public AlgorithmBase() { }

    public AlgorithmBase(IEnumerable<T> items) =>
        Items.AddRange(items);

    protected void Swap(int positionA, int positionB)
    {
        if(positionA < Items.Count && positionB < Items.Count)
        {
            (Items[positionA], Items[positionB]) = 
                (Items[positionB], Items[positionA]);

            SwapCount++;
        }
    }

    protected void Set(int position, T item)
    {
        if(position < Items.Count)
        {
            Items[position] = item;
        }
    }

    public TimeSpan Sort()
    {
        var timer = new Stopwatch();
        SwapCount = 0;

        timer.Start();
        MakeSort();
        timer.Stop();

        return timer.Elapsed;
    }

    protected virtual void MakeSort()
    {
        Items.Sort();
    }
}