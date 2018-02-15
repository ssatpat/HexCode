using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexCode
{
    class Program
    {
        static void Main(string[] args)
        {
            double smallD = 3.10;
            double circleR = 0.14;
            Point center = new Point(0.0, 0.0);

            Hexagon bigH = new Hexagon(center, smallD);

            List<Point> vertices = bigH.Vertices();

            List<Circles> circles = new List<Circles>();

            Circles centerCircle = new Circles(bigH.Center, circleR);

            circles.Add(centerCircle);

            decimal pitch = 0.3971M;

            Hexagon h1 = new Hexagon(bigH.Center, pitch);
            Hexagon h2 = new Hexagon(bigH.Center, pitch * 2);
            Hexagon h3 = new Hexagon(bigH.Center, pitch * 3);
            Hexagon h4 = new Hexagon(bigH.Center, pitch * 4);

            for (int i = 0; i < 6; i++)
            {
                Circles c1 = new Circles(h1.Vertices()[i], circleR);
                circles.Add(c1);

                Circles c2 = new Circles(h2.Vertices()[i], circleR);
                circles.Add(c2);

                Circles c3 = new Circles(h3.Vertices()[i], circleR);
                circles.Add(c3);

                Circles c4 = new Circles(h4.Vertices()[i], circleR);
                circles.Add(c4);
            }

            //Add first level hex intercepts
            List<Edge> h2Edges = h2.Edges();
            List<Point> h2_intercepts = new List<Point>();
            for (int i = 0; i < 6; i++)
            {
                h2_intercepts.AddRange(h2Edges[i].intercepts(h2Edges[i].P1,h2Edges[i].P2,2));
            }

            for (int i = 0; i < 6; i++)
            {
                Circles c5 = new Circles(h2_intercepts[i], circleR);
                circles.Add(c5);

            }

            //Add second level hex intercepts
            List<Edge> h3Edges = h3.Edges();
            List<Point> h3_intercepts = new List<Point>();
            for (int i = 0; i < 6; i++)
            {
                h3_intercepts.AddRange(h3Edges[i].intercepts(h3Edges[i].P1, h3Edges[i].P2, 3));
            }
            for (int i = 0; i < h3_intercepts.Count; i++)
            {
                Circles c6 = new Circles(h3_intercepts[i], circleR);
                circles.Add(c6);

            }

            //Add third level hex intercepts
            List<Edge> h4Edges = h4.Edges();
            List<Point> h4_intercepts = new List<Point>();
            for (int i = 0; i < 6; i++)
            {
                h4_intercepts.AddRange(h4Edges[i].intercepts(h4Edges[i].P1, h4Edges[i].P2, 4));
            }
            for (int i = 0; i < h4_intercepts.Count; i++)
            {
                Circles c7 = new Circles(h4_intercepts[i], circleR);
                circles.Add(c7);

            }


            foreach (Circles c in circles)
            {
                Console.WriteLine(c);

            }
            Console.WriteLine(circles.Count);

            //foreach (Point p in h2_intercepts)
            //{
            //    Console.WriteLine(p);

            //}



            Console.ReadLine();
        }
    }
}
