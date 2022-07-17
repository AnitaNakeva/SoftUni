using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp138.Models.Animal.Mammals
{
    using Food;
    public class Tiger:Felice
    {
        private const double tigerWeightMult = 1;
        public Tiger(string name, double weight, string LivingRegion, string breed) : base(name, weight, LivingRegion, breed)
        {
        }

        protected override double WeightMultiplier => tigerWeightMult;

        protected override IReadOnlyCollection<Type> PrefferType => new List<Type> { typeof(Meat) }.AsReadOnly();

        public override string MakeASound()
        {
            return "ROAR!!!";
        }
    }
}
