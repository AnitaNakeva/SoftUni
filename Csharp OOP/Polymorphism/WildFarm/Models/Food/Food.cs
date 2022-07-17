using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp138.Models.Food
{
    public abstract class Food
    {
        public Food(int quantity)
        {
            this.Quantity =
                quantity;
        }
        public int Quantity { get;}
    }
}
