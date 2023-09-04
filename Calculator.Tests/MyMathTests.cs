using Xunit;

namespace Calculator.Tests
{
    public class MyMathTests
    {
        // Arrange
        // Act
        // Assert

        #region divide

        [Fact]
        public void Divide_Complete()
        {
            // Arrange
            int a = 12;
            int b = 3;

            // Act
            int c = MyMath.Divide(a, b);

            // Assert
            Assert.Equal(4, c);
        }

        [Fact]
        public void Divide_NonComplete()
        {
            int a = 16;
            int b = 5;

            int c = MyMath.Divide(a, b);

            Assert.Equal(3, c);
        }

        [Fact]
        public void Divide_ByZero_ShouldThrowException()
        {
            int a = 15;
            int b = 0;

            Assert.Throws<DivideByZeroException>(() =>
            {
                MyMath.Divide(a, b);
            });
        }

        #endregion

        #region intersection

        [Fact]
        public void Intersection_SecondLowerIsBetweenFirstLimits_True()
        {
            // Arrange
            int firstLower = 20;
            int firstUpper = 50;

            int secondLower = 30;
            int secondUpper = 70;

            // Act
            bool a = MyMath.Intersects(firstLower, firstUpper, secondLower, secondUpper);

            // Assert
            Assert.True(a);
        }

        [Fact]
        public void Intersection_SecondLowerIsGreaterThanFirstUpper_False()
        {
            // Arrange
            int firstLower = 20;
            int firstUpper = 50;

            int secondLower = 60;
            int secondUpper = 70;

            // Act
            bool a = MyMath.Intersects(firstLower, firstUpper, secondLower, secondUpper);

            // Assert
            Assert.False(a);
        }

        [Fact]
        public void Intersection_SecondIsInsideFirst_True()
        {
            // Arrange
            int firstLower = 20;
            int firstUpper = 50;

            int secondLower = 30;
            int secondUpper = 40;

            // Act
            bool a = MyMath.Intersects(firstLower, firstUpper, secondLower, secondUpper);

            // Assert
            Assert.True(a);
        }

        [Fact]
        public void Intersection_FirstLowerIsGreaterThanSecondUpper_False()
        {
            // Arrange
            int firstLower = 20;
            int firstUpper = 50;

            int secondLower = 5;
            int secondUpper = 15;

            // Act
            bool a = MyMath.Intersects(firstLower, firstUpper, secondLower, secondUpper);

            // Assert
            Assert.False(a);
        }

        [Fact]
        public void Intersection_SecondUpperIsBetweenFirstLimits_True()
        {
            // Arrange
            int firstLower = 20;
            int firstUpper = 50;

            int secondLower = 5;
            int secondUpper = 25;

            // Act
            bool a = MyMath.Intersects(firstLower, firstUpper, secondLower, secondUpper);

            // Assert
            Assert.True(a);
        }

        [Fact]
        public void Intersection_FirstIsInsideSecond_True()
        {            
            // Arrange
            int firstLower = 20;
            int firstUpper = 50;

            int secondLower = 10;
            int secondUpper = 60;

            // Act
            bool a = MyMath.Intersects(firstLower, firstUpper, secondLower, secondUpper);

            // Assert
            Assert.True(a);

        }

        #endregion
    }
}