using System;
using System.Collections.Generic;

namespace nasledovanieinterfeici
{
    class Program
    {
        static void Main(string[] args)
        {
            ColoredPoint cp1 = new ColoredPoint(1.3, 5.2, "Yellow");
            ColoredPoint cp2 = new ColoredPoint(4, 4, "Green");
            cp1.SetX(1.1);
            cp2.SetY(6);
            Console.WriteLine(cp1);
            Console.WriteLine(cp2);

            Console.WriteLine();
            Line l1 = new Line(1, 1, 5, 4);
            Line l2 = new Line(3, 1, 5, 5);
            Line l3 = new Line(3, 5, 1, 2);
            Line l4 = new Line(7, 8, 7, 6);
            Line l5 = new Line(4, 5, 1, 1);
            Line l6 = new Line(1, 2, 3, 4);
            l1.SetX1(4);
            l2.SetY(3);
            Console.WriteLine(l1);
            Console.WriteLine(l2);

            Console.WriteLine();
            ColoredLIne cl1 = new ColoredLIne(3, 3, 4, 5, "Purple");
            ColoredLIne cl2 = new ColoredLIne(6, 3, 2, 4, "Orange");
            cl1.SetColor("SkyBlue");
            cl2.SetColor("Red");
            Console.WriteLine(cl1);
            Console.WriteLine(cl2);

            Console.WriteLine();
            List<Line> listoflines = new List<Line>();
            listoflines.Add(l3);
            listoflines.Add(l5);
            listoflines.Add(l2);
            Polygon poly1 = new Polygon(listoflines);
            Console.WriteLine(poly1);

            Console.WriteLine();
            List<Line> listoflines2 = new List<Line>();
            listoflines2.Add(l1);
            listoflines2.Add(l4);
            List<Line> listoflines3 = new List<Line>();
            listoflines3.Add(l3);
            listoflines3.Add(l4);
            listoflines3.Add(l5);
            List<Polygon> listofpolygons = new List<Polygon>();
            listofpolygons.Add(new Polygon(listoflines2));
            listofpolygons.Add(new Polygon(listoflines3));
            
            List<ColoredPoint> listofcoloredpoints = new List<ColoredPoint>();
            listofcoloredpoints.Add(cp1);
            listofcoloredpoints.Add(cp2);
            
            List<ColoredLIne> listofcoloredlines = new List<ColoredLIne>();
            listofcoloredlines.Add(cl1);
            listofcoloredlines.Add(cl2);

            Picture picture = new Picture(listofcoloredpoints, listoflines, listofcoloredlines, listofpolygons);
            Console.WriteLine(picture);
        }
    }
}