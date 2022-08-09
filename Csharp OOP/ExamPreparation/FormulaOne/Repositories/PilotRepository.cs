using Formula1.Models.Contracts;
using Formula1.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Formula1.Repositories
{
    public class PilotRepository : IRepository<IPilot>
    {
        public PilotRepository()
        {
            this.models = new List<IPilot>();
        }

        private List<IPilot> models;
        public IReadOnlyCollection<IPilot> Models => this.models.AsReadOnly();

        public void Add(IPilot model)
        {
            this.models.Add(model);
        }

        public IPilot FindByName(string name)
        {
            var modelToFind = this.models.FirstOrDefault(x => x.FullName == name);
            if (modelToFind == null)
            {
                return null;
            }
            return modelToFind;
        }

        public bool Remove(IPilot model)
        {
            return this.models.Remove(model);
        }
    }
}
