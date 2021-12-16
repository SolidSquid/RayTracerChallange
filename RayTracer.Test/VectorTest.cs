using NUnit.Framework;
using System;

namespace RayTracer.Test
{
    class VectorTest
    {
        [Test]
        public void T01_IsVector()
        {
            Vector a = new Vector(4.3f, -4.2f, 3.1f);
            Assert.AreEqual(4.3f, a.X);
            Assert.AreEqual(-4.2f, a.Y);
            Assert.AreEqual(3.1f, a.Z);
            Assert.AreEqual(0.0f, a.W);
            Assert.IsInstanceOf(typeof(Vector), a);
            //Assert.IsInstanceOf(typeof(Tuple), a);
            Assert.IsNotInstanceOf(typeof(Point), a);
        }

        [Test]
        public void VectorAdditionTest()
        {
            Vector a = new Vector(3f, -3f, 3f);
            Vector b = new Vector(1f, -1f, 1f);
            Point c = new Point(1f, 2f, 6f);

            Assert.IsInstanceOf(typeof(Vector), a+b);
            Assert.IsInstanceOf(typeof(Point), a+c);
            Assert.IsInstanceOf(typeof(Point), c+a);
           

        }
        public void VectorMagnitudeTest()
        {
            Vector a = new Vector(1f, 2f, 3f);


            Assert.AreEqual(a, MathF.Sqrt(14));

        }
    }
}

