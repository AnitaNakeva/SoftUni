﻿using ConsoleApp143.Models;
using System;
using System.Collections.Generic;

namespace ConsoleApp143
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var addCollection = new AddCollection();
            var addRemoveCollection = new AddRemoveCollection();
            var myList = new MyList();
            var inputArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var amountToRemove = int.Parse(Console.ReadLine());
            var addCResult = new List<string>();
            var addRcResult = new List<string>();
            var mLResult = new List<string>();

            foreach (var arg in inputArgs)
            {
                addCResult.Add(addCollection.Add(arg));
                addRcResult.Add(addRemoveCollection.Add(arg));
                mLResult.Add(myList.Add(arg));
            }

            Console.WriteLine(string.Join(" ", addCResult));
            Console.WriteLine(string.Join(" ", addRcResult));
            Console.WriteLine(string.Join(" ", mLResult));
            addRcResult.Clear();
            mLResult.Clear();
            for (int i = 0; i < amountToRemove; i++)
            {
                addRcResult.Add(addRemoveCollection.Remove());
                mLResult.Add(myList.Remove());
            }
            Console.WriteLine(string.Join(" ", addRcResult));
            Console.WriteLine(string.Join(" ", mLResult));
        }
    }
}

