namespace Algorithm.Models;

public class AlgorithmBase<T>
{
    public List<T> Items { get; set; } = new List<T>();

    protected void Swap(int positionA, int positionB)
    {
        if(positionA < Items.Count && positionB < Items.Count)
        {
            (Items[positionA], Items[positionB]) = (Items[positionB], Items[positionA]);
        }
    }

    public void FillRandom(int count, List<T>? list = null)
    {
        var rnd = new Random();
        for (int i = 0; i < count; i++)
        {
            if (typeof(T) == typeof(int))
            {
                var item = (T)(object)(rnd.Next(0, 100));
                list?.Add(item);
                Items.Add(item);
            }
        }
    }

    public virtual void Sort()
    {
        Items.Sort();
    }
}
