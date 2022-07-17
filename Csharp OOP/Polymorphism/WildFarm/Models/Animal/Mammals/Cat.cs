using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp138.Models.Animal.Mammals
{

    using Food;
    public class Cat : Felice
    {
        private const double catWeightMult = 0.3;
        public Cat(string name, double weight, string LivingRegion, string breed) : base(name, weight, LivingRegion, breed)
        {
        }

        protected override double WeightMultiplier => catWeightMult;

        protected override IReadOnlyCollection<Type> PrefferType => new List<Type> { typeof(Vegetable), typeof(Meat) }.AsReadOnly();

        public override string MakeASound()
        {
            return "Meow";
        }
    }
}
