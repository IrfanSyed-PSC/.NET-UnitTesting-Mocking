using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SampleApp.xUnitTest
{
   public  class FluentAssertions
    {

        [Fact]
        public void testme()
        {
            string firstname = "Irfan";
            string lastname = "Syed";

            firstname.Should().NotBeNullOrEmpty();
            lastname.Should().BeEquivalentTo("Syed");

            firstname.Should().NotBeEquivalentTo(lastname);
        }
    }
}
