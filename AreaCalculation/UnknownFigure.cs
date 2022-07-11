namespace AreaCalculation
{
    public class UnknownFigure
    {
        public static double AreaCalculation(double radius) 
            => Circle.AreaCalculation(radius);

        public static double AreaCalculation(double sideA, double sideB, double sideC)
            => Triangle.AreaCalculation(sideA, sideB, sideC);
    }

}


