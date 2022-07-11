using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculationTests
{
    public class TriangleTests
    {
        #region Проверка на то, что введённые числа являются треугольником

        [Fact]
        public void CheckTriangle_False1()
        {
            // Arrange
            // Act
            // Assert
            Assert.False(Triangle.Check(3,4,7));
        }

        [Fact]
        public void CheckTriangle_False2()
        {
            // Arrange
            // Act
            // Assert
            Assert.False(Triangle.Check(0, 0, 1));
        }
        [Fact]
        public void CheckTriangle_False3()
        {
            // Arrange
            // Act
            // Assert
            Assert.False(Triangle.Check(5.7, 35.1, 12));
        }
        // Египетский треугольник
        [Fact]
        public void CheckTriangle_True1()
        {
            // Arrange
            // Act
            // Assert
            Assert.True(Triangle.Check(5,3,4));
        }
        // Равносторнний треугольник
        [Fact]
        public void CheckTriangle_True2()
        {
            // Arrange
            // Act
            // Assert
            Assert.True(Triangle.Check(7, 7, 7));
        }

        [Fact]
        public void CheckTriangle_True3()
        {
            // Arrange
            // Act
            // Assert
            Assert.True(Triangle.Check(5.25, 6.98, 3.402));
        }

        #endregion

        #region Проверка треугольника на прямоугольность

        // Не является треугольником
        [Fact]
        public void CheckRightTriangle_False1()
        {
            // Arrange
            // Act
            // Assert
            Assert.False(Triangle.RightCheck(2, 3, 1));
        }

        // Равносторонний треугольник
        [Fact]
        public void CheckRightTriangle_False2()
        {
            // Arrange
            // Act
            // Assert
            Assert.False(Triangle.RightCheck(7,7,7));
        }

        // Прямоугольный треугольник (Египетский)
        [Fact]
        public void CheckRightTriangle_True1()
        {
            // Arrange
            // Act
            // Assert
            Assert.True(Triangle.RightCheck(4,5,3));
        }

        [Fact]
        public void CheckRightTriangle_True2()
        {
            // Arrange
            // Act
            // Assert
            Assert.True(Triangle.RightCheck(10,6,8));
        }


        #endregion

        #region Вычисление площади треугольника по формуле Герона без проверки
        
        [Fact]
        public void AreaCalculationWithoutChecks_NotEqual1()
        {
            // Arrange
            // Act
            // Assert
            Assert.NotEqual(6.26, Triangle.HeronsFormula(5, 3, 4));
        }

        [Fact]
        public void AreaCalculationWithoutChecks_NotEqual2()
        {
            // Arrange
            // Act
            // Assert
            Assert.NotEqual(21, Triangle.HeronsFormula(7, 7, 7));
        }

        [Fact]
        public void AreaCalculstionWithoutCheck_NotEqual3()
        {
            Assert.NotEqual(15.4919333848, Triangle.HeronsFormula(3, 4, 9));
        }

        [Fact]
        public void AreaCalculationWithoutCheck_Equal1()
        {
            // Arrange
            // Act
            // Assert
            Assert.Equal(6, Triangle.HeronsFormula(5, 3, 4));
        }
        [Fact]
        public void AreaCalculationWithoutChecks_Equal2()
        {
            // Arrange
            // Act
            // Assert
            Assert.Equal(21.21762239271875, Triangle.HeronsFormula(7, 7, 7));
        }

        #endregion

        #region Вычисление площади треугольника по формуле Герона с предварительной проверкой

        [Fact]
        public void AreaCalculation_FalseCheck1()
        {
            // Arrange
            // Act
            // Assert
            Assert.Equal(0, Triangle.AreaCalculation(3, 4, 7));
        }

        [Fact]
        public void AreaCalculation_FalseCheck2()
        {
            // Arrange
            // Act
            // Assert
            Assert.Equal(0, Triangle.AreaCalculation(0, 0, 1));
        }

        [Fact]
        public void AreaCalculation_NotEqualZero1()
        {
            // Arrange
            // Act
            // Assert
            Assert.NotEqual(0, Triangle.AreaCalculation(7,7,7));
        }

        [Fact]
        public void AreaCalculation_NotEqualZero2()
        {
            // Arrange
            // Act
            // Assert
            Assert.NotEqual(0, Triangle.AreaCalculation(5, 3, 4));
        }

        [Fact]
        public void AreaCalculation_Equal1()
        {
            // Arrange
            // Act
            // Assert
            Assert.Equal(21.21762239271875, Triangle.AreaCalculation(7, 7, 7));
        }

        [Fact]
        public void AreaCalculation_Equal2()
        {
            // Arrange
            // Act
            // Assert
            Assert.Equal(6, Triangle.AreaCalculation(3, 4, 5));
        }

        #endregion
    }
}
