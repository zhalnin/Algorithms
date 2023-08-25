namespace Algorithm.Models;

public class MsdRadixSort<T> : AlgorithmBase<T>
    where T : IComparable
{
    protected override void MakeSort()
    {
        int length = GetMaxLength(Items);
        var result = SortCollection(Items, length - 1);
        Items = result.ToList();
    }

    private IEnumerable<T> SortCollection(List<T> collection, int step)
    {
        var result = new List<T>();
        var groups = new List<List<T>>();
        for (int i = 0; i < 10; i++)
        {
            groups.Add(new List<T>());
        }

        foreach (var item in collection)
        {
            int i = item.GetHashCode();
            int value = i % (int)Math.Pow(10, step + 1) / (int)Math.Pow(10, step);
            groups[value].Add(item);
        }

        foreach (var group in groups)
        {
            if (group.Count > 1 && step > 0)
            {
                result.AddRange(SortCollection(group, step - 1));
                continue;
            }

            result.AddRange(group);
        }
        return result;
    }

    private int GetMaxLength(List<T> collection)
    {
        int length = default;

        foreach (var item in collection)
        {
            if(item.GetHashCode() < 0)
            {
                throw new ArgumentException($"{nameof(LsdRadixSort<T>)} support whole digits only");
            }

            int l = item.GetHashCode().Equals(0) ? 1 : (int)(Math.Floor(Math.Log10(item.GetHashCode())) + 1);
            if(l > length)
            {
                length = l;
            }
        }
        return length;
    }
}