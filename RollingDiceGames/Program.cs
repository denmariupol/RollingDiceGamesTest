using System;
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
            Numbers numbers = new Numbers();
            List<List<int>> set = new List<List<int>>();
            Random rand = new Random();
            int k = rand.Next(1, 10);
            Console.WriteLine("k = " + k);
            for (int i = 0;i < k;i++)
                set.Add(numbers.GenerateNumbers());
            foreach (List<int> n in set)
            {
                Console.Write("Length=" + n.Count + "  Set=");
                numbers.Check(n);
                foreach(int num in n)
                    Console.Write( num+" ");
                Console.WriteLine("Count = " + numbers.Count);
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
