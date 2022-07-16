using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp136.Models
{
    public class Bus:Vehicle
    {
        private double busFuelConsumptionIncrement = 1.4;
        public double BusFuelConsumptionIncrement
        {
            get
            {
                return busFuelConsumptionIncrement;
            }
            set
            {
                this.busFuelConsumptionIncrement = value;
            }
        }

        
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {

        }

        protected override double FuelConsumptionModifier
            => BusFuelConsumptionIncrement;
    }
}
