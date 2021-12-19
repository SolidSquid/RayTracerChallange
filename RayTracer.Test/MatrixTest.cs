using NUnit.Framework;
using System;

namespace RayTracer.Test
{
    public class MatrixTest
    {
        public Mat4 a;
        public Mat4 a2;
        public Mat4 a3;
        public Mat3 b;
        public Mat2 c;

        public Vector v;
        public Vector v2;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Mat4Test()
        {
            a = new Mat4(1, 2, 3, 4, 5.5f, 6.5f, 7.5f, 8.5f, 9, 10, 11, 12, 13.5f, 14.5f, 15.5f, 16.5f);
            Assert.AreEqual(a.Mat[0, 0], 1);
            Assert.AreEqual(a.Mat[0, 3], 4);
            Assert.AreEqual(a.Mat[1, 0], 5.5);
            Assert.AreEqual(a.Mat[1, 2], 7.5);
            Assert.AreEqual(a.Mat[2, 2], 11);
            Assert.AreEqual(a.Mat[3, 0], 13.5);
            Assert.AreEqual(a.Mat[3, 2], 15.5);

        }

        [Test]
        public void Mat3Test()
        {
            b = new Mat3(-3, 5, 0, 1, -2, -7, 0, 1, 1);
            Assert.AreEqual(b.Mat[0, 0], -3);
            Assert.AreEqual(b.Mat[1, 1], -2);
            Assert.AreEqual(b.Mat[2, 2], 1);
        }

        [Test]
        public void Mat2Test()
        {
            c = new Mat2(-3, 5, 1, -2);
            Assert.AreEqual(c.Mat[0, 0], -3);
            Assert.AreEqual(c.Mat[0, 1], 5);
            Assert.AreEqual(c.Mat[1, 0], 1);
            Assert.AreEqual(c.Mat[1, 1], -2);
        }

        [Test]
        public void MatrixMultiplicationTest()
        {
            a = new Mat4(1, 2, 3, 4, 5, 6, 7, 8, 9, 8, 7, 6, 5, 4, 3, 2);
            a2 = new Mat4(-2, 1, 2, 3, 3, 2, 1, -1, 4, 3, 6, 5, 1, 2, 7, 8);
            a3 = a * a2;
            Assert.AreEqual(a3.Mat[0, 0], 20);
            Assert.AreEqual(a3.Mat[0, 1], 22);
            Assert.AreEqual(a3.Mat[0, 2], 50);
            Assert.AreEqual(a3.Mat[0, 3], 48);

            Assert.AreEqual(a3.Mat[1, 0], 44);
            Assert.AreEqual(a3.Mat[1, 1], 54);
            Assert.AreEqual(a3.Mat[1, 2], 114);
            Assert.AreEqual(a3.Mat[1, 3], 108);

            Assert.AreEqual(a3.Mat[2, 0], 40);
            Assert.AreEqual(a3.Mat[2, 1], 58);
            Assert.AreEqual(a3.Mat[2, 2], 110);
            Assert.AreEqual(a3.Mat[2, 3], 102);

            Assert.AreEqual(a3.Mat[3, 0], 16);
            Assert.AreEqual(a3.Mat[3, 1], 26);
            Assert.AreEqual(a3.Mat[3, 2], 46);
            Assert.AreEqual(a3.Mat[3, 3], 42);

        }

        [Test]
        public void TransformationVector()
        {
            a = new Mat4(1, 2, 3, 4, 2, 4, 4, 2, 8, 6, 4, 1, 0, 0, 0, 1);
            v = new Vector(1, 2, 3);
            v2 = a * v;
            Assert.AreEqual(v2.Y, 22);
        }

        [Test]
        public void DetTest()
        {
            c = new Mat2(1, 5, -3, 2);
            Assert.AreEqual(17, Mat2.Det(c));

        }
    }
}
