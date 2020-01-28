using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class Parallelogram : Square
    {
        private double b;
        private double angle;


        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public double Angle
        {
            get { return angle; }
            private set { angle = value; }
        }

        //Constructor
        public Parallelogram(double aSide, double bSide, double angleValue) : base(aSide)
        {
            b = bSide;
            Angle = angleValue;
        }

        public Parallelogram()
        {

        }
        //Methods
        public override double Calculate(Calculation calculation)
        {
            switch (calculation)
            {
                case Calculation.Perimeter:
                    result = 2 * A + 2 * b;

                    break;
                case Calculation.Area:
                    result = (A  * b) * Math.Sin(angle * Math.PI / 180);
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
