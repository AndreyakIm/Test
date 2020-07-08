using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatingArea;

namespace CalculatingAreaTests
{
    [TestClass]
    public class CalculatingAreaTests
    {
        [TestMethod]
        public void CalculateTriangleAreaTest()
        {
            //Arrange
            double a = 3.0;
            double b = 4.0;
            double c = 5.0;
            double s = 6;
            Triangle triangle = new Triangle(a, b, c);
            //Act
            double area = triangle.Area();
            //Assert
            Assert.AreEqual(s,area);
        }
        [TestMethod]
        public void CheckIfTriangleIsRight()
        {
            //Arrange
            double a = 3.0;
            double b = 4.0;
            double c = 5.0;
            Triangle triangle = new Triangle(a, b, c);
            //Act
            bool testResult = triangle.CheckTriangle();
            //Assert
            Assert.IsTrue(testResult);
        }
        [TestMethod]
        public void CalculateCircleAreaTest()
        {
            //Arrange
            double radius = 5.0;
            double expectedArea = Math.PI*5*5;
            Circle circle = new Circle(radius);
            //Act
            double area = circle.Area();
            //Assert
            Assert.AreEqual(expectedArea, area);
        }
    }
}
