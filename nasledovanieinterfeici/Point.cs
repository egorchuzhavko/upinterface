using System;

namespace nasledovanieinterfeici
{
    public abstract class Point
    {
        protected double x, y;

        public virtual double GetX() { return x; }
        public virtual double GetY() { return y; }

        public virtual void SetX(double x) { this.x = x; }
        public virtual void SetY(double y) { this.y = y; }


        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}