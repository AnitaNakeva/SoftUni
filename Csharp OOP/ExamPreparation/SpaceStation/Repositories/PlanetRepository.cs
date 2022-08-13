using SpaceStation.Models.Planets.Contracts;
using SpaceStation.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStation.Repositories
{
    public class PlanetRepository : IRepository<IPlanet>
    {
        public PlanetRepository()
        {
            this.models = new List<IPlanet>();
        }
        public IReadOnlyCollection<IPlanet> Models => this.models;

        private List<IPlanet> models = new List<IPlanet>();
        
        public void Add(IPlanet model)
        {
            this.models.Add(model);
        }

        public IPlanet FindByName(string name)
        {
            var planet = this.models.FirstOrDefault(x => x.Name == name);
            if (planet == null)
            {
                return null;
            }
            return planet;
        }

        public bool Remove(IPlanet model)
        {
            return this.models.Remove(model);
        }
    }
}
