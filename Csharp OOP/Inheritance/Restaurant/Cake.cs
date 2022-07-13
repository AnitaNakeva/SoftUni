using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Cake : Dessert
    {
        private const double Grams = 250;
        private const double Calories = 250;
        private const decimal CakePrice = 5M;
        public Cake(string name) : base(name, CakePrice, Grams, Calories)
        {
        }
    }
}
