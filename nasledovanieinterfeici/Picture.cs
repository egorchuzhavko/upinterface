using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace nasledovanieinterfeici
{
    public class Picture
    {
        protected List<ColoredPoint> listofcoloredpoints;
        protected List<Line> listoflines;
        protected List<ColoredLIne> listofcoloredlines;
        protected List<Polygon> listofpolygons;

        public Picture(List<ColoredPoint> lcp, List<Line> ll,
            List<ColoredLIne> lcl, List<Polygon> lpp)
        {
            this.listofcoloredpoints = lcp;
            this.listoflines = ll;
            this.listofcoloredlines = lcl;
            this.listofpolygons = lpp;
        }

        public override string ToString()
        {
            string infoofcoloredpoints = "";
            foreach (var VARIABLE in listofcoloredpoints)
            {
                infoofcoloredpoints += VARIABLE.ToString() + "\n";
            }

            string infooflines = "";
            foreach (var VARIABLE in listoflines)
            {
                infooflines += VARIABLE.ToString() + "\n";
            }

            string infoofcoloredlines = "";
            foreach (var VARIABLE in listofcoloredlines)
            {
                infoofcoloredlines += VARIABLE.ToString() + "\n";
            }

            string infoofpolygons = "";
            foreach (var VARIABLE in listofpolygons)
            {
                infoofpolygons += VARIABLE.ToString() + "\n";
            }

            return $"Info about list of colored points:\n{infoofcoloredpoints}\n" +
                   $"Info about list of lines:\n{infooflines}\n" +
                   $"Info about list of colored lines:\n{infoofcoloredlines}\n" +
                   $"Info about list of polygons:\n{infoofpolygons}\n";
        }
    }
}