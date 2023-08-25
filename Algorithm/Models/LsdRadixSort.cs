namespace Algorithm.Models;

public class LsdRadixSort<T> : AlgorithmBase<T>
    where T : IComparable
{
    protected override void MakeSort()
    {
        var groups = new List<List<T>>();

        for (int i = 0; i < 10; i++)
        {
            groups.Add(new List<T>());
        }

        int length = GetMaxLength();

        for (int step = 0; step < length; step++)
        {
            //Sorted to baskets
            foreach (var item in Items)
            {
                var i = item.GetHashCode();
                int value = i % (int)Math.Pow(10,(step + 1)) / (int)Math.Pow(10, step);
                groups[value].Add(item);
            }

            Items.Clear();

            //Getting items from baskets
            foreach (var group in groups)
            {
                foreach(var item in group)
                {
                    Items.Add(item);
                }
            }

            //Clear baskets
            foreach(var group in groups)
            {
                group.Clear();
            }
        }
    }

    private int GetMaxLength()
    {
        int length = default;
        foreach (var item in Items)
        {
            if (item.GetHashCode() < 0)
            {
                throw new ArgumentException($"{nameof(LsdRadixSort<T>)} support whole digits only");
            }

            int l = item.GetHashCode().Equals(0) ? 1 : (int)(Math.Floor(Math.Log10(item.GetHashCode())) + 1);
            if (l > length)
            {
                length = l;
            }
        }
        return length;
    }
}