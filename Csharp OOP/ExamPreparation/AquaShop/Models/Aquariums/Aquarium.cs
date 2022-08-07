using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Aquariums
{
    public abstract class Aquarium : IAquarium
    {
        public Aquarium(string name, int capacity)
        {
            this.Name = name;
            this.decorations = new List<IDecoration>();
            this.fish = new List<IFish>();
            this.Capacity = capacity;
        }

        private List<IDecoration> decorations;
        private List<IFish> fish;
        public Aquarium()
        {

        }

        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Aquarium name cannot be null or empty.");

                }
                this.name = value;
            }
        }

        public int Capacity
        {
            get; private set;
        }


        public int Comfort
        {
            get
            {
                int sum = 0;
                foreach(var d in this.decorations)
                {
                    sum += d.Comfort;
                }
                return sum;
            }
        }

        public ICollection<IDecoration> Decorations => this.decorations;

        public ICollection<IFish> Fish => this.fish;

        public void AddDecoration(IDecoration decoration)
        {
            this.decorations.Add(decoration);
        }

        public void AddFish(IFish fish)
        {
            if(this.fish.Count+1<=this.Capacity)
            {
                this.fish.Add(fish);
            }
            else
            {
                throw new InvalidOperationException("Not enough capacity.");
            }
        }

        public void Feed()
        {
            foreach(var f in this.fish)
            {
                f.Eat();
            }
        }

        public abstract string GetInfo();

        public bool RemoveFish(IFish fish)
        {
            bool canWeRemove = this.fish.Remove(fish);
            return canWeRemove;
        }
    }
}
