namespace nasledovanieinterfeici
{
    public class ColoredLIne : Line
    {
        protected string color;

        public ColoredLIne(double x, double y, double x1, double y1, string color) : base(x, y, x1, y1)
        {
            this.color = color;
        }
        
        public virtual string GetColor() { return color; }

        public virtual void SetColor(string color) { this.color = color; }

        public override string ToString()
        {
            return $"X1 = {GetX()}, Y1 = {GetY()}, X2 = {GetX1()}, Y2 = {GetY1()}, Color = {GetColor()}";
        }
    }
}