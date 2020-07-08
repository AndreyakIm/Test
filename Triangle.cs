using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingArea
{
    public class Triangle : Figure
    {
        private double sideA, sideB, sideC;

        public double SideA
        {
            get { return sideA; }
            set { sideA = value < 0 ? -value : value; }
        }

        public double SideB
        {
            get { return sideB; }
            set { sideB = value < 0 ? -value : value; }
        }

        public double SideC
        {
            get { return sideC; }
            set { sideC = value < 0 ? -value : value; }
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)
            {
                SideA = sideA;
                SideB = sideB;
                SideC = sideC;
            }
            else
            {
                Console.WriteLine("It is not a triangle");
                return;

            }
        }

        public override double Area()
        {
            double Perimeter = (SideA + SideB + SideC) / 2;
            return (Math.Sqrt(Perimeter * (Perimeter - SideA) * (Perimeter - SideB) * (Perimeter - SideC)));

        }

        public bool CheckTriangle()
        {
            if (SideA * SideA == (SideB * SideB + SideC * SideC) || SideB * SideB == (SideC * SideC + SideA * SideA) ||
                SideC * SideC == (SideB * SideB + SideA * SideA))
                return (true);

            return (false);

        }

    }
}
