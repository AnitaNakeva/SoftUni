using Gym.Models.Equipment;
using Gym.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym.Repositories
{
    public class EquipmentRepository : IRepository<Equipment>

    {
        private List<Equipment> models = new List<Equipment>();
        public IReadOnlyCollection<Equipment> Models => this.models.AsReadOnly();

        public void Add(Equipment model)
        {
            this.models.Add(model);
        }

        public Equipment FindByType(string type)
        {
            var modelOfTheType = this.models.FirstOrDefault(x => x.GetType().Name == type);
            return modelOfTheType;
        }

        public bool Remove(Equipment model)
        {
            return models.Remove(model);
        }
    }
}
