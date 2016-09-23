using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollingDiceGames
{
    class Point
    {
        private double x, y;
        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public Point (float x,float y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
