using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Bags;
using SpaceStation.Models.Bags.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStation.Models.Astronauts
{
    public abstract class Astronaut : IAstronaut
    {
        public Astronaut(string name, double oxygen)
        {
            this.Name = name;
            this.Oxygen = oxygen;
            this.Bag = new Backpack();
        }

        private string name;
        private double oxygen;
        public string Name
        {
            get { return this.name; }
            private set 
            { 
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Astronaut name cannot be null or empty.");
                }
                this.name = value; 
            }
        }

        public double Oxygen
        {
            get { return this.oxygen; }
            protected set
            {
                if (value<0)
                {
                    throw new ArgumentException("Cannot create Astronaut with negative oxygen!");
                }
                this.oxygen = value;
            }
        }
        private bool canbreath()
        {
            return this.Oxygen > 0;
        }

        public bool CanBreath => this.canbreath();

        private IBag bag;
        public IBag Bag { get
            {
                return this.bag;
            }
                 set
            {
                this.bag = value;
            }
}

        public virtual void Breath()
        {
            this.Oxygen -= 10;
            if(this.Oxygen<0)
            {
                this.Oxygen = 0;
            }
        }
    }
}
