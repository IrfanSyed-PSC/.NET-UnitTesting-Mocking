using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp.UnitTest
{
    [TestFixture(4)]
    [TestFixture(2)]
    class TestFixtureExample
    {
        int j;

        public TestFixtureExample(int j)
        {
            this.j = j;
        }

        [Test]
        public void testme() => Assert.AreEqual(2, j);
        
    }

   
}
