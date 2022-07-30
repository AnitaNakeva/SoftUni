namespace Database.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    [TestFixture]
    public class DatabaseTests
    {
        private Database db;

        [SetUp]
        public void SetUp()
        {
            this.db = new Database();
        }

        [TestCase(new int[] { })]
        [TestCase(new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void ConstructorShouldAddLessThan17Elements(int[] elementToAdd)
        {
            Database testDB = new Database(elementToAdd);

            int[] expectedArray = elementToAdd;
            int[] actualArray = testDB.Fetch();

            int expectedCount = expectedArray.Length;
            int actualCount = testDB.Count;

            CollectionAssert.AreEqual(expectedArray, actualArray);
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 })]
        public void ConstructorShouldReturnErrorMessagesWhenThereAreMoreThan16Elements(int[] elementsToAdd)
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                Database testDB = new Database(elementsToAdd);
            }, "Array's capacity must be exactly 16 integers!");
        }

        [TestCase(new int[] { 1, 2, 3 })]
        [TestCase(new int[] { })]
        [TestCase(new int[] { 1 })]
        public void CountShouldReturnTheCurrentCount(int[] elemetsToAdd)
        {
            Database testDB = new Database(elemetsToAdd);

            int expectedCount = elemetsToAdd.Length;
            int actualCount = testDB.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void CountShouldReturnZeroWhenEmpty()
        {
            int expectedCount = 0;
            int actualCount = this.db.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        [TestCase(new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 3 })]
        public void AddMethodSHouldAddUpToCount16(int[] elementsToAdd)
        {
            foreach (int el in elementsToAdd)
            {
                this.db.Add(el);
            }

            int[] expectedArray = elementsToAdd;
            int[] actualArray = db.Fetch();

            int expectedCount = elementsToAdd.Length;
            int actualCount = db.Count;

            CollectionAssert.AreEqual(expectedArray, actualArray);
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 })]
        public void AddMethodShouldThrowExceptionMessageWhenMoreThan16ElementsAreAdded(int[] elementsToAdd)
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                foreach (int el in elementsToAdd)
                {
                    this.db.Add(el);
                }
            }, "Array's capacity must be exactly 16 integers!");
        }

        [TestCase(new int[] { 1, 2, 3 })]
        public void RemoveMethodShouldRemoveWhenThereAreElements(int[] elements)
        {
            Database testDB = new Database();
            foreach(int el in elements)
            {
                testDB.Add(el);
            }

            testDB.Remove();
            List<int> listEl = new List<int>(elements);
            listEl.RemoveAt(elements.Length - 1);

            int[] expectedArray = listEl.ToArray();
            int[] actualArray = testDB.Fetch();

            int expectedCount = expectedArray.Length;
            int actualCount = testDB.Count;

            CollectionAssert.AreEqual(expectedArray, actualArray);
            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void RemoveMethodShouldThrowExceptionMessageWhenThereAreNoElements()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.db.Remove();
            }, "The collection is empty!");
        }

        [TestCase(new int[] { 1, 2, 3 })]
        public void FetchShouldReturnTheCurrentArray(int[] elements)
        {
            foreach(int el in elements)
            {
                this.db.Add(el);
            }

            int[] expectedArray = elements;
            int[] actualArray = this.db.Fetch();

            CollectionAssert.AreEqual(expectedArray, actualArray);
        }
    }
}
