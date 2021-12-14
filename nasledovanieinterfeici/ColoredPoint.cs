namespace nasledovanieinterfeici
{
    public class ColoredPoint : Point
    {
        protected string color;
        public ColoredPoint(double x, double y, string color) : base(x, y)
        {
            this.color = color;
        }
        
        public virtual string GetColor() { return color; }

        public virtual void SetColor(string color) { this.color = color; }

        public override string ToString()
        {
            return $"X = {GetX()}, Y = {GetY()}, Color = {GetColor()}";
        }
    }
}