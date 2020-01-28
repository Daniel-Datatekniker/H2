using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class RightTriangle : Square
    {
        private double b;
        private double c;

        public double B
        {
            get { return b; }
             set { b = value; }
        }
        public double C
        {
            get { return c; }
             set { c = value; }
        }

        public RightTriangle()
        {

        }

        public RightTriangle(double aSide, double bSide, double cSide) : base(aSide)
        {
            B = bSide;
            C = cSide;
        }

        public override double Calculate(Calculation calculation)
        {
            switch (calculation)
            {
                case Calculation.Perimeter:
                    result = A + B + C;
                    break;
                case Calculation.Area:
                    result = (1 / 2) * A * b;
                    break;
                default:
                    break;
            }
            return A;
        }
    }
}
