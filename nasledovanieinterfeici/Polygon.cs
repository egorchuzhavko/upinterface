using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace nasledovanieinterfeici
{
    public class Polygon
    {
        protected List<Line> polygon;
        
        public Polygon(List<Line> polygon)
        {
            this.polygon = polygon;
        }

        public virtual List<Line> GetPolygon() { return polygon; }

        public virtual void SetPolygon(List<Line> polygon) { this.polygon = polygon; }

        public override string ToString()
        {
            string infoofpolygon = "";
            foreach (var VARIABLE in polygon)
            {
                infoofpolygon += VARIABLE.ToString() + "\n";
            }
            return infoofpolygon;
        }
    }
}