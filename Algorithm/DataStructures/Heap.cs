using System.Collections;

namespace Algorithm.DataStructures;

internal class Heap<T> where T : IComparable<T>
{
    private List<T> _items = new List<T>();
    public int Count => _items.Count;

    public Heap() { }

    public Heap(IEnumerable<T> items)
    {
        _items.AddRange(items);
        for (int i = Count; i >= 0; i--)
        {
            Sort(i);
        }
    }

    public T Peek()
    {
        if (Count <= 0)
        {
            throw new ArgumentException(nameof(_items), "The heap is empty");
        }

        return _items[0];
    }

    public void Add(T item)
    {
        _items.Add(item);

        var currentIndex = Count -1;
        var parentIndex = GetParentIndex(currentIndex);

        while (currentIndex > 0 && _items[parentIndex].CompareTo(_items[currentIndex]) < 0)
        {
            Swap(currentIndex, parentIndex);

            currentIndex = parentIndex;
            parentIndex = GetParentIndex(currentIndex);
        }
    }

    public T GetMax()
    {
        var result = _items[0];
        _items[0] = _items[Count - 1];
        _items.RemoveAt(Count - 1);
        Sort(0);
        return result;
    }

    public void Sort(int currentIndex)
    {
        int leftIndex;
        int rightIndex;
        int maxIndex = currentIndex;

        while (currentIndex < Count)
        {
            leftIndex = GetLeftChildIndex(currentIndex);
            rightIndex = GetRightChildIndex(currentIndex);

            if (leftIndex < Count && _items[leftIndex].CompareTo(_items[maxIndex]) < 0)
            {
                maxIndex = leftIndex;
            }

            if (rightIndex < Count && _items[rightIndex].CompareTo(_items[maxIndex]) < 0)
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

    private void Swap(int currentIndex, int parentIndex) =>
        (_items[currentIndex], _items[parentIndex]) = (_items[parentIndex], _items[currentIndex]);

    private int GetLeftChildIndex(int currentIndex) => 2 * currentIndex + 1;

    private int GetRightChildIndex(int currentIndex) => 2 * currentIndex + 2;

    private int GetParentIndex(int currentIndex) => (currentIndex - 1) / 2;

    public IEnumerable<T> Order()
    {
        while(Count > 0)
        {
            yield return GetMax();
        }
    }
}
