using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Aquariums
{
    public class SaltwaterAquarium:Aquarium
    {
        public SaltwaterAquarium(string name) : base(name, 25)
        {
        }

        public override string GetInfo()
        {
            List<string> names = new List<string>();
            foreach(var f in this.Fish)
            {
                names.Add(f.Name);
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.Name} ({this.GetType().Name}):");
            if (this.Fish.Count == 0)
            {
                sb.AppendLine("Fish: none");
            }
            else
            {
                sb.AppendLine($"Fish: {String.Join(", ", names)}");
            }
            sb.AppendLine("Decorations: " + this.Decorations.Count);
            sb.AppendLine("Comfort: " + this.Comfort);
            return sb.ToString().TrimEnd();
        }
    }
}
