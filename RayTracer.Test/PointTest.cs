using NUnit.Framework;

namespace RayTracer.Test
{
    public class PointTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void T01_IsPoint()
        {
            Point a = new Point(4.3f, -4.2f, 3.1f);
            Assert.AreEqual(4.3f, a.X);
            Assert.AreEqual(-4.2f, a.Y);
            Assert.AreEqual(3.1f, a.Z);
            Assert.AreEqual(1.0f, a.W);
            Assert.IsInstanceOf(typeof(Point), a);
            Assert.IsNotInstanceOf(typeof(Vector), a);
        }
    }
}