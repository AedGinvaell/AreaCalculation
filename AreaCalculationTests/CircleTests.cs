namespace SquareCalculationTests
{
    public class CircleTests
    {
        [Fact]
        public void ZeroRadiusAreaCalculation()
        {
            // Arrange
            // Act
            // Assert
            Assert.Equal(0, Circle.AreaCalculation(0));
        }

    }
}