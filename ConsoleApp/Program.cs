﻿using System;
using WrappedArrayIndexer;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] nums =
            {
                {"0,0","1,0","2,0","3,0","4,0" },
                {"0,1","1,1","2,1","3,1","4,1" },
                {"0,2","1,2","2,2","3,2","4,2" },
                {"0,3","1,3","2,3","3,3","4,3" },
                {"0,4","1,4","2,4","3,4","4,4" },
                {"0,5","1,5","2,5","3,5","4,5" }
            };
            Console.WriteLine(nums.Wrap<string>(-8,12));

            Console.Read();
        }
    }
}