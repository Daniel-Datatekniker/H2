using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class Square
    {
        //Attribute
        private double a = 900;
        private Boxes type = Boxes.Square;

        //Properties
        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public Boxes Type
        {
            get { return type; }
        }


        //Construtor 
        public Square(double squareA)
        {
            A = squareA;
        }



        public double Perimeter()
        {
            return A * 4;
        }



    }
}
