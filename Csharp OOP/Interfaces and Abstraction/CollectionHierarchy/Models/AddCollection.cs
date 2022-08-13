using ConsoleApp143.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp143
{
    public class AddCollection:IAddCollection
    {
        public AddCollection()
        {
            this.Collection = new List<string>();
        }

        public List<string> Collection { get; }

        public string Add(string item)
        {
            this.Collection.Add(item);

            return (this.Collection.Count - 1).ToString();
        }
    }
}
