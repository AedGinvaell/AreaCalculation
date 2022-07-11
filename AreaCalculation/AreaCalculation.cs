namespace AreaCalculation
{
    public class AreaCalculation
    {
        public AreaCalculation(double radius) 
            => Circle.AreaCalculation(radius);

        public AreaCalculation(double sideA, double sideB, double sideC)
            => Triangle.AreaCalculation(sideA, sideB, sideC);
    }

}


