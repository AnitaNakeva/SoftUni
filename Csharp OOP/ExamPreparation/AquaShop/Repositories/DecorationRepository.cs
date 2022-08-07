using AquaShop.Models.Decorations;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Repositories
{
    public class DecorationRepository : IRepository<IDecoration>
    {
        private List<IDecoration> models;

        public DecorationRepository()
        {
            this.models = new List<IDecoration>();
        }
        public IReadOnlyCollection<IDecoration> Models => this.models.AsReadOnly();

        public object FirstOrDefault { get; internal set; }

        public void Add(IDecoration model)
        {
            this.models.Add(model);
        }

        public IDecoration FindByType(string type)
        {
            var modelToFind = this.models.FirstOrDefault(x => x.GetType().Name == type);
            if(modelToFind==null)
            {
                return null;
            }
            return modelToFind;
        }

        public bool Remove(IDecoration model)
        {
            bool canWeRemove = this.models.Remove(model);
            return canWeRemove;
        }
    }
}
