using System;

namespace nasledovanieinterfeici
{
    public abstract class Point
    {
        protected double x, y;
        protected string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

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

        public Point(double x, double y, string color)
        {
            X = x;
            Y = y;
            Color = color;
        }
    }
}