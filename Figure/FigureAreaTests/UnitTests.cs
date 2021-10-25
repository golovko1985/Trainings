using System;
using NUnit.Framework;

namespace FigureArea
{
    public class Tests
    {
        [Test]
        public void SimpleCircleTest()
        {
            var expected = Math.PI;
            var actualCircle = new Circle(1.0);
            Assert.AreEqual(expected, actualCircle.Area, Constants.Epsilon);
        }

        [Test]
        public void SimpleTriangleTest()
        {
            var expectedArea = 0.5;
            var actualTriangle = new Triangle(1, 1, Math.Sqrt(2));
            Assert.AreEqual(expectedArea, actualTriangle.Area, Constants.Epsilon);
        }

        [Test]
        public void SimpleCheckRightAngleTest()
        {
            var actualTriangle = new Triangle(2, 2, Math.Sqrt(8));
            Assert.IsTrue(actualTriangle.HasRightAngle());
        }

        [TestCase(3, 28.27433388)]
        [TestCase(1E-4, 3.1E-8)]
        [TestCase(7.82E+7, 19_211_593_058_938_448)]
        public void CircleBunchTest(double radius, double expectedArea)
        {
            var actualCircle = new Circle(radius);
            Assert.AreEqual(expectedArea, actualCircle.Area, Constants.Epsilon);
        }

        // Heronian triangles
        [TestCase(6, 5, 5, 12)]
        [TestCase(20, 15, 7, 42)]
        [TestCase(41, 41, 18, 360)]

        // Equilateral Triangle
        [TestCase(1, 1, 1, 0.4330127)]
        // Isosceles triangle
        [TestCase(3, 3, 1, 1.47901995)]
        // Scalene triangle
        [TestCase(0.1, 3.15, 3.05740722, 0.05860592)]
        // Right
        [TestCase(3E+7, 4E+7, 5E+7, 6E+14)]
        // Obtuse
        [TestCase(83737.9828428, 111617.56159487, 166853.95049874, 4178709932.2198553)]
        // Acute
        [TestCase(46.00622114, 31.90059306, 53.30099846, 730.14215436)]
        public void TriangleBunchTest(double a, double b, double c, double expectedArea)
        {
            var actualTriangle = new Triangle(a, b, c);
            Assert.AreEqual(expectedArea, actualTriangle.Area, Constants.Epsilon);
        }


        [TestCase(3, 4, 5)]
        [TestCase(1.41421356, 1, 1)]
        [TestCase(1, 3, 3.16227766)]
        [TestCase(8.0, 8.24621125, 2)]
        [TestCase(0.00001, 0.00003, 0.00003162)]
        [TestCase(435040.84279163, 964513.7692079, 1058086.64384751)]
        [TestCase(1E-5, 4E-5, 4.123E-5)]
        [TestCase(1E-5, 1E+7, 1E+7)]

        public void PositiveRightAngleBunchTest(double a, double b, double c)
        {
            var actualTriangle = new Triangle(a, b, c);
            Assert.IsTrue(actualTriangle.HasRightAngle());
        }

        [TestCase(1, 1, 1)]
        [TestCase(3, 4, 5.01)]
        [TestCase(1.414210, 1, 1)]
        [TestCase(2, 2, 2.828428)]
        public void NegativeRightAngleBunchTest(double a, double b, double c)
        {
            var actualTriangle = new Triangle(a, b, c);
            Assert.IsFalse(actualTriangle.HasRightAngle());
        }

        [TestCase(1, 1, 10)]
        [TestCase(3, 4, 8)]
        [TestCase(0.01, 3.15, 3.1)]
        public void ExceptionTriangleAreaBunch(double a, double b, double c)
        {
            double actualArea;
            var actualTriangle = new Triangle(a, b, c);
            Assert.Catch<ArgumentOutOfRangeException>(() => actualArea = actualTriangle.Area);
        }

        [Test]
        public void SomeFigureTest()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            SomeFigure someFigure = new SomeFigure(triangle);
            Circle circle = new Circle(10);
            someFigure = new SomeFigure(circle);
            Assert.AreEqual(circle.Area, someFigure.Area, Constants.Epsilon);

        }
    }
}