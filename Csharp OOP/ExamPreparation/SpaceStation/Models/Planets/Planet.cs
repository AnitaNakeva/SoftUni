using SpaceStation.Models.Planets.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStation.Models.Planets
{
    public class Planet : IPlanet
    {
        public Planet(string name)
        {
            this.Name = name;
            this.items = new List<string>();
        }
        public ICollection<string> Items => this.items;

        private List<string> items;
        private string name;
        public string Name
        {
            get { return this.name; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Invalid name!");
                }
                this.name = value;
            }
        }
    }
}
