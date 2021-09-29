using System;
using System.Collections.Generic;
using Xunit;

namespace BDSA2021.Assignment03.Tests
{
    public class ExtensionsTests
    {
        [Fact]
        public void FlattenTest()
        {
            // Arrange.
            IEnumerable<int>[] xs = {
                new [] { 2, 3, 6, 5 },
                new [] { 9, 7, 1, 5 }
            };

            // Act.
            IEnumerable<int> expected = new List<int> { 2, 3, 6, 5, 9, 7, 1, 5 };
            IEnumerable<int> actual = xs.Flatten();

            // Assert.
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void FilterDivisibleBy7AndGreaterThan42Test()
        {
            // Arrange.
            int[] ys = new [] { 28, 29, 35, 42, 49, 53, 63, 68, 77 };

            // Act.
            int[] expected = new [] { 49, 63, 77 };
            IEnumerable<int> actual = ys.Filter(n => (n > 42 && n % 7 == 0));

            // Assert.
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FilterIsLeapYearTest()
        {
            // Arrange.
            int[] ys = new [] { 1600, 1800, 1804, 2000, 2012, 2013 };

            // Act.
            int[] expected = new [] { 1600, 1804, 2000, 2012 };
            IEnumerable<int> actual = ys.Filter(n => (n % 400 == 0 || (n % 4 == 0 && n % 100 != 0)));

            // Assert.
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UriIsSecureTest()
        {
            // Arrange.
            Uri input = new Uri("https://itu.dk/");

            // Act.
            bool expected = true;
            bool actual = input.IsSecure();

            // Assert.
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UriIsNotSecureTest()
        {
            // Arrange.
            Uri input = new Uri("http://itu.dk/");

            // Act.
            bool expected = false;
            bool actual = input.IsSecure();

            // Assert.
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WordCountTest()
        {
            // Arrange.
            string input = "This&%string . contains .4 words";

            // Act.
            int expected = 4;
            int actual = input.WordCount();

            // Assert.
            Assert.Equal(expected, actual);
        }
    }
}
