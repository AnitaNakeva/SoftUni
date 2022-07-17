using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp138.Models.Animal
{
    using Food;
    using Exceptions;
    public abstract class Animal
    {
        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }
        public virtual void Eat(Food food)
        {
            if (!PrefferType.Contains(food.GetType()))
            {
                throw new WrongType(String.Format(ExceptionMessages.WrongFood,this.GetType().Name,food.GetType().Name));
            }
            this.FoodEaten += food.Quantity;
            this.Weight += food.Quantity * this.WeightMultiplier;
        }
        protected abstract double WeightMultiplier { get;}
        public abstract string MakeASound();
        protected abstract IReadOnlyCollection<Type> PrefferType { get; }
        public int FoodEaten { get; set; }
        public double Weight { get; set; }
        public string Name { get; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, ";
        }
    }
}
