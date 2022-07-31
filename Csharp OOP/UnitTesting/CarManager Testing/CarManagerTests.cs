namespace CarManager.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class CarManagerTests
    {
        [TestCase("a", "b", 1, 2)]
        public void MakingCarWithCorrectData(string make, string model, double fuelConsumption, double fuelCapacity)
        {
            Assert.DoesNotThrow(() =>
            {
                Car car = new Car(make, model, fuelConsumption, fuelCapacity);
            });
        }

        [TestCase(null, "b", 1, 2)]
        [TestCase("a", null, 1, 2)]
        [TestCase("a", "b", -1, 2)]
        [TestCase("a", "b", 0, 2)]
        [TestCase("a", "b", 1, -1)]
        public void MakingCarShouldThrowExceptionWithIncorrectData(string make, string model, double fuelConsumption, double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Car car = new Car(make, model, fuelConsumption, fuelCapacity);
            });
        }

        [TestCase("car", "b", 1, 20, 5, 6)]
        public void RefuelingTheCar(string make, string model, double fuelConsumption,
            double fuelCapacity, double fuelToRefuel1, double fuelToRefuel2)
        {
            Car car = new Car(make, model, fuelConsumption, fuelCapacity);
            car.Refuel(fuelToRefuel1);
            car.Refuel(fuelToRefuel2);
            double expectedFuel = fuelToRefuel1 + fuelToRefuel2;

            Assert.AreEqual(expectedFuel, car.FuelAmount);
        }

        [TestCase("car", "b", 1, 10, 5, 6)]
        public void RefuelingTheCarWithMoreFuelThanTheCapacity(string make, string model, double fuelConsumption,
            double fuelCapacity, double fuelToRefuel1, double fuelToRefuel2)
        {
            Car car = new Car(make, model, fuelConsumption, fuelCapacity);
            car.Refuel(fuelToRefuel1);
            car.Refuel(fuelToRefuel2);
            double expectedFuel = 10;

            Assert.AreEqual(expectedFuel, car.FuelAmount);
        }

        [TestCase("car", "b", 1, 10, -1)]
        [TestCase("car", "b", 1, 10, 0)]
        public void RefuelingWithZeroOrLessFuel(string make, string model, double fuelConsumption,
            double fuelCapacity, double fuelToRefuel)
        {
            Car car = new Car(make, model, fuelConsumption, fuelCapacity);
            Assert.Throws<ArgumentException>(() =>
            {
                car.Refuel(fuelToRefuel);
            }, "Fuel amount cannot be zero or negative!");
        }

        [TestCase("car", "b", 1, 20, 500, 15)]
        public void DrivingTheCar(string make, string model, double fuelConsumption,
            double fuelCapacity, double distance, double amountToAdd)
        {
            Car car = new Car(make, model, fuelConsumption, fuelCapacity);
            car.Refuel(amountToAdd);
            car.Drive(distance);
            double expectedFuelAmount = 10;

            Assert.AreEqual(expectedFuelAmount, car.FuelAmount);
        }

        [TestCase("car", "b", 1, 20, 500, 3)]
        public void DrivingTheCarMoreThanTheAmount(string make, string model, double fuelConsumption,
            double fuelCapacity, double distance, double amountToAdd)
        {
            Car car = new Car(make, model, fuelConsumption, fuelCapacity);
            car.Refuel(amountToAdd);

            Assert.Throws<InvalidOperationException>(() =>
            {
                car.Drive(distance);
            }, "You don't have enough fuel to drive!");
        }
    }
}