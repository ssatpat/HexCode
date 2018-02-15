using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexCode
{
    public class Edge
    {
        private Point p1;
        private Point p2;

        public Point P1 { get => p1; set => p1 = value; }
        public Point P2 { get => p2; set => p2 = value; }

        public double length()
        {
            return P1.Distance(P2);
        }

        public Edge(Point point1, Point point2)
        {
            P1 = point1;
            P2 = point2;
        }

        public List<Point> intercepts(Point p1, Point p2, int num)
        {
            List<Point> intercepts = new List<Point>();
            if(num == 2)
            {
                Point bisect = new Point((p1.x + p2.x) / 2, (p1.y + p2.y) / 2);
                intercepts.Add(bisect);
            }
            if(num == 3)
            {
                Point trisect1 = new Point((p1.x + p2.x) / 3, (p1.y + p2.y) / 3);
                Point trisect2 = new Point(2*(p1.x + p2.x) / 3, 2*(p1.y + p2.y) / 3);
                intercepts.Add(trisect1);
                intercepts.Add(trisect2);
            }
            if(num == 4)
            {
                Point quadsect1 = new Point((p1.x + p2.x) / 4, (p1.y + p2.y) / 4);
                Point quadsect2 = new Point(2*(p1.x + p2.x) / 4, 2*(p1.y + p2.y) / 4);
                Point quadsect3 = new Point(3*(p1.x + p2.x) / 4, 3*(p1.y + p2.y) / 4);
                intercepts.Add(quadsect1);
                intercepts.Add(quadsect2);
                intercepts.Add(quadsect3);
            }

            return intercepts;
        }

        public override string ToString()
        {
            string coord1 = "(" + Convert.ToString(P1.x) + "," + Convert.ToString(P1.y) + ")";
            string coord2 = "(" + Convert.ToString(P2.x) + "," + Convert.ToString(P2.y) + ")";
            string dist = Convert.ToString(length());

            return coord1 + " " + coord2 + " " + dist;
        }


    }
}
