using System;

namespace FigureArea
{
    public class SomeFigure : IFigure
    {
        private readonly IFigure figure;
        public SomeFigure(IFigure someFigure)
        {
            figure = someFigure;
        }
        public double Area
        {
            get => figure.Area;
        }
    }
}
