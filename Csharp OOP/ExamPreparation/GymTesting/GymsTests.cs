using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gyms.Tests
{
    public class GymsTests
    {
        //Athelete Testing

        [TestCase("name")]
        public void CheckIfTheAthletesConstructorWorks(string name)
        {
            Assert.DoesNotThrow(() =>
            {
                Athlete athlete = new Athlete(name);
            });
        }

        [TestCase("name")]
        public void CheckIfTheAthleteFullNamePropertyWorks(string name)
        {
            Athlete athlete = new Athlete(name);
            string expectedName = "name";
            string actualName = athlete.FullName;

            Assert.AreEqual(expectedName, actualName);
        }

        [TestCase("name")]
        public void CheckIfTheAthleteIsInjuredPropertyWorks(string name)
        {
            Athlete athlete = new Athlete(name);
            bool expectedInjured = false;
            bool actualInjured = athlete.IsInjured;

            Assert.AreEqual(expectedInjured, actualInjured);
        }

        //Gym Testing

        [TestCase("name",15)]
        public void CheckIfTheGymConstructorWorks(string name, int size)
        {
            Assert.DoesNotThrow(() =>
            {
                Gym gym = new Gym(name, size);
            });
        }

        [TestCase("name", 15)]
        public void CheckIfTheGymNamePropertyWorksWithCorrectData(string name, int size)
        {
            Gym gym = new Gym(name, size);
            string expectedName = "name";
            string actualName = gym.Name;

            Assert.AreEqual(expectedName, actualName);
        }

        [TestCase(null, 15)]
        [TestCase("", 15)]
        public void CheckIfTheGymNamePropertyWorksWithIncorrectData(string name, int size)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                Gym gym = new Gym(name, size);
            }, nameof(name), "Invalid gym name.");
        }

        [TestCase("name", 15)]
        public void CheckIfTheGymCapacityPropertyWorksWithCorrectData(string name, int size)
        {
            Gym gym = new Gym(name, size);
            int expectedCapacity = 15;
            int actualCapacity = gym.Capacity;

            Assert.AreEqual(expectedCapacity, actualCapacity);
        }

        [TestCase("name", -1)]
        [TestCase("name", -15)]
        public void CheckIfTheGymCapacityPropertyWorksWithIncorrectData(string name, int size)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Gym gym = new Gym(name, size);
            }, "Invalid gym capacity.");
        }

        [TestCase("name", 3)]
        public void CheckIfCountPropertyWorks(string name, int size)
        {
            Gym gym = new Gym(name, size);
            Athlete athlete1 = new Athlete("Athlete1");
            Athlete athlete2 = new Athlete("Athlete2");
            gym.AddAthlete(athlete1);
            gym.AddAthlete(athlete2);
            int expectedCount = 2;
            int actualCount = gym.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestCase("Name","Name2")]
        public void CheckIfAddAthleteMethodWorksWhenThereIsSpace(string nameAth,string nameAth2)
        {
            Gym gym = new Gym("Gym", 5);
            Athlete athlete1 = new Athlete(nameAth);
            Athlete athlete2 = new Athlete(nameAth2);
            List<Athlete> listOfAthletes = new List<Athlete> { athlete1, athlete2 };
            gym.AddAthlete(athlete1);
            gym.AddAthlete(athlete2);

            Assert.AreEqual(listOfAthletes.Count, gym.Count);
        }

        [TestCase("Name", "Name2")]
        public void CheckIfAddAthleteMethodThrowExceptionWhenFull(string nameAth, string nameAth2)
        {
            Gym gym = new Gym("Gym", 1);
            Athlete athlete1 = new Athlete(nameAth);
            Athlete athlete2 = new Athlete(nameAth2);
            gym.AddAthlete(athlete1);

            Assert.Throws<InvalidOperationException>(() =>
            {
                gym.AddAthlete(athlete2);
            }, "The gym is full.");
        }

        [TestCase("name1","name2")]
        public void CheckIfRemoveAthleteMethodWorksWithCorrectData(string nameAth, string nameAth2)
        {
            Gym gym = new Gym("Gym", 5);
            Athlete athlete1 = new Athlete(nameAth);
            Athlete athlete2 = new Athlete(nameAth2);
            List<Athlete> listOfAthletes = new List<Athlete> { athlete1, athlete2 };
            gym.AddAthlete(athlete1);
            gym.AddAthlete(athlete2);
            gym.RemoveAthlete(nameAth);
            listOfAthletes.Remove(athlete1);

            Assert.AreEqual(listOfAthletes.Count, gym.Count);
        }

        [TestCase("name","name2")]
        public void CheckIfRemoveAthleteMethodThrowsExceptionWithIncorrectData(string nameAth, string nameAth2)
        {
            Gym gym = new Gym("Gym", 5);
            Athlete athlete1 = new Athlete(nameAth);
            Athlete athlete2 = new Athlete(nameAth2);
            gym.AddAthlete(athlete1);
            gym.AddAthlete(athlete2);

            Assert.Throws<InvalidOperationException>(() =>
            {
                gym.RemoveAthlete("someName");
            }, $"The athlete someName doesn't exist.");
        }

        [TestCase("name1","name2")]
        public void CheckIfInjureAthleteMethodWorksWithCorrectData(string nameAth, string nameAth2)
        {
            Gym gym = new Gym("Gym", 5);
            Athlete athlete1 = new Athlete(nameAth);
            Athlete athlete2 = new Athlete(nameAth2);
            gym.AddAthlete(athlete1);
            gym.AddAthlete(athlete2);

            var injuredAthlete = gym.InjureAthlete(nameAth);

            Assert.AreEqual(athlete1, injuredAthlete);
        }

        [TestCase("name1", "name2")]
        public void CheckIfInjureAthleteMethodThrowsExceptionWithIncorrectData(string nameAth, string nameAth2)
        {
            Gym gym = new Gym("Gym", 5);
            Athlete athlete1 = new Athlete(nameAth);
            Athlete athlete2 = new Athlete(nameAth2);
            gym.AddAthlete(athlete1);
            gym.AddAthlete(athlete2);

            Assert.Throws<InvalidOperationException>(() =>
            {
                var injuredAthlete = gym.InjureAthlete("someName");
            }, "The athlete someName doesn't exist.");
        }
        [TestCase("name1", "name2", "name3", "name4")]
        public void CheckIfReportMethodWorks(string nameAth, string nameAth2, string nameAth3, string nameAth4)
        {
            string gymName = "Gym";
            Gym gym = new Gym(gymName, 5);
            Athlete athlete1 = new Athlete(nameAth);
            Athlete athlete2 = new Athlete(nameAth2);
            Athlete athlete3 = new Athlete(nameAth3);
            Athlete athlete4 = new Athlete(nameAth4);
            Athlete[] listOfAthletes = new Athlete[3] { athlete1, athlete3, athlete4 };
            string expectedAthleteNames = string.Join(", ", listOfAthletes.Where(x => !x.IsInjured).Select(f => f.FullName));
            string expectedReport = $"Active athletes at {gymName}: {expectedAthleteNames}";

            gym.AddAthlete(athlete1);
            gym.AddAthlete(athlete2);
            gym.AddAthlete(athlete3);
            gym.AddAthlete(athlete4);

            gym.InjureAthlete(nameAth2);

            Assert.AreEqual(expectedReport, gym.Report());
        }
    }
}
