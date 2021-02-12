using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FluentAssertions;
using Xunit;

namespace CalcStatsKata.Tests
{
    public class UnitTests
    {
        [Fact]
        public void Should_Throw_ArgumentNullExeption_If_Argument_Is_Null()
        {
            CalcStatsUtility csu = new CalcStatsUtility();
            Action action = () => csu.ProcessElements(null);

            action.Should().ThrowExactly<ArgumentNullException>();
        }

        [Fact]
        public void Should_Return_Zero_ElementsCount_If_Process_Empty_Array()
        {
            CalcStatsUtility csu = new CalcStatsUtility();
            int[] elements = { };
            csu.ProcessElements(elements);

            csu.ElementsCount.Should().Be(0);
        }

        [Fact]
        public void Should_Return_Certain_Max_Value()
        {
            CalcStatsUtility csu = new CalcStatsUtility();
            int[] elements = {-1,2,0,4,5};
            csu.ProcessElements(elements);

            csu.MaxValue.Should().Be(5);
        }

        [Fact]
        public void Should_Return_Certain_Min_Value()
        {
            CalcStatsUtility csu = new CalcStatsUtility();
            int[] elements = { -1, 2, 0, 4, 5 };
            csu.ProcessElements(elements);

            csu.MaxValue.Should().Be(-1);
        }

        [Fact]
        public void Should_Return_Certain_Average_Value()
        {
            CalcStatsUtility csu = new CalcStatsUtility();
            int[] elements = { -1, 2, 0, 4, 5 };
            csu.ProcessElements(elements);

            csu.AverageValue.Should().Be(2.0);
        }
    }
}
