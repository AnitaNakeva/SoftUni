using System;
using System.Collections.Generic;
using System.Text;

namespace WarCroft.Entities.Inventory
{
    public class Backpack : Bag
    {
        private static int backPackCapacity = 100;
        public Backpack() : base(backPackCapacity)
        {
        }
    }
}
