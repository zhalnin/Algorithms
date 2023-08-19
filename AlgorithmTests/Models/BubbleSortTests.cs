using Algorithm.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithm.Models.Tests
{
    [TestClass()]
    public class BubbleSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            //Arrange
            BubbleSort<int> bubble = new();
            List<int> items = new();

            bubble.FillRandom(10, items);

            //Act
            items.Sort();
            bubble.Sort();

            //Assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(items[i], bubble.Items[i]);
            }
        }
    }
}