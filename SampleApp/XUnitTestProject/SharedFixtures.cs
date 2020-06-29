using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace SampleApp.xUnitTest
{
    public class SharedFixtures: SetupFixtures,IDisposable
    {

        public SharedFixtures()
        {
            Console.WriteLine("In Constructor per Class");
        }


        [Fact]
        public void testme()
        {
            Assert.True(true);
        }

        [Fact]
        public void testme2()
        {
            Assert.True(true);
        }

    }

    public class SetupFixtures : IDisposable
    {
        public SetupFixtures()
        {
            Console.Write("Setup Fixture");
        }
        public void Dispose()
        {
            Console.WriteLine("I am in dispose"); 
        }
    }



}
