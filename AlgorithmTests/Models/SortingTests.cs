using Algorithm.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithm.Models.Tests;

[TestClass()]
public class SortingTests
{
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
        sortType.FillRandom(10, items);

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
        sortType.FillRandom(10, items);

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
        sortType.FillRandom(10, items);

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