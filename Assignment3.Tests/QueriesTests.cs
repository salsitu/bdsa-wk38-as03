using System;
using BDSA2021.Assignment03;
using System.Collections.Generic;
using Xunit;

namespace BDSA2021.Assignment03.Tests
{
    public class QueriesTests
    {
        [Fact]
        public void WizardsByRowling()
        {
            // Act.
            IEnumerable<string> expected = new List<string> { "Dumbledore", "Harry Potter" };
            var actual = Queries.WizardsByRowling_LINQ();

            // Assert.
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TheSithFirstIntroducedYear()
        {
            // Act.
            var expected = 1977;
            var actual = Queries.FirstSithYear_LINQ();

            // Assert.
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetWizardsFromHarryPotterReturnNameAndYear()
        {
            // Act.
            IEnumerable<(string, int?)> expected = new List<(string, int?)> { ("Dumbledore", 1997), ("Harry Potter", 1997) };
            var actual = Queries.FromHarryPotter_LINQ();

            // Assert.
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReverseOrderedWizardList()
        {
            // Act.
            IEnumerable<string> expected = new List<string> { "Donald John Trump", "Joseph Vissarionovich Stalin", "Mark Zuckerberg", "Sauron", "Saruman", "Gandalf", "Harry Potter", "Dumbledore", "Rasmus Paludan", "Darth Vader", "Darth Maul", "Lars Løkke Rasmussen" };
            var actual = Queries.ReverseWizardList_LINQ();

            // Assert.
            Assert.Equal(expected, actual);
        }
    }
}
