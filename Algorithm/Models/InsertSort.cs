﻿namespace Algorithm.Models;

public class InsertSort<T> : AlgorithmBase<T> 
    where T : IComparable
{
    protected override void MakeSort()
    {
        for (int i = 1; i < Items.Count; i++)
        {
            var temp = Items[i];
            var j = i;
            while(j > 0 && temp.CompareTo(Items[j - 1]) < 0)
            {
                Items[j] = Items[j - 1];
                j--;
            }
            Items[j] = temp;
        }
    }
}