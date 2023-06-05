using CalculateFiguresLibrary.AbstractFigures;

namespace CalculateFiguresLibrary.Figures
{
    public class Circle : Figure
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateSquare()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        }
    }
}
