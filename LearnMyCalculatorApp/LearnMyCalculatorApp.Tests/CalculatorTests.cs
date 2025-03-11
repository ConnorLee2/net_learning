using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearnMyCalculatorApp;

namespace LearnMyCalculatorApp.Tests
{
    [TestClass]
    public sealed class CalculatorTests
    {
        [TestMethod]
        public void CalculatorNullTest()
        {
            var calculator = new Calculator();

            Assert.IsNotNull(calculator);
        }

        [TestMethod()]
        public void AddTest()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Add(1, 1);

            // Assert
            Assert.AreEqual(2, actual);
        }

        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(3, 3, 6)]
        public void AddDataTests(int x, int y, int expected)
        {
            var calculator = new Calculator();
            var actual = calculator.Add(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Subtract(1, 1);

            // Assert
            Assert.AreEqual(0, actual);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Multiply(1, 1);

            // Assert
            Assert.AreEqual(1, actual);
        }

        [TestMethod()]
        public void DivideByZeroTest()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Divide(4, 0);

            // Assert
            Assert.IsNull(actual);
        }

        [TestMethod()]
        public void DivideTest()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Divide(1, 1);

            // Assert
            Assert.AreEqual(1, actual);
        }
    }
}
