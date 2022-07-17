using ConsoleApp138.Exceptions;
using ConsoleApp138.Factories.Interfaces;
using ConsoleApp138.Models.Animal;
using ConsoleApp138.Models.Food;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp138.Core
{
    public class Engine:IEngine
    {
        //TODO: Implement IO Interface
        private readonly ICollection<Animal> animals;

        private readonly IFoodFactory foodFactory;
        private readonly IAnimalFactory animalFactory;

        private Engine()
        {
            this.animals = new List<Animal>();
        }

        public Engine(IFoodFactory foodFactory, IAnimalFactory animalFactory)
            : this()
        {
            this.foodFactory = foodFactory;
            this.animalFactory = animalFactory;
        }

        public void Start()
        {
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                try
                {
                    string[] animalArgs = command
                        .Split();
                    string[] foodArgs = Console.ReadLine()
                        .Split();

                    Animal animal = BuildAnimalUsingFactory(animalArgs);
                    Food food = this.foodFactory.CreateFood(foodArgs[0], int.Parse(foodArgs[1]));

                    Console.WriteLine(animal.MakeASound());

                    this.animals.Add(animal);

                    animal.Eat(food);
                }
                catch (InvalidFactoryTypeException ifte)
                {
                    Console.WriteLine(ifte.Message);
                }
                catch (WrongType fnpe)
                {
                    Console.WriteLine(fnpe.Message);
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
            }

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        private Animal BuildAnimalUsingFactory(string[] animalArgs)
        {
            Animal animal;
            if (animalArgs.Length == 4)
            {
                string animalType = animalArgs[0];
                string animalName = animalArgs[1];
                double weight = double.Parse(animalArgs[2]);
                string thirdParam = animalArgs[3];

                animal = this.animalFactory.CreateAnimal(animalType, animalName, weight, thirdParam);
            }
            else if (animalArgs.Length == 5)
            {
                string animalType = animalArgs[0];
                string animalName = animalArgs[1];
                double weight = double.Parse(animalArgs[2]);
                string thirdParam = animalArgs[3];
                string fourthParam = animalArgs[4];

                animal = this.animalFactory.CreateAnimal(animalType, animalName, weight, thirdParam, fourthParam);
            }
            else
            {
                throw new ArgumentException("Invalid input!");
            }

            return animal;
        }
    }
}
