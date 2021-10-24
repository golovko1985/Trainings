using System;

namespace FigureArea
{
    public class Circle : IFigure
    {
        private double radius;
        public double Radius 
        {
            get => radius;
            set
            {
                radius = IFigure.GetProperLength(value);
            }
        }
        public Circle(double r)
        {
            Radius = r;
        }

        public double Area
        {
            get
            {
                return Math.PI * Math.Pow(Radius, 2);
            }
        }
    }
}
