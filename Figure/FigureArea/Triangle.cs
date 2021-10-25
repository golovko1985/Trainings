using System;

namespace FigureArea
{
    public class Triangle : IFigure
    {
        private double sideA;
        private double sideB;
        private double sideC;
        public double SideA {
            get => sideA;
            set {sideA = IFigure.GetProperLength(value);}
        }
        public double SideB
        {
            get => sideB;
            set {sideB = IFigure.GetProperLength(value);}
        }
        public double SideC
        {
            get => sideC;
            set { sideC = IFigure.GetProperLength(value);}
        }

        public Triangle(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }

        public double Area
        {
            get
            {
                double halfPerim = (SideA + SideB + SideC) / 2;
                if(halfPerim < SideA || halfPerim < SideB || halfPerim < SideC)
                    throw new ArgumentOutOfRangeException("Triangle does not exist with such sides");
                // Heron's formula:
                return Math.Sqrt(halfPerim * (halfPerim - SideA) * (halfPerim - SideB) * (halfPerim - SideC));
            }
        }
        public static bool NearlyEqual(double a, double b, double diff)
        {
            if (a != b)
            {
                return Math.Abs(a - b) < diff;
            }
            return true;
        }

        public bool HasRightAngle()
        {
            double squareA = Math.Pow(SideA, 2);
            double squareB = Math.Pow(SideB, 2);
            double squareC = Math.Pow(SideC, 2);
            
            return (NearlyEqual(SideA, Math.Sqrt(squareB + squareC), Constants.Epsilon)
                 || NearlyEqual(SideB, Math.Sqrt(squareA + squareC), Constants.Epsilon)
                 || NearlyEqual(SideC, Math.Sqrt(squareA + squareB), Constants.Epsilon));
        }



    }
}
