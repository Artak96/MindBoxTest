using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBoxTestLibrary.CalculateLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxUnitTest
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void CalculateArea_ValidTriangle_ReturnsCorrectArea()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            double area = triangle.CalculateArea();

            // Assert
            Assert.AreEqual(6.0, area, 0.001); // Use an epsilon for comparing floating-point numbers
        }

        [TestMethod]
        public void IsRightTriangle_RightTriangle_ReturnsTrue()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            bool isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.IsTrue(isRightTriangle);
        }

        [TestMethod]
        public void IsRightTriangle_NotRightTriangle_ReturnsFalse()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 6); // This is not a right triangle

            // Act
            bool isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.IsFalse(isRightTriangle);
        }
    }
}
