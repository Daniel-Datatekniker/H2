using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class Trapez : Square
    {
        //Attributes
        private double b;
        private double c;
        private double d;
        private double h;
        private double s;

        //Properties
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
        public double D
        {
            get { return d; }
            set { d = value; }
        }
        public double H
        {
            get { return h; }
          

        }
        //Constructor
        public Trapez()
        {

        }

        public Trapez(double aSide, double bSide, double cSide, double dSide) : base(aSide)
        {
            
            B = bSide;
            C = cSide;
            D = dSide;
        }

        public override double Calculate(Calculation calculation)
        {
            switch (calculation)
            {
                case Calculation.Perimeter:


                    break;
                case Calculation.Area:
                    s = (A + B - C + D) / 2;

                 h = 2 / (A - c) * Math.Sqrt(s * (s - A + C) * (s - B) * (s - d));

                    result = 0.5 * (A - C) * h;

                  
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
