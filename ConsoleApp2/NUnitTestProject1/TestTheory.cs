using NUnit.Framework;


namespace SampleApp.UnitTest
{
    [TestFixture(typeof(int))]
    [TestFixture(typeof(double))]

    /**
     *  Theories are basically used to make statements of the use-cases. They look like tests, but the purpose of theories is define a underlying
     *  statement for the use-case and write code based on that.
     */
    class TestTheory<T>
    {
        // Datapoints are input parameters for theories. Theory gets executed for each Datapoint

        [Datapoint]
        public double[] ArrayDouble1 = { 1.2, 3.4 };
        [Datapoint]
        public double[] ArrayDouble2 = { 5.6, 7.8 };
        [Datapoint]
        public int[] ArrayInt = { 0, 1, 2, 3 };

        [Theory]
        public void TestGenericForArbitraryArray(T[] array)
        {
            Assert.That(array.Length, Is.EqualTo(4));
        }
    }
}
