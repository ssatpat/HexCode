using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexCode
{
    public class Hexagon
    {
        private Point _center;

        public static double pi = 3.14159;

        private double _radius;

        public Point Center { get => _center; set => _center = value; }
        public double radius { get => _radius; set => _radius = value; }


        public Hexagon(Point point, double smallD)
        {
            Center = point;
            radius = smallD / Math.Sqrt(3.0);
        }

        public Hexagon(Point point, decimal r)
        {
            Center = point;
            radius = Convert.ToDouble(r);
        }

        public double Area()
        {
            return 2.59808 * Math.Pow(radius, 2.0);
        }

        public List<Point> Vertices()
        {
            Point p1 = new Point(radius, 0.0);
            Point p2 = new Point(radius * Math.Cos(pi / 3), radius * Math.Sin(pi / 3));
            Point p3 = new Point(-1.0 * radius * Math.Cos(pi / 3), radius * Math.Sin(pi / 3));
            Point p4 = new Point(-1.0 * radius, 0.0);
            Point p5 = new Point(-1.0 * radius * Math.Cos(pi / 3), -1.0 * radius * Math.Sin(pi / 3));
            Point p6 = new Point(radius * Math.Cos(pi / 3), -1.0 * radius * Math.Sin(pi / 3));

            List<Point> vertices = new List<Point>() { p1, p2, p3, p4, p5, p6 };

            return vertices;
            
        }

        public List<Edge> Edges()
        {
            Point p1 = new Point(radius, 0.0);
            Point p2 = new Point(radius * Math.Cos(pi / 3), radius * Math.Sin(pi / 3));
            Point p3 = new Point(-1.0 * radius * Math.Cos(pi / 3), radius * Math.Sin(pi / 3));
            Point p4 = new Point(-1.0 * radius, 0.0);
            Point p5 = new Point(-1.0 * radius * Math.Cos(pi / 3), -1.0 * radius * Math.Sin(pi / 3));
            Point p6 = new Point(radius * Math.Cos(pi / 3), -1.0 * radius * Math.Sin(pi / 3));

            Edge e1 = new Edge(p1, p2);
            Edge e2 = new Edge(p2, p3);
            Edge e3 = new Edge(p3, p4);
            Edge e4 = new Edge(p4, p5);
            Edge e5 = new Edge(p5, p6);
            Edge e6 = new Edge(p6, p1);

            List<Edge> edges = new List<Edge>() { e1, e2, e3, e4, e5, e6 };

            return edges;

        }



    }
}
