using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp137.Factory
{
    using Models;
    internal interface IHeroFactory
    {
        BaseHero CreateHero(string name, string type);
    }
}
