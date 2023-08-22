namespace Algorithm.Models;

public class GnomeSort<T> : AlgorithmBase<T>
where T : IComparable
{
    protected override void MakeSort()
    {
        var j = 1;

        while(j < Items.Count)
        {
            if(j.Equals(0) || Items[j].CompareTo(Items[j - 1]) > 0)
            {
                j++;
            }
            else
            {
                Swap(j, j - 1);
                j--;
            }
        }
    }
}