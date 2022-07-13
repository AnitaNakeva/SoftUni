using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp61
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split().ToArray();
            Queue<string> kids = new Queue<string>(names);
            int n = int.Parse(Console.ReadLine());
            while (kids.Count > 1)
            {
                for (int i = 1; i < n; i++)
                {
                    string kid = kids.Dequeue();
                    kids.Enqueue(kid);
                }
                string kidToGo = kids.Dequeue();
                Console.WriteLine("Removed " + kidToGo);
            }
            Console.WriteLine("Last is " + kids.Dequeue());

        }
    }
}
