using Fibanocci_Solution;

namespace Fibanocci_Tests
{
    public class Fibanocci_Tests
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var fib = new Fibanocci();

            // Act
            var result = fib.Calculate(1);

            // Assert
            Assert.Equal(1, result);

        }

        [Fact]
        public void Test2()
        {
            // Arrange
            var fib = new Fibanocci();

            // Act
            var result = fib.Calculate(5);

            // Assert
            Assert.Equal(5, result);

        }

        [Fact]
        public void Test3()
        {
            // Arrange
            var fib = new Fibanocci();

            // Act
            var result = fib.Calculate(-4);

            // Assert
            Assert.Equal(-4, result);

        }

        [Fact]
        public void Test4()
        {
            // Arrange
            var fib = new Fibanocci();

            // Act
            var result = fib.Calculate(0);

            // Assert
            Assert.Equal(0, result);

        }

        [Fact]
        public void Test5()
        {
            // Arrange
            var fib = new Fibanocci();

            // Act
            var result = fib.Calculate(2);

            // Assert
            Assert.Equal(1, result);

        }
    }
}