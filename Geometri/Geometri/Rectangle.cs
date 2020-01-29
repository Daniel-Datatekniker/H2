using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class Rectangle : Square
    {
        //Attribute
        private double h;


        //Properties
        public double H
        {
            get { return h; }
            set { h = value; }
        }
        //Constructor
        public Rectangle()
        {
        }
        public Rectangle(double aSide, double Height) : base(aSide)
        {
            H = Height;
        }

        //Methods
        public override double Calculate(Calculation calculation)
        {
            switch (calculation)
            {
                case Calculation.Perimeter:
                    result = H * A;
                    break;
                case Calculation.Area:
                    result = A * A;
                    break;
            default:
                    break;

        }
            return result;
        }
    }
}
