using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexCode
{
    public class Circles
    {
        private double _radius;
        private Point _center;

        public double radius { get => _radius; set => _radius = value; }
        public Point Center { get => _center; set => _center = value; }

        public Circles(Point c, double r)
        {
            Center = c;
            radius = r;
        }

        public override string ToString()
        {
            string coord = "(" + Convert.ToString(Center.x) + "," + Convert.ToString(Center.y) + ")";
            return coord;
        }



    }
}
