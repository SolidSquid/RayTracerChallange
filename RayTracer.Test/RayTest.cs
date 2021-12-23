using NUnit.Framework;
using System;


namespace RayTracer.Test
{
    public class RayTest
    {
        Ray r;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PositionTest()
        {
            r = new Ray(new Point(2, 3, 4), new Vector(1, 0, 0));

            Assert.AreEqual(Point.IsEqual(Ray.Position(r, 0), new Point(2, 3, 4)),true);
            Assert.AreEqual(Point.IsEqual(Ray.Position(r, 1), new Point(3, 3, 4)),true);
            Assert.AreEqual(Point.IsEqual(Ray.Position(r, -1), new Point(1, 3, 4)),true);
            Assert.AreEqual(Point.IsEqual(Ray.Position(r, 2.5f), new Point(4.5f, 3, 4)),true);

        }

    }
}
