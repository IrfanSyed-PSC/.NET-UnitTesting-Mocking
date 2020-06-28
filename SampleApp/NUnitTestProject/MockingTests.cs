using System;
using Moq;
using NUnit.Framework;
using SampleApp;
namespace SampleApp.UnitTest
{
    /**
     *  Execute few mocking use-cases using the Moq framework
     */
    class MockingTests
    {

        /**
         *  Simple test without performing mocking
         */
        [Test]
        public void testwithoutMock()
        {

            var contact = new Contact("Irfan", "Westford",9999);

            SendShipMent ship = new SendShipMent();
           Console.Write(ship.send(contact));

            
        }

        /**
         * Mock the interface object and pass that as input 
         */

        [Test]
        public void testwithmock()
        {

            // Create a mock object
            var mock = new Mock<IContact>();

            // Mock the variables
            mock.Setup(x => x.Name).Returns("Irfan");
            mock.Setup(x => x.Address).Returns("Westford");
            mock.Setup(x => x.phoneno).Returns(9999);

            // Send the mocked object as input
            var Shipment = new SendShipMent();
            TestContext.Write(Shipment.send(mock.Object));

            // validate that the object is used
           mock.Verify(x => x.Address);


        }

        /**
         *  Mock a method in  Class by passing the class as input to a method
         */
        [Test]
        public void mockaClass()
        {

            var mock = new Mock<Contact>();
            string[] defaults = new string[] { "home", "address", "phone" };

            mock.Setup(x => x.getpostalcode()).Returns(1234);

            var contact = new Contact().givedefaults(mock.Object);
            Console.Write(contact[2]);




        }


        /**
         *  Mock a method in a class 
         */
        [Test]
        public void mocknoparammethod()
        {

            var mock = new Mock<Contact>();
            mock.Setup(x => x.getname()).Returns("I got mocked");

            Console.Write(mock.Object.printname());


        }
    }
}
