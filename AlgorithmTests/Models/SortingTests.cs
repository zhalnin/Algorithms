using Algorithm.DataStructures;
using Algorithm.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithm.Models.Tests;

[TestClass()]
public class SortingTests
{
    private readonly int rndCount = 10;
    readonly List<int> items = new();
    AlgorithmBase<int> sortType = new();

    [TestInitialize]
    public void Init()
    {
        items.Clear();
    }

    [TestMethod()]
    public void BubbleSortTest()
    {
        //Arrange
        sortType = new BubbleSort<int>();
        sortType.FillRandom(rndCount, items);

        //Act
        items.Sort();
        var timer = sortType.Sort();
        Console.WriteLine(timer);

        //Assert
        for (int i = 0; i < items.Count; i++)
        {
            Assert.AreEqual(items[i], sortType.Items[i]);
        }
    }

    [TestMethod()]
    public void CocktailSortTest()
    {
        //Arrange
        sortType = new CocktailSort<int>();
        sortType.FillRandom(rndCount, items);

        //Act
        items.Sort();
        var timer = sortType.Sort();
        Console.WriteLine(timer);

        //Assert
        for (int i = 0; i < items.Count; i++)
        {
            Assert.AreEqual(items[i], sortType.Items[i]);
        }
    }

    [TestMethod()]
    public void InsertSortTest()
    {
        //Arrange
        sortType = new InsertSort<int>();
        sortType.FillRandom(rndCount, items);

        //Act
        items.Sort();
        var timer = sortType.Sort();
        Console.WriteLine(timer);

        //Assert
        for (int i = 0; i < items.Count; i++)
        {
            Assert.AreEqual(items[i], sortType.Items[i]);
        }
    }

    [TestMethod()]
    public void ShellSortTest()
    {
        //Arrange
        sortType = new ShellSort<int>();
        sortType.FillRandom(rndCount, items);

        //Act
        items.Sort();
        var timer = sortType.Sort();
        Console.WriteLine(timer);

        //Assert
        for (int i = 0; i < items.Count; i++)
        {
            Assert.AreEqual(items[i], sortType.Items[i]);
        }
    }

    [TestMethod()]
    public void TreeSortTest()
    {
        //Arrange
        sortType = new Tree<int>();
        sortType.FillRandom(rndCount, items);

        //Act
        items.Sort();
        var timer = sortType.Sort();
        Console.WriteLine(timer);

        //Assert
        for (int i = 0; i < items.Count; i++)
        {
            Assert.AreEqual(items[i], sortType.Items[i]);
        }
    }
    
    [TestMethod()]
    public void HeapSortTest()
    {
        //Arrange
        sortType = new Heap<int>();
        sortType.FillRandom(rndCount, items);

        //Act
        items.Sort();
        var timer = sortType.Sort();
        Console.WriteLine(timer);

        //Assert
        for (int i = 0; i < items.Count; i++)
        {
            Assert.AreEqual(items[i], sortType.Items[i]);
        }
    }

    [TestMethod()]
    public void SelectionSortTest()
    {
        //Arrange
        sortType = new SelectionSort<int>();
        sortType.FillRandom(rndCount, items);

        //Act
        items.Sort();
        var timer = sortType.Sort();
        Console.WriteLine(timer);

        //Assert
        for (int i = 0; i < items.Count; i++)
        {
            Assert.AreEqual(items[i], sortType.Items[i]);
        }
    }
    
    [TestMethod()]
    public void GnomeSortTest()
    {
        //Arrange
        sortType = new GnomeSort<int>();
        sortType.FillRandom(rndCount, items);

        //Act
        items.Sort();
        var timer = sortType.Sort();
        Console.WriteLine(timer);

        //Assert
        for (int i = 0; i < items.Count; i++)
        {
            Assert.AreEqual(items[i], sortType.Items[i]);
        }
    }
    
    [TestMethod()]
    public void LsdRadixSortTest()
    {
        //Arrange
        sortType = new LsdRadixSort<int>();
        sortType.FillRandom(rndCount, items);

        //Act
        items.Sort();
        var timer = sortType.Sort();
        Console.WriteLine(timer);

        //Assert
        for (int i = 0; i < items.Count; i++)
        {
            Assert.AreEqual(items[i], sortType.Items[i]);
        }
    }
    
    [TestMethod()]
    public void MsdRadixSortTest()
    {
        //Arrange
        sortType = new MsdRadixSort<int>();
        sortType.FillRandom(rndCount, items,0,1000);

        //Act
        items.Sort();
        var timer = sortType.Sort();
        Console.WriteLine(timer);

        //Assert
        for (int i = 0; i < items.Count; i++)
        {
            Assert.AreEqual(items[i], sortType.Items[i]);
        }
    }
}