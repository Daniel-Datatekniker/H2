using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class Program
    {
        static void Main(string[] args)
        {
            Messages messages = new Messages();
            #region Square
            List<Square> squares = new List<Square>();
            Square Trapz = new Trapez();
            Square Rectangle = new Rectangle();
            Square Paralell = new Parallelogram();
            RightTriangle triangle = new RightTriangle();
            bool done = false;


            squares.Add(Trapz);
            squares.Add(Rectangle);
            squares.Add(Paralell);
            squares.Add(triangle);

            do
            {
                foreach (Square square in squares)
                {


                    try
                    {
                        Console.Clear();

                        if (square is Trapez)
                        {
                            //double aSide, double bSide, double cSide, double dSide
                            Console.Write($"Please input value A,B,C,D to get the Area of a tranpez\nA value = ");
                            (((Trapez)square).A) = Int32.Parse(Console.ReadLine());
                            Console.Write("B value = ");
                            (((Trapez)square).B) = Int32.Parse(Console.ReadLine());
                            Console.Write("C value = ");
                            (((Trapez)square).C) = Int32.Parse(Console.ReadLine());
                            Console.Write("D value = ");
                            (((Trapez)square).D) = Int32.Parse(Console.ReadLine());


                            Console.Write($"{messages.Message(Calculation.Area)} {((Trapez)square).Calculate(Calculation.Area)}");

                        }
                        else if (square is Rectangle)
                        {
                            Console.Write($"Please input value A,B to get the Area & Perimeter of a rectangle\nA value = ");
                            (((Rectangle)square).A) = Int32.Parse(Console.ReadLine());
                            Console.Write("B value = ");
                            (((Rectangle)square).H) = Int32.Parse(Console.ReadLine());
                            Console.Write($"{messages.Message(Calculation.Area)} {((Rectangle)square).Calculate(Calculation.Area)}\n");
                            Console.Write($"{messages.Message(Calculation.Perimeter)} {((Rectangle)square).Calculate(Calculation.Perimeter)}");
                        }
                        else if (square is Parallelogram)
                        {
                            Console.Write($"Please input value A,B to get the Area & Perimeter of a Parallelogram\nA value = ");
                            (((Parallelogram)square).A) = Int32.Parse(Console.ReadLine());
                            Console.Write("H value = ");
                            (((Parallelogram)square).B) = Int32.Parse(Console.ReadLine());
                            Console.Write($"{messages.Message(Calculation.Area)} {((Parallelogram)square).Calculate(Calculation.Area)}\n");
                            Console.Write($"{messages.Message(Calculation.Perimeter)} {((Parallelogram)square).Calculate(Calculation.Perimeter)}");
                        }
                        else if (square is RightTriangle)
                        {
                            Console.Write($"Please input value A,B to get the Area & Perimeter of a Right Triangle\nA value = ");
                            (((RightTriangle)square).A) = Int32.Parse(Console.ReadLine());
                            Console.Write("B value = ");
                            (((RightTriangle)square).B) = Int32.Parse(Console.ReadLine());
                            Console.Write("C value = ");
                            (((RightTriangle)square).C) = Int32.Parse(Console.ReadLine());
                        }

                        Console.ReadKey();
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Wrong input, Press any key to continue");
                        Console.ReadKey();
                    }


                }
            } while (done == false);

            #endregion


            Console.ReadLine();
        }
    }
}
