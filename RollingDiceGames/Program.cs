﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollingDiceGames
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] numbers = new int[5] { rand.Next(1, 30), rand.Next(1, 30), rand.Next(1, 30), rand.Next(1, 30), rand.Next(1, 30)};
            Fibonacci(1, 1, 1,numbers);
            Console.ReadLine();
        }
        public static void Fibonacci(int a, int b, int count,params int[] num)
        {
            Console.WriteLine(a);
            if (count < 30)
                Fibonacci(b, a + b, count + 1,num);
        }
    }
}
