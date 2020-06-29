using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SampleApp.xUnitTest
{
    public class TestTheory
    {

        [Theory]
        [InlineData(1,3)]
        [InlineData(4,5)]
        public void TestAddition(int a, int b)
        {

            Assert.True(a + b > 0);
        }
    }
}
