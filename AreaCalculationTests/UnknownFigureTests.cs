namespace AreaCalculationTests
{
    public class UnknownFigureTests
    {
        #region Круг

        [Fact]
        public void CircleAreaCalculation_EqualZero()
        {
            // Arrange
            // Act
            // Assert
            Assert.Equal(0, UnknownFigure.AreaCalculation(0));
        }

        [Fact]
        public void CircleAreaCalculation_Equal1()
        {
            // Arrange
            // Act
            // Assert
            Assert.Equal(3.1415, UnknownFigure.AreaCalculation(1));
        }

        [Fact]
        public void CircleAreaCalculation_Equal2()
        {
            // Arrange
            // Act
            // Assert
            Assert.Equal(15.90384375, UnknownFigure.AreaCalculation(2.25));
        }

        [Fact]
        public void CircleAreaCalculation_NotEqual1()
        {
            // Arrange
            // Act
            // Assert
            Assert.NotEqual(3.141, UnknownFigure.AreaCalculation(1));
        }
        [Fact]
        public void CircleAreaCalculation_NotEqual2()
        {
            // Arrange
            // Act
            // Assert
            Assert.NotEqual(15.9, UnknownFigure.AreaCalculation(2));
        }

        #endregion

        #region Треугольник

        [Fact]
        public void TriangleAreaCalculation_FalseCheck1()
        {
            // Arrange
            // Act
            // Assert
            Assert.Equal(0, UnknownFigure.AreaCalculation(3, 4, 7));
        }

        [Fact]
        public void TriangleAreaCalculation_FalseCheck2()
        {
            // Arrange
            // Act
            // Assert
            Assert.Equal(0, UnknownFigure.AreaCalculation(0, 1, 0));
        }

        [Fact]
        public void TriangleAreaCalculation_NotEqualZero1()
        {
            // Arrange
            // Act
            // Assert
            Assert.NotEqual(0, UnknownFigure.AreaCalculation(7, 7, 7));
        }

        [Fact]
        public void TriangleAreaCalculation_NotEqualZero2()
        {
            // Arrange
            // Act
            // Assert
            Assert.NotEqual(0, UnknownFigure.AreaCalculation(5, 3, 4));
        }

        [Fact]
        public void TriangleAreaCalculation_Equal1()
        {
            // Arrange
            // Act
            // Assert
            Assert.Equal(21.21762239271875, UnknownFigure.AreaCalculation(7, 7, 7));
        }

        [Fact]
        public void TriangleAreaCalculation_Equal2()
        {
            // Arrange
            // Act
            // Assert
            Assert.Equal(6, UnknownFigure.AreaCalculation(3, 4, 5));
        }

        #endregion
    }
}
