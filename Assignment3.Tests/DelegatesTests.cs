using System;
using System.IO;
using Xunit;

namespace BDSA2021.Assignment03.Tests
{
    public class DelegatesTests
    {
        [Fact]
        public void StringFormatterReverse()
        {
            // Arrange.
            StringWriter writer = new StringWriter();
            Console.SetOut(writer);

            // Act.
            Program.Reverse();

            string expected = "esreveR";
            string actual = writer.ToString();


            // Assert.
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DecimalProduct()
        {
            // Arrange.
            decimal x = 2.5M;
            decimal y = 5.5M;
            Func<decimal, decimal, decimal> product = (x, y) => x * y;

            // Act.
            decimal expected = 13.75M;
            decimal actual = product(x, y);

            // Assert.
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsNumericallyEqualReturnsTrue()
        {
            // Arrange.
            string str = " 0042";
            int num = 42;

            // Act.
            bool expected = true;
            bool actual = Program.IsNumericallyEqual(str, num);

            // Assert.
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsNumericallyEqualReturnsFalse()
        {
            // Arrange.
            string str = " 0053";
            int num = 42;

            // Act.
            bool expected = false;
            bool actual = Program.IsNumericallyEqual(str, num);

            // Assert.
            Assert.Equal(expected, actual);
        }
    }
}
