using BasicSorts;

namespace UnitTests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void BubbleSort_CorrectInput_ValidResult()
        {
            // Arrange 

            var array = new[] { 25, -1, 90, 78, 100, 11 };

            // Act
            SortingManager.BubbleSort(array);

            // Asserts 

            for (int i = 0; i < array.Length - 1; i++)
            {
                Assert.IsTrue(array[i] < array[i + 1]);
            }
        }

        [TestMethod]
        public void BubbleSort_Vector_CorrectResult()
        {
            // Arrange 

            var array = new[] { 25 };

            // Act
            SortingManager.BubbleSort(array);

            // Asserts 

            Assert.AreEqual(25, array[0]);
            Assert.AreEqual(1, array.Length);   
        }

        [TestMethod]
        public void SelectionSort_CorrectInput_ValidResult()
        {
            // Arrange 

            var array = new[] { 25, -1, 90, 78, 100, 11 };

            // Act
            SortingManager.SelectionSort(array);

            // Asserts 

            for (int i = 0; i < array.Length - 1; i++)
            {
                Assert.IsTrue(array[i] < array[i + 1]);
            }
        }

        [TestMethod]
        public void SelectionSort_Vector_CorrectResult()
        {
            // Arrange 

            var array = new[] { 25 };

            // Act
            SortingManager.SelectionSort(array);

            // Asserts 

            Assert.AreEqual(25, array[0]);
            Assert.AreEqual(1, array.Length);
        }


        [TestMethod]
        public void InsertingSort_CorrectInput_ValidResult()
        {
            // Arrange 

            var array = new[] { 25, -1, 90, 78, 100, 11 };

            // Act
            SortingManager.InsertingSort(array);

            // Asserts 

            for (int i = 0; i < array.Length - 1; i++)
            {
                Assert.IsTrue(array[i] < array[i + 1]);
            }
        }

        [TestMethod]
        public void InsertingSort_Vector_CorrectResult()
        {
            // Arrange 

            var array = new[] { 25 };

            // Act
            SortingManager.InsertingSort(array);

            // Asserts 

            Assert.AreEqual(25, array[0]);
            Assert.AreEqual(1, array.Length);
        }
    }
}