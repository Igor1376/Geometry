﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер фигуры: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++) Console.Write(" "); Console.Write("/");
                for (int j = 0; j < i; j++) Console.Write("  ");Console.Write("\\");
                Console.WriteLine();
            }
            for (int i = 0;i < n; i++)
            {
                for (int j = 0; j <= i; j++) Console.Write(" "); Console.Write("\\");
                for (int j = i; j < n-1; j++) Console.Write("  "); Console.Write("/");
                Console.WriteLine();
            }

        }
    }
}
