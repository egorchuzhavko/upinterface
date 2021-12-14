using System;

namespace nasledovanieinterfeici
{
    public abstract class Point
    {
        protected double x, y;
        protected string color;

        public virtual double GetX() { return x; }
        public virtual double GetY() { return y; }
        public virtual string GetColor() { return color; }

        public virtual void SetX(double x) { this.x = x; }
        public virtual void SetY(double y) { this.y = y; }
        public virtual void SetColor(string color) { this.color = color; }


        public Point(double x, double y, string color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
        }
    }
}