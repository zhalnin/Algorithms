using Algorithm.DataStructures;
using Algorithm.Models;

namespace Algorithm.Extensions;

public static class ExtensionMethods
{
    public static void FillRandom<T>(this AlgorithmBase<T> sort, int count, List<T>? list = null, int minValue = 0, int maxValue = 100)
        where T : IComparable<T>, IComparable
    {
        var rnd = new Random();

        if (typeof(T) == typeof(int))
        {
            for (int i = 0; i < count; i++)
            {
                var item = (T)(object)(rnd.Next(minValue, maxValue));
                list?.Add(item);
                sort.Items.Add(item);

                if (sort.GetType().Equals(typeof(Tree<T>)))
                {
                    var node = new Node<T>(sort.Items[i], i);
                    ((Tree<T>)sort).Add(node);
                }
            }

            if (sort.GetType().Equals(typeof(Heap<T>)))
            {
                for (int i = sort.Items.Count; i >= 0; i--)
                {
                    ((Heap<T>)sort).Sort(i);
                }
            }
        }
    }
}