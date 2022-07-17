using ConsoleApp138.Core;
using ConsoleApp138.Factories;
using ConsoleApp138.Factories.Interfaces;
using System;

namespace ConsoleApp138
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            IFoodFactory foodFactory = new FoodFactory();
            IAnimalFactory animalFactory = new AnimalFactory();

            IEngine engine = new Engine(foodFactory, animalFactory);
            engine.Start();
        }
    }
}
