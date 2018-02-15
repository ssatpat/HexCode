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
            Hexagon h2 = new Hexagon(bigH.Center, pitch*2);
            Hexagon h3 = new Hexagon(bigH.Center, pitch * 3);
            Hexagon h4 = new Hexagon(bigH.Center, pitch * 4);


            for (int i = 0; i < 6; i++)
            {
                Circles c1 = new Circles(h1.Vertices()[i], circleR);
                Circles c2 = new Circles(h2.Vertices()[i], circleR);
                Circles c3 = new Circles(h3.Vertices()[i], circleR);
                Circles c4 = new Circles(h4.Vertices()[i], circleR);

                circles.Add(c1);
                circles.Add(c2);
                circles.Add(c3);
                circles.Add(c4);

            }

            foreach (Circles c in circles)
            {
                Console.WriteLine(c);

            }
            Console.WriteLine(circles.Count);


            Console.ReadLine();
        }
    }
}
