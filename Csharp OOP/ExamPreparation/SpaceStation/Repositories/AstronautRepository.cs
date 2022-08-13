using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStation.Repositories
{
    public class AstronautRepository : IRepository<IAstronaut>
    {
        public AstronautRepository()
        {
            this.models = new List<IAstronaut>();
        }
        private List<IAstronaut> models;
        public IReadOnlyCollection<IAstronaut> Models => this.models.AsReadOnly();

        public void Add(IAstronaut model)
        {
            this.models.Add(model);
        }

        public IAstronaut FindByName(string name)
        {
            var ast = this.models.FirstOrDefault(x => x.Name == name);
            if(ast == null)
            {
                return null;
            }
            return ast;
        }

        public bool Remove(IAstronaut model)
        {
            return this.models.Remove(model);
        }
    }
}
