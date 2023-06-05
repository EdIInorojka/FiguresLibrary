using CalculateFiguresLibrary.AbstractFigures;

namespace CalculateFiguresLibrary.Figures
{
    public class Triangle : Figure
    {
        public double Side1 { get; }
        public double Side2 { get; }
        public double Side3 { get; }

        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public override double CalculateSquare()
        {
            if (IsTriangle(Side1, Side2, Side3))
            {
                double halfPerimeter = (Side1 + Side2 + Side3) / 2;

                double square = Math.Round(Math.Sqrt(halfPerimeter *
                    (halfPerimeter - Side1) *
                    (halfPerimeter - Side2) *
                    (halfPerimeter - Side3)), 2);
                return square;
            }
            else
            {
                throw new Exception("Эта фигура не является треугольником");
            }
        }

        public bool IsTriangle(double side1, double side2, double side3)
        {
            if (side1 + side2 > side3 &&
                side2 + side3 > side1 &&
                side1 + side3 > side2)
            {
                return true;
            }
            else { return false; }
        }

    }
}
