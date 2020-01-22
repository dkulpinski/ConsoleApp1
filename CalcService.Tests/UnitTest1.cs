using System;
using Xunit;
using ConsoleApp1;

namespace CalcService.Tests
{
    public class UnitTest1
    {

        private readonly Calculator _calc;

        public UnitTest1()
        {
            _calc = new Calculator();
        }

        [Fact]
        public void IsAddCorrect_ReturnTrue()
        {
            var result = _calc.add(4,5);

            Assert.True(result == 9, "4 + 5 = 9");
        }

     
    }
}
