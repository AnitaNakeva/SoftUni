using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp136.Models
{
    public abstract class Vehicle : IVehicle
    {
        private double tankCapacity;
        private double fuelQuantity;
        private double fuelConsumption;

        private Vehicle()
        {
            this.FuelConsumptionModifier = 0;
        }

        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : this()
        {
            this.FuelQuantity = fuelQuantity > tankCapacity ? 0 : fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        public double TankCapacity
        {
            get
            {
                return this.tankCapacity;
            }
            set
            {
                this.tankCapacity = value;
            }

        }

        public double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }
            private set
            {
                //if (value >= this.TankCapacity)
                //{
                //    this.fuelQuantity = 0;
                //}
                //else
                //{
                //    this.fuelQuantity = value;
                //}
                this.fuelQuantity = value;
            }
        }

        public double FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }
            protected set
            {
                this.fuelConsumption = value + this.FuelConsumptionModifier;
            }
        }

        protected virtual double FuelConsumptionModifier { get; }

        public virtual string Drive(double distance)
        {
            double fuelNeeded = distance*this.FuelConsumption;
            if (fuelNeeded > this.FuelQuantity)
            {
                return $"{this.GetType().Name} needs refueling";
            }

            this.FuelQuantity -= fuelNeeded;
            return $"{this.GetType().Name} travelled {distance} km";
        }

        public virtual void Refuel(double liters)
        {
            if(liters<=0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            else if (this.FuelQuantity + liters > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {liters} fuel in the tank");
            }
            else
            {
                this.FuelQuantity += liters;
            }
        }

        public virtual string DriveEmpty(double distance)
        {
            double fuelNeeded = distance * (FuelConsumption-FuelConsumptionModifier);
            if (fuelNeeded > this.FuelQuantity)
            {
                return $"{this.GetType().Name} needs refueling";
            }

            this.FuelQuantity -= fuelNeeded;
            return $"{this.GetType().Name} travelled {distance} km";
        }
        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
