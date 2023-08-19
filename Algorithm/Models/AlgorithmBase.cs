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

    public virtual void Sort() =>
        Items.Sort();
}
