using NUnit.Framework;
using System;

namespace SampleApp.UnitTest

{
    // Define the lifecycle of the Unit tests and explain which option runs when.
    /**
     *  TestFixture
     *               - OneTimeSetup
     *                      - Setup
     *                           - test1
     *                      - Teardown
     *                       - Setup
     *                          - test2
     *                      - Teardown
     *               - OneTimeTeardown
     *               
     * 
     * 
     * 
     */
    [TestFixture("Syed")]
    [TestFixture("Irfan")]
    class NUnitLifeCycle
    {
        String result;
        public String myname;
        public NUnitLifeCycle(String myname)
        {
            this.myname = myname;
            Console.WriteLine($"myname is {myname}");
        }

        [OneTimeSetUp]
        public void FixtureSetup() => result += "FixtureSetup ";

        [OneTimeTearDown]
        public void FixtureTeardown() => result += "FixtureTeardown ";

        [Test]
        public void test1()
        {
            result += "test1 ";
            Console.WriteLine(result);
            Assert.True(true);
        }

        [Test]
        public void test2()
        {
            result += "test2 ";
            Console.WriteLine(result);
        }

        [SetUp]
        public void Setup()
        {
            result += "Setup ";
            Console.WriteLine(result);
        }

        [TearDown]
        public void Shutdown()
        {
            result += "Shutdown ";
            Console.WriteLine(result);
        }


    }
}
