using SampleApp;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Api;
using NUnit.Framework.Internal;
using System;


namespace SampleApp.UnitTest

    // Define simple lifecycle for unit tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            SampleApp.Program v2 = new SampleApp.Program();
            Assert.That(v2.testme().Contains("yo"));
            
        }

        [Test]
        public void MockIt()
        {
            var mock = new Mock<IAnimal>();

            mock.Setup(x => x.Name()).Returns("Dog");

            var mytest = new Program();
            mytest.printit(mock.Object);

            mock.Verify(x => x.Name());

        }

        [TearDown]
        public void shutdown()
        {
            Console.WriteLine("I am in teardown");
        }
    }
}