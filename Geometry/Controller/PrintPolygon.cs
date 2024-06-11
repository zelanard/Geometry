using Geometry.Model;
using Geometry.Model.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometry.Model;
using Geometry.Model.Shapes;
using Geometry.Model.Shapes.Triangles;

namespace Geometry.Controller
{
    public class PrintPolygon
    {
        List<Polygon> Polygons = new List<Polygon>();
        public void Run()
        {
            Polygons.Add(new Square(4));
            Polygons.Add(new Parallelogram(3, 4, 20));
            Polygons.Add(new Rectangle(2, 5));
            Polygons.Add(new Trapezoid(8, 10, 9));
            Polygons.Add(new RightAngle(3, 4));

            foreach (Polygon p in Polygons)
            {
                switch (p)
                {
                    case Square SQ:
                        Console.WriteLine("Square");
                        Console.WriteLine("Area: " + SQ.Area());
                        Console.WriteLine("Circumfence: " + SQ.Circumfence());
                        Console.WriteLine();
                        break;
                    case Parallelogram PA:
                        Console.WriteLine("Parallelogram");
                        Console.WriteLine("Area: " + PA.Area());
                        Console.WriteLine("Circumfence: " + PA.Circumfence());
                        Console.WriteLine();
                        break;
                    case Rectangle RE:
                        Console.WriteLine("Rectangle");
                        Console.WriteLine("Area: " + RE.Area());
                        Console.WriteLine("Circumfence: " + RE.Circumfence());
                        Console.WriteLine();
                        break;
                    case Trapezoid TR:
                        Console.WriteLine("Trapezoid");
                        Console.WriteLine("Area: " + TR.Area());
                        Console.WriteLine("Circumfence: " + TR.Circumfence());
                        Console.WriteLine();
                        break;
                    case RightAngle RA:
                        Console.WriteLine("RightAngle");
                        Console.WriteLine("Area: " + RA.Area());
                        Console.WriteLine("Circumfence: " + RA.Circumfence());
                        Console.WriteLine();
                        break;
                }
            }
            Console.ReadKey();

        }
    }
}
