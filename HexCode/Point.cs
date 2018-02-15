using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexCode
{
    public class Point
    {
        public double x, y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double Distance(Point other)
        {
            double distance = Math.Sqrt(Math.Pow(this.x - other.x, 2.0) + Math.Pow(this.y - other.y, 2.0));

            return distance;
        }

        public override string ToString()
        {
            string coord = "(" + Convert.ToString(x) + "," + Convert.ToString(y) + ")";
            return coord;
        }

    }
}
