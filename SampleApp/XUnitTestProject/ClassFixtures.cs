using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace SampleApp.xUnitTest
{
    public class ClassFixtures1: IClassFixture<SharedClassFixture>
    {
        SharedClassFixture myfixture;

        public ClassFixtures1(SharedClassFixture myfixture)
        {
            this.myfixture = myfixture;
            myfixture.sharedvalue += "test-constructor ";
        }
        
        [Fact]
        public void testme()
        {
            myfixture.sharedvalue += " test ";
           Assert.Equal("", myfixture.sharedvalue);
            Assert.Equal("SharedFixture", myfixture.name);
            
        }
    }

    public class ClassFixtures2 : IClassFixture<SharedClassFixture>
    {
        SharedClassFixture myfixture;

        public ClassFixtures2(SharedClassFixture myfixture)
        {
            this.myfixture = myfixture;
        }

        [Fact]
        public void testme2()
        {
            Assert.Equal("SharedFixture", myfixture.name);
        }
    }







    public class SharedClassFixture : IDisposable
    {
        public string name = "SharedFixture";
        public string sharedvalue;


        public SharedClassFixture()
        {
            sharedvalue += " Setup ";
            Console.WriteLine("In Setup");
        }

        public void Dispose()
        {
            sharedvalue += " Dispose";
            Console.WriteLine("In dispose");
        }

    }

}
