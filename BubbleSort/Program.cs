// See https://aka.ms/new-console-template for more information
using Algorithm.Extensions;
using Algorithm.Models;

Console.WriteLine("Hello, buble sorting!");


BubbleSort<int> bubble = new();
bubble.FillRandom(10);
bubble.Sort();