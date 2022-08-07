namespace Aquariums.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AquariumsTests
    {
        [TestCase("name", 5)]
        public void CheckIfConstructorWorksProperly(string name, int capacity)
        {
            Aquarium aq = new Aquarium(name, capacity);

            string expectedName = name;
            string actualName = aq.Name;

            int expectedCapacity = capacity;
            int actualCapacity = aq.Capacity;

            Assert.AreEqual(expectedName, actualName);
            Assert.AreEqual(expectedCapacity, actualCapacity);
        }

        [TestCase("")]
        [TestCase(null)]
        public void CheckIfNamePropWorksWithIncorrectData(string name)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                Aquarium aq = new Aquarium(name, 5);
            });
        }

        [TestCase(-1)]
        [TestCase(-25)]
        public void CheckIfCapacityPropWorksWithIncorrectData(int capacity)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Aquarium aq = new Aquarium("name", capacity);
            });
        }

        [Test]
        public void CheckIfCountPropWorks()
        {
            Fish fish1 = new Fish("name1");
            Fish fish2 = new Fish("name2");
            Fish fish3 = new Fish("name3");

            Aquarium aq = new Aquarium("name", 5);
            aq.Add(fish3);
            aq.Add(fish2);
            aq.Add(fish1);

            int expectedCount = 3;
            int actualCount = aq.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void CheckIfAddMethodWorksWhenOverTheCapacity()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                Fish fish1 = new Fish("name1");
                Fish fish2 = new Fish("name2");
                Fish fish3 = new Fish("name3");

                Aquarium aq = new Aquarium("name", 2);
                aq.Add(fish3);
                aq.Add(fish2);
                aq.Add(fish1);
            });
        }

        [TestCase("name1")]
        [TestCase("name2")]
        [TestCase("name3")]
        public void CheckIfRemoveFishMethodWorksWithCorrectData(string nameToRemove)
        {
            Fish fish1 = new Fish("name1");
            Fish fish2 = new Fish("name2");
            Fish fish3 = new Fish("name3");

            Aquarium aq = new Aquarium("name", 5);
            aq.Add(fish3);
            aq.Add(fish2);
            aq.Add(fish1);
            aq.RemoveFish(nameToRemove);

            int expectedCount = 2;
            int actualCount = aq.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestCase("missingName")]
        public void CheckIfRemoveFishMethodWorksWithIncorrectData(string nameToRemove)
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                Fish fish1 = new Fish("name1");
                Fish fish2 = new Fish("name2");
                Fish fish3 = new Fish("name3");

                Aquarium aq = new Aquarium("name", 5);
                aq.Add(fish3);
                aq.Add(fish2);
                aq.Add(fish1);
                aq.RemoveFish(nameToRemove);
            });
        }

        [TestCase("name3")]
        [TestCase("name2")]
        [TestCase("name1")]
        public void CheckIfSellFishMethodWorksWithCorrectData(string nameToSell)
        {
            Fish fish1 = new Fish("name1");
            Fish fish2 = new Fish("name2");
            Fish fish3 = new Fish("name3");

            Aquarium aq = new Aquarium("name", 5);
            aq.Add(fish3);
            aq.Add(fish2);
            aq.Add(fish1);
            var soldFish = aq.SellFish(nameToSell);

            bool expectedIsAvailable = false;
            bool actualIsAvailable = soldFish.Available;

            Assert.AreEqual(expectedIsAvailable, actualIsAvailable);
        }

        [TestCase("missingName")]
        public void CheckIfSellFishMethodWorksWithIncorrectData(string nameToSell)
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                Fish fish1 = new Fish("name1");
                Fish fish2 = new Fish("name2");
                Fish fish3 = new Fish("name3");

                Aquarium aq = new Aquarium("name", 5);
                aq.Add(fish3);
                aq.Add(fish2);
                aq.Add(fish1);
                aq.SellFish(nameToSell);
            });
        }

        [Test]
        public void CheckIfReportMethodWorks()
        {
            Fish fish1 = new Fish("name1");
            Fish fish2 = new Fish("name2");
            Fish fish3 = new Fish("name3");

            Aquarium aq = new Aquarium("name", 5);
            aq.Add(fish1);
            aq.Add(fish2);
            aq.Add(fish3);

            List<Fish> listOfFish = new List<Fish> { fish1, fish2, fish3 };
            string expectedfishNames = string.Join(", ", listOfFish.Select(f => f.Name));

            string expectedReport = $"Fish available at name: {expectedfishNames}";
            string actualReport = aq.Report();

            Assert.AreEqual(expectedReport, actualReport);
        }

    }
}
