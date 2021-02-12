using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringSumKata;
using System;
using FluentAssertions;
using Xunit;

namespace StringSumKata.Tests
{
    [TestClass]
    public class UnitTests
    {
        [Fact]
        public void Should_Throw_ArgumentException_If_Argument_Is_Null()
        {
            StringSumUtility ssu = new StringSumUtility();
            Action action = () => ssu.Sum(null, "1");

            action.Should().ThrowExactly<ArgumentException>();
        }

        [Fact]
        public void Should_Throw_ArgumentException_If_Argument_Is_Empty()
        {
            StringSumUtility ssu = new StringSumUtility();
            Action action = () => ssu.Sum("", "1");

            action.Should().ThrowExactly<ArgumentException>();
        }

        [Fact]
        public void Should_Throw_ArgumentException_If_Argument_Is_Whitespace()
        {
            StringSumUtility ssu = new StringSumUtility();
            Action action = () => ssu.Sum(" ", "1");

            action.Should().ThrowExactly<ArgumentException>();
        }

        [Fact]
        public void Should_Return_Zero_If_Both_Nums_Not_Natural()
        {
            StringSumUtility ssu = new StringSumUtility();
            var result = ssu.Sum("asd", "asd");

            result.Should().Be("0");
        }
        
        [Fact]
        public void Should_Return_One_Argument_If_Another_Is_Not_Natural()
        {
            StringSumUtility ssu = new StringSumUtility();
            var result = ssu.Sum("asd", "13");

            result.Should().Be("13");
        }

        [Fact]
        public void Should_Return_Sum_Of_Arguments()
        {
            StringSumUtility ssu = new StringSumUtility();
            var result = ssu.Sum("1", "2");

            result.Should().Be("3");
        }
    }
}
