using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareCircleAndTriangle;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LineTest()
        {
            var p1 = new Point(0, 0);
            var p2 = new Point(3, 4);
            var line = new Line(p1, p2);

            Assert.AreEqual(line.Length, 5);
        }

        [TestMethod]
        public void SquareCircleTest()
        {
            var circle = new Circle(1, 3, 5);

            Assert.AreEqual(circle.Square, Math.PI * 25);
        }


        [TestMethod]
        public void SquareTriangleTest()
        {
            var p1 = new Point(0, 0);
            var p2 = new Point(3, 0);
            var p3 = new Point(3, 4);

            var l1 = new Line(p1, p2);
            var l2 = new Line(p1, p3);
            var l3 = new Line(p3, p2);
            var triangle = new Triangle(l1, l2, l3);

            Assert.AreEqual(triangle.Square, 6);
        }

    }
}