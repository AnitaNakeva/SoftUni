using ConsoleApp143.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp143.Models
{
    public class MyList:IMyList
    {
        public List<string> Collection { get; }

        public MyList()
        {
            this.Collection = new List<string>();
        }

        public string Add(string item)
        {
            this.Collection.Insert(0, item);
            return "0";
        }

        public string Remove()
        {
            var firstEle = this.Collection.First();
            this.Collection.Remove(firstEle);
            return firstEle;
        }

        public int Used()
        {
            return this.Collection.Count;
        }
    }
}
