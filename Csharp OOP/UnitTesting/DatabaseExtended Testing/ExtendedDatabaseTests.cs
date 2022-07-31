namespace DatabaseExtended.Tests
{
    using ExtendedDatabase;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    [TestFixture]
    public class ExtendedDatabaseTests
    {
        private Database db;

        [SetUp]
        public void SetUp()
        {
            this.db = new Database();
        }

        [Test]
        public void ConstructorShouldAddLessThan17Elements()
        {
            Person person1 = new Person(1, "A");
            Person person2 = new Person(2, "B");
            Person person3 = new Person(3, "C");
            Person[] persons = new Person[] { person1, person2, person3 };

            Database testDB = new Database(persons);

            int expectedCount = persons.Length;
            int actualCount = testDB.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void ConstructorShoulWorkWithNoPersonsAdded()
        {
            Assert.DoesNotThrow(() => this.db = new Database());
        }

        [Test]
        public void ConstructorShouldReturnErrorMessagesWhenThereAreMoreThan16Elements()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Person person1 = new Person(1, "A");
                Person person2 = new Person(2, "B");
                Person person3 = new Person(3, "C");
                Person person4 = new Person(4, "D");
                Person person5 = new Person(5, "F");
                Person person6 = new Person(6, "G");
                Person person7 = new Person(7, "H");
                Person person8 = new Person(8, "J");
                Person person9 = new Person(9, "K");
                Person person10 = new Person(10, "Q");
                Person person11 = new Person(11, "W");
                Person person12 = new Person(12, "E");
                Person person13 = new Person(13, "R");
                Person person14 = new Person(14, "T");
                Person person15 = new Person(15, "Y");
                Person person16 = new Person(16, "U");
                Person person17 = new Person(17, "I");
                Person[] persons = new Person[]
                {
                    person1, person2, person3,
                    person4, person5, person6,
                    person7, person8, person9,
                    person10, person11, person12,
                    person13, person14, person15,
                    person16, person17
                };

                Database testDB = new Database(persons);

            }, "Provided data length should be in range [0..16]!");
        }

        [Test]
        public void CountShouldReturnTheCurrentCount()
        {
            Person person1 = new Person(1, "A");
            Person person2 = new Person(2, "B");
            Person person3 = new Person(3, "C");
            Person[] persons = new Person[] { person1, person2, person3 };
            Database testDB = new Database(persons);

            int expectedCount = persons.Length;
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

        [Test]
        public void AddMethodSHouldThrowExceptionWhenAdded17thPerson()
        {
            Person person1 = new Person(1, "A");
            Person person2 = new Person(2, "B");
            Person person3 = new Person(3, "C");
            Person person4 = new Person(4, "D");
            Person person5 = new Person(5, "F");
            Person person6 = new Person(6, "G");
            Person person7 = new Person(7, "H");
            Person person8 = new Person(8, "J");
            Person person9 = new Person(9, "K");
            Person person10 = new Person(10, "Q");
            Person person11 = new Person(11, "W");
            Person person12 = new Person(12, "E");
            Person person13 = new Person(13, "R");
            Person person14 = new Person(14, "T");
            Person person15 = new Person(15, "Y");
            Person person16 = new Person(16, "U");
            Person person17 = new Person(17, "I");
            Person[] persons = new Person[]
            {
                    person1, person2, person3,
                    person4, person5, person6,
                    person7, person8, person9,
                    person10, person11, person12,
                    person13, person14, person15,
                    person16
            };
            Database testDB = new Database(persons);

            Assert.Throws<InvalidOperationException>(() =>
            {
                testDB.Add(person17);
            }, "Array's capacity must be exactly 16 integers!");
        }

        [Test]
        public void AddMethodSHouldAddUpToCount16()
        {
            Person person1 = new Person(1, "A");
            this.db.Add(person1);
            int expectedCount = 1;
            int actualCount = db.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestCase(1, "A", 1, "A")]
        [TestCase(1, "A", 2, "A")]
        [TestCase(1, "A", 1, "B")]
        public void CannotAddTheSameIdOrUsername(long firstId, string firstUsername, long secondId, string secondUsername)
        {
            Person person1 = new Person(firstId, firstUsername);
            Person person2 = new Person(secondId, secondUsername);

            this.db.Add(person1);

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.db.Add(person2);
            });
        }

        [Test]
        public void RemoveMethodShouldRemoveWhenThereAreElements()
        {
            Person person1 = new Person(1, "A");
            Person person2 = new Person(2, "B");
            Person person3 = new Person(3, "C");
            Person[] persons = new Person[] { person1, person2, person3 };
            Database testDB = new Database();
            foreach (Person person in persons)
            {
                testDB.Add(person);
            }

            testDB.Remove();
            List<Person> listEl = new List<Person>(persons);
            listEl.RemoveAt(persons.Length - 1);

            int expectedCount = listEl.Count;
            int actualCount = testDB.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void RemoveMethodShouldThrowExceptionMessageWhenThereAreNoElements()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.db.Remove();
            });
        }

        [TestCase(1, "A", 2, "B", 3, "C", "A")]
        [TestCase(1, "A", 2, "B", 3, "C", "B")]
        [TestCase(1, "A", 2, "B", 3, "C", "C")]
        public void FindByUsername(long firstId, string firstUsername, long secondId, string secondUsername,
            long thirdId, string thirdUsername, string keyUsername)
        {
            this.db.Add(new Person(firstId, firstUsername));
            this.db.Add(new Person(secondId, secondUsername));
            this.db.Add(new Person(thirdId, thirdUsername));

            Person foundPerson = this.db.FindByUsername(keyUsername);

            Assert.AreEqual(keyUsername, foundPerson.UserName);
        }

        [TestCase(1, "A", 2, "B", 3, "C", 1)]
        [TestCase(1, "A", 2, "B", 3, "C", 2)]
        [TestCase(1, "A", 2, "B", 3, "C", 3)]
        public void FindById(long firstId, string firstUsername, long secondId, string secondUsername,
            long thirdId, string thirdUsername, long keyId)
        {
            this.db.Add(new Person(firstId, firstUsername));
            this.db.Add(new Person(secondId, secondUsername));
            this.db.Add(new Person(thirdId, thirdUsername));

            Person foundPerson = this.db.FindById(keyId);

            Assert.AreEqual(keyId, foundPerson.Id);
        }

        [TestCase(1, "A", 2, "B", 3, "C", -1)]
        public void ThrowExceptionWhenSearchingForLessThanZero(long firstId, string firstUsername, long secondId, string secondUsername,
            long thirdId, string thirdUsername, long keyId)
        {
            this.db.Add(new Person(firstId, firstUsername));
            this.db.Add(new Person(secondId, secondUsername));
            this.db.Add(new Person(thirdId, thirdUsername));

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                this.db.FindById(keyId);
            }, "Id should be a positive number!");
                
        }

        [TestCase(1, "A", 2, "B", 3, "C")]
        [TestCase(1, "A", 2, "B", 3, "C")]
        public void ThrowExceptionWhenSearchingNullOrEmpty(long firstId, string firstUsername, long secondId, string secondUsername,
            long thirdId, string thirdUsername)
        {
            this.db.Add(new Person(firstId, firstUsername));
            this.db.Add(new Person(secondId, secondUsername));
            this.db.Add(new Person(thirdId, thirdUsername));

            Assert.Throws<ArgumentNullException>(() => this.db.FindByUsername(null), "Username parameter is null!");

        }

        [TestCase(1, "A", 2, "B", 3, "C", "K")]
        public void ThrowExceptionWhenSearchingForNonexistingUsername(long firstId, string firstUsername, long secondId, string secondUsername,
            long thirdId, string thirdUsername, string keyUsername)
        {
            this.db.Add(new Person(firstId, firstUsername));
            this.db.Add(new Person(secondId, secondUsername));
            this.db.Add(new Person(thirdId, thirdUsername));

            Assert.Throws<InvalidOperationException>(() => this.db.FindByUsername(keyUsername), "No user is present by this username!");

        }

        [TestCase(1, "A", 2, "B", 3, "C", 4)]
        public void ThrowExceptionWhenSearchingForNonexistingUsername(long firstId, string firstUsername, long secondId, string secondUsername,
            long thirdId, string thirdUsername, long keyId)
        {
            this.db.Add(new Person(firstId, firstUsername));
            this.db.Add(new Person(secondId, secondUsername));
            this.db.Add(new Person(thirdId, thirdUsername));

            Assert.Throws<InvalidOperationException>(() => this.db.FindById(keyId), "No user is present by this ID!");

        }
    }
}