using ConsoleApp143.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp143.Models
{
    public class AddRemoveCollection:IAddRemoveCollection
    {
        public AddRemoveCollection()
        {
            this.Collection = new List<string>();
        }

        public List<string> Collection { get; }

        public string Add(string item)
        {
            this.Collection.Insert(0, item);
            return "0";
        }

        public string Remove()
        {
            var lastItem = this.Collection.Last();
            this.Collection.Remove(lastItem);
            return lastItem;
        }
    }
}
