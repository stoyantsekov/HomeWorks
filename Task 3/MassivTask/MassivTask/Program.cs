﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassivTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masSym = { 1, 2, 3, 4, 3, 2, 1 };
            bool sym = true;
            for
                (int i = 0; i < masSym.Length - i - 1; ++i)
            {
                sym = sym && masSym[i] == masSym[masSym.Length - i - 1];
            }
            Console.WriteLine("Symetric?  {0}", sym);
            Console.ReadKey();
        }
    }
}
