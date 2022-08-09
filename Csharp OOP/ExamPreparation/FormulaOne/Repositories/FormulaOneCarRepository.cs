using Formula1.Models.Contracts;
using Formula1.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Formula1.Repositories
{
    public class FormulaOneCarRepository : IRepository<IFormulaOneCar>
    {
        public FormulaOneCarRepository()
        {
            this.models = new List<IFormulaOneCar>();
        }

        private List<IFormulaOneCar> models;
        public IReadOnlyCollection<IFormulaOneCar> Models => this.models.AsReadOnly();

        public void Add(IFormulaOneCar model)
        {
            this.models.Add(model);
        }

        public IFormulaOneCar FindByName(string name)
        {
            var modelToFind = this.models.FirstOrDefault(x => x.Model == name);
            if(modelToFind==null)
            {
                return null;
            }
            return modelToFind;
        }

        public bool Remove(IFormulaOneCar model)
        {
            return this.models.Remove(model);
        }
    }
}
