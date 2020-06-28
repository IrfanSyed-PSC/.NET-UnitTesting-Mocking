using NUnit.Framework;
using NUnit.Framework.Internal;


namespace SampleApp.UnitTest
{

    // Define ordering of the tests to run
    class Ordering
    {
        int mval = 0;

        [Test, Order(1)]
        public void thistest()
        {
            mval++;

            TestContext.Write($"in thistest {mval}" );
        }

        [Test]
        [Order(3)]
        public void thattest()
        {
            mval++;
            TestContext.Write($"in thisthat {mval}");
        }

        [Test, Order(2)]
        public void whichtest()
        {
            mval++;
            TestContext.Write($"in whichtest {mval}");
        }
    }
}
