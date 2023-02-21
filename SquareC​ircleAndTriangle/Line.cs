using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareC​ircleAndTriangle
{
    public class Line
    {
        public Point FirstPoint;
        public Point SecondPoint;
        public Line(Point p1, Point p2)
        {
            FirstPoint = p1;
            SecondPoint = p2;
        }

        public double Length
        {
            get
            {
                return Math.Sqrt(Math.Pow((SecondPoint.X - FirstPoint.X), 2)
                                 + Math.Pow((SecondPoint.Y - FirstPoint.Y), 2));
            }
        }
    }
}
