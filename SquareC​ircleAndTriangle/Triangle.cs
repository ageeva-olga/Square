using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareC​ircleAndTriangle
{
    public class Triangle : ISquare
    {
        public Line AB { get; set; }
        public Line BC { get; set; }
        public Line CA { get; set; }
        public Triangle(Line ab, Line bc, Line ca)
        {
            AB = ab;
            BC = bc;
            CA = ca;
        }

        public double Length
        {
            get
            {
                return AB.Length + BC.Length + CA.Length;
            }
        }

        private bool IsRightTriangle()
        {
            if (Math.Pow(AB.Length, 2) == Math.Pow(BC.Length, 2) + Math.Pow(CA.Length, 2))
            {
                return true;
            }
            if (Math.Pow(BC.Length, 2) == Math.Pow(AB.Length, 2) + Math.Pow(CA.Length, 2))
            {
                var l = BC;
                BC = AB;
                AB = l;
                return true;
            }
            if (Math.Pow(CA.Length, 2) == Math.Pow(AB.Length, 2) + Math.Pow(BC.Length, 2))
            {
                var l = CA;
                CA = BC;
                BC = AB;
                AB = l;
                return true;
            }
            return false;
        }

        public double Square
        {
            get
            {
                if (IsRightTriangle())
                {
                    return BC.Length * CA.Length / 2;
                }
                else
                {
                    return Math.Sqrt((Length / 2)
                              * ((Length / 2) - AB.Length)
                              * ((Length / 2) - BC.Length)
                              * ((Length / 2) - CA.Length));
                }               
            }
        }
    }
}
