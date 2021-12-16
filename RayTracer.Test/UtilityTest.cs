using NUnit.Framework;

namespace RayTracer.Test
{
    class UtilityTest
    {

        [Test]
        public void FloatsAreEqualTest()
        {
            float a = 5f;
            float b = 7f;
            float c = 5.0000056456456f;
            float d = 5.0000068486945f;

            Assert.IsFalse(Utility.FloatsAreEqual(a, b));
            Assert.IsTrue(Utility.FloatsAreEqual(c, d));
        }

    }
}
