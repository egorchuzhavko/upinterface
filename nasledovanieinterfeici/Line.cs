namespace nasledovanieinterfeici
{
    public class Line : Point
    {
        protected double x1, y1;

        public Line(double x, double y, double x1, double y1) : base(x, y)
        {
            this.x1 = x1;
            this.y1 = y1;
        }
        
        public virtual double GetX1() { return x1; }
        public virtual double GetY1() { return y1; }

        public virtual void SetX1(double x1) { this.x1 = x1; }
        public virtual void SetY1(double y1) { this.y1 = y1; }
    }
}