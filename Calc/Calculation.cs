using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class Calculation
    {
        public Calculation() { }

        public int Plus(int x, int y)
        {
            return x + y;
        }

        public int Minus(int x, int y)
        {
            return x - y;
        }

        public int Mult(int x, int y)
        {
            return x * y;
        }

        public int Div(int x, int y)
        {
            return x / y;
        }

        public void Result(int x, int y, string action)
        {
            switch (action)
            {
                case "plus":
                    Console.WriteLine(Plus(x, y));
                    break;

                case "minus":
                    Console.WriteLine(Minus(x, y));
                    break;

                case "mult":
                    Console.WriteLine(Mult(x, y));
                    break;

                case "div":
                    Console.WriteLine(Div(x, y));
                    break;

                default:
                    Console.WriteLine("You entered a wrong key. Please try again.");
                    break;

            }
        }
    }
}
