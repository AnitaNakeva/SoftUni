using System;

namespace ConsoleApp137
{
    using Core;
    using Factory;
    using Models;
    using System.Collections.Generic;

    public class StartUp
    {
        
        static void Main(string[] args)
        {

            IEngine engine = new Engine();
            engine.Start();
            
        }
    }
}
