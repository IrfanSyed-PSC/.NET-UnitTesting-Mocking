using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp.UnitTest
{
    /**
     *  Execute more than one testcase in a method
     */
    class InputTestCases
    {

        [TestCase("Fruit","Apple", Description = "Print fruits")]
        [TestCase("Vegetable","Carrot", Description = "Print Vegetables")]
        [TestCase("Seafood","Fish", Description = "Print Seafood")]
        public void testme(String foodtype, String foodname)
        {
            TestContext.Write($"food type is {foodtype} and foodname is {foodname}");
        }


    }
}
