using Algorithm.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithm.Models.Tests;

[TestClass()]
public class CocktailSortTests
{
    [TestMethod()]
    public void SortTest()
    {
        //Arrange
        CocktailSort<int> cocktail = new();
        List<int> items = new();

        cocktail.FillRandom(10, items);

        //Act
        items.Sort();
        var timer = cocktail.Sort();
        Console.WriteLine(timer);
        //Assert
        for (int i = 0; i < items.Count; i++)
        {
            Assert.AreEqual(items[i], cocktail.Items[i]);
        }
    }
}