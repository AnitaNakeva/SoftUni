using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Mission.Contracts;
using SpaceStation.Models.Planets.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStation.Models.Mission
{
    public class Mission : IMission
    {
        public Mission()
        {

        }
        public void Explore(IPlanet planet, ICollection<IAstronaut> astronauts)
        {
           
            List<string> itemsToRemove = new List<string>();
            foreach(var ast in astronauts)
            {
                foreach(var item in planet.Items)
                {
                    ast.Breath();
                        ast.Bag.Items.Add(item);
                        itemsToRemove.Add(item);
                    if(!ast.CanBreath)
                    {
                        break;
                    }
                }

                foreach(var item in itemsToRemove)
                {
                    planet.Items.Remove(item);
                }
                itemsToRemove.Clear();
            }
        }
    }
}
