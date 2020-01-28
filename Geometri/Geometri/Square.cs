using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
   public class Square
    {
        //Attribute
        private double a = 900;
        private Calculation calculationType;
        protected double result;

        //Properties
        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public Calculation CalculationType
        {
            get { return calculationType; }
            set { calculationType = value; }
        }


        //Construtor 
        public Square(double aSide)
        {
            A = aSide;
        }

        public Square()
        {

        }

        public virtual double Calculate(Calculation calculation)
        {
            switch (calculation)
            {
                case Calculation.Perimeter:
                    A = A * 4;

                    break;
                case Calculation.Area:
                    A = A * A;
                    break;
                default:
                    break;
            }
            return A;
        }

        


    }
}
