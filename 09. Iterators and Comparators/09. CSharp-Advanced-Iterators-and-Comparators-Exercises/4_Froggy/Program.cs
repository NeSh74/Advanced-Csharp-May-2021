﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _4_Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> stones = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            Lake lake = new Lake(stones);

            Console.WriteLine(string.Join( ", ", lake));
        }
    }
}
