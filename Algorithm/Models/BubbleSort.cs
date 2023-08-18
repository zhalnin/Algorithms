﻿namespace Algorithm.Models;

public class BubbleSort<T> : AlgorithmBase<T> 
    where T : IComparable<T> 
{
    public override void Sort()
    {
        var count = Items.Count;

        for (int j = 0; j < count; j++)
        {
            for (int i = 0; i < count - j - 1; i++)
            {
                var itema = Items[i];
                var itemb = Items[i + 1];

                if (itema.CompareTo(itemb) == 1)
                {
                    Swap(i, i + 1);
                }
            }
        }
    }
}
