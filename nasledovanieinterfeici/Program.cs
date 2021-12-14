using System;

namespace nasledovanieinterfeici
{
    class Program
    {
        static void Main(string[] args)
        {
            ColoredPoint nw = new ColoredPoint(12, 13, "qwe");
            Console.WriteLine(nw.GetColor());
        }
    }
}