using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace SampleApp.xUnitTest
{
    public class LifeCycle : IDisposable
    {
        public readonly ITestOutputHelper output;

        public string result;

        public LifeCycle(ITestOutputHelper output)
        {
            result += "Setup ";
            this.output = output;

        }

        [Fact]
        public void testme()
        {
            result += "testme ";
            Assert.True(true);
        }

        [Fact]
        public void testme2()
        {
            result += "testme2 ";
            Assert.True(true);
        }
        public void Dispose()
        {
            result += "Teardown ";

            output.WriteLine($"{result}");
        }
    }
}
