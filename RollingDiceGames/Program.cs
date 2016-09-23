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
            Random rand = new Random();
            List<List<int>> set = new List<List<int>>();
            int k = rand.Next(1, 10);
            Console.WriteLine("K=" + k);
            for (int i = 0; i < k; i++)
                set.Add(numbers.GenerateNumbers());

            foreach (List<int> n in set)
            {
                 
                int nonSawElem = numbers.Check(n);
                Console.Write("Length={0} Set=", n.Count);
                foreach (int num in n)
                {
                    Console.Write(num + " ");
                }
                Console.Write("Non Saw Elem = " + nonSawElem);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
