using System;

namespace FigureArea
{
    public interface IFigure
    {
        double Area { get; }

        static double GetProperLength(double arg)
        {
            if (Constants.MaxLength > arg && arg > Constants.MinLength)
                return arg;
            else throw new ArgumentOutOfRangeException();
        }
    }
}
