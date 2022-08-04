using System;
using System.Collections.Generic;
using System.Text;

namespace WarCroft.Entities.Inventory
{
    public class Satchel : Bag
    {
        private static int satchelCapacity = 20;
        public Satchel() : base(satchelCapacity)
        {
        }
    }
}
