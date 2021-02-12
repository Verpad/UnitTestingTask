using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FizzBuzzKata;
using Xunit;
using FluentAssertions;

namespace FizzBuzzKata.Tests
{
    public class UnitTests
    {
        [Fact]
        public void Should_Return_100_Elements()
        {
            FizzBuzzUtility fbu = new FizzBuzzUtility();
            int elementsCount = fbu.GenerateElements().Length;

            elementsCount.Should().Be(100);
        }

        [Fact]
        public void Should_Return_Fizz_At_Every_Third_And_Not_Fifteenth_Position()
        {
            FizzBuzzUtility fbu = new FizzBuzzUtility();
            string[] elements = fbu.GenerateElements();

            bool isRight = true;
            for (int i = 2; i < elements.Length; i = i + 3)
            {
                if ((i+1)%15 !=0 && elements[i] != "Fizz")
                {
                    isRight = false;
                    break;
                }
            }

            isRight.Should().Be(true);
        }

        [Fact]
        public void Should_Return_Buzz_At_Every_Fifth_And_Not_Fifteenth_Position()
        {
            FizzBuzzUtility fbu = new FizzBuzzUtility();
            string[] elements = fbu.GenerateElements();

            bool isRight = true;
            for (int i = 4; i < elements.Length; i = i + 5)
            {
                if ((i + 1) % 15 != 0 && elements[i] != "Buzz")
                {
                    isRight = false;
                    break;
                }
            }

            isRight.Should().Be(true);
        }

        [Fact]
        public void Should_Return_FizzBuzz_At_Every_Fifteenth_Position()
        {
            FizzBuzzUtility fbu = new FizzBuzzUtility();
            string[] elements = fbu.GenerateElements();

            bool isRight = true;
            for (int i = 14; i < elements.Length; i = i + 15)
            {
                if (elements[i] != "FizzBuzz")
                {
                    isRight = false;
                    break;
                }
            }

            isRight.Should().Be(true);
        }
    }
}
