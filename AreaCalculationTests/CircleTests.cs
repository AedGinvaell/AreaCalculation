namespace AreaCalculationTests
{
    public class CircleTests
    {
        [Fact]
        public void AreaCalculation_Equal0()
        {
            // Arrange
            // Act
            // Assert
            Assert.Equal(0, Circle.AreaCalculation(0));
        }

        [Fact]
        public void AreaCalculation_Equal1()
        {
            //Arrange
            //Act
            //Assert
            Assert.Equal(3.1415, Circle.AreaCalculation(1));
        }
        [Fact]
        public void AreaCalculation_Equa2()
        {
            //Arrange
            //Act
            //Assert
            Assert.Equal(15.90384375, Circle.AreaCalculation(2.25));
        }

        [Fact]
        public void AreaCalculation_NotEqual1()
        {
            //Arrange
            //Act
            //Assert
            Assert.NotEqual(3.141, Circle.AreaCalculation(1));
        }
    }
}