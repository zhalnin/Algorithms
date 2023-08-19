using Algorithm.Models;

namespace Algorithm.Extensions;

public static class ExtensionMethods
{
    public static void FillRandom<T>(this AlgorithmBase<T> sort, int count, List<T>? list = null) 
        where T : IComparable<T>
    {
        var rnd = new Random();
        for (int i = 0; i < count; i++)
        {
            if (typeof(T) == typeof(int))
            {
                var item = (T)(object)(rnd.Next(0, 100));
                list?.Add(item);
                sort.Items.Add(item);
            }
        }
    }
}