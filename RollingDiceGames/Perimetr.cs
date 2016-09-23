using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollingDiceGames
{
    class Perimetr
    {
        public void Sum(params Point[] points)
        {
            double sum = 0;
            for (int i = 0; i < points.Length - 1 ;i++ )
            {
                sum += Math.Sqrt(Math.Pow(points[i + 1].X - points[i].X, 2) + Math.Pow(points[i + 1].Y - points[i].Y, 2));
                if (i == points.Length - 2)
                    sum += Math.Sqrt(Math.Pow(points[i + 1].X - points[0].X, 2) + Math.Pow(points[i + 1].Y - points[0].Y, 2));
                
            }

            Console.WriteLine("Sum=" + sum);
        }
    }
}
