using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp137.Core
{
    using Models;
    using Factory;
    public class Engine : IEngine
    {

        public void Start()
        {
            List<BaseHero> heroes = new List<BaseHero>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string nameOfHero = Console.ReadLine();
                string typeOfHero = Console.ReadLine();

                try
                {
                    IHeroFactory heroFactory = new HeroFactory();
                    BaseHero hero = heroFactory.CreateHero(nameOfHero, typeOfHero);
                    Console.WriteLine(hero.CastAbility());
                    heroes.Add(hero);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    n++;
                }
            }
            long totalPower = 0;
            foreach(var hero in heroes)
            {
                totalPower += hero.Power;
            }

            long bossesPower = long.Parse(Console.ReadLine());
            if (totalPower >= bossesPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
