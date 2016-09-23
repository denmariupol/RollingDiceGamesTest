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
            Point A = new Point(-6.46f, 1.93f);
            Point B = new Point(-0.83f, -7.67f);
            Point C = new Point(-9.29f, 0.34f);
            Point D = new Point(-3.68f, -5.72f);
            Perimetr perimetr = new Perimetr();
            perimetr.Sum(A, B, C);
            perimetr.Sum(A, B, D);
            perimetr.Sum(A, C, D);
            
            Console.ReadLine();
        }
    }
}
