namespace Algorithm.Models;

public class SelectionSort<T> : AlgorithmBase<T>
    where T : IComparable
{
    protected override void MakeSort()
    {
        int minIndex; ;

        for (int i = 0; i < Items.Count - 1; i++)
        {
            minIndex = i;

            for (int j = i + 1; j < Items.Count; j++)
            {
                if (Items[j].CompareTo(Items[minIndex]) < 0)
                {
                    minIndex = j;
                }
            }

            if (i != minIndex)
            {
                Swap(i, minIndex);
            }
        }
    }
}
