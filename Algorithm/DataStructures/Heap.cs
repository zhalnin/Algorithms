using Algorithm.Models;

namespace Algorithm.DataStructures;

public class Heap<T> : AlgorithmBase<T> 
    where T : IComparable
{
    public int Count => Items.Count;

    public Heap() { }

    public Heap(IEnumerable<T> items)
    {
        Items.AddRange(items);
        for (int i = Count; i >= 0; i--)
        {
            Sort(i);
        }
    }

    public void Add(T item)
    {
        Items.Add(item);

        var currentIndex = Count -1;
        var parentIndex = GetParentIndex(currentIndex);

        while (currentIndex > 0 && Items[parentIndex].CompareTo(Items[currentIndex]) < 0)
        {
            Swap(currentIndex, parentIndex);

            currentIndex = parentIndex;
            parentIndex = GetParentIndex(currentIndex);
        }
    }

    public T GetMax()
    {
        var result = Items[0];
        Items[0] = Items[Count - 1];
        Items.RemoveAt(Count - 1);
        Sort(0);
        return result;
    }

    public void Sort(int currentIndex, int? maxLength = null)
    {
        int maxIndex = currentIndex;
        int leftIndex;
        int rightIndex;

        maxLength ??= Count;

        while (currentIndex < maxLength)
        {
            leftIndex = GetLeftChildIndex(currentIndex);
            rightIndex = GetRightChildIndex(currentIndex);

            if (leftIndex < maxLength && Items[leftIndex].CompareTo(Items[maxIndex]) > 0)
            {
                maxIndex = leftIndex;
            }

            if (rightIndex < maxLength && Items[rightIndex].CompareTo(Items[maxIndex]) > 0)
            {
                maxIndex = rightIndex;
            }

            if (maxIndex == currentIndex)
            {
                break;
            }

            Swap(currentIndex, maxIndex);
            currentIndex = maxIndex;
        }
    }

    private int GetLeftChildIndex(int currentIndex) => 2 * currentIndex + 1;

    private int GetRightChildIndex(int currentIndex) => 2 * currentIndex + 2;

    private int GetParentIndex(int currentIndex) => (currentIndex - 1) / 2;

    protected override void MakeSort()
    {
        for (int i = Count - 1; i >= 0; i--)
        {
            Swap(0, i);
            Sort(0, i);
        }
    }
}