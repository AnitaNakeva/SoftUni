using NavalVessels.Models.Contracts;
using NavalVessels.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NavalVessels.Repositories
{
    public class VesselRepository : IRepository<IVessel>
    {
        public VesselRepository()
        {
            this.models = new List<IVessel>();
        }
        private List<IVessel> models;
        public IReadOnlyCollection<IVessel> Models => this.models.AsReadOnly();

        public void Add(IVessel model)
        {
            this.models.Add(model);
        }

        public IVessel FindByName(string name)
        {
            var vesselToFind = this.models.FirstOrDefault(x => x.Name == name);
            if (vesselToFind == null)
            {
                return null;
            }
            else
            {
                return vesselToFind;
            }
        }

        public bool Remove(IVessel model)
        {
            return this.models.Remove(model);
        }
    }
}
