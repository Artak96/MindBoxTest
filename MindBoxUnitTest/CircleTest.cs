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
    public class CircleTests
    {
        [TestMethod]
        public void CalculateArea_ValidCircle_ReturnsCorrectArea()
        {
            // Arrange
            double radius = 5;
            var circle = new Circle(radius);

            // Act
            double area = circle.CalculateArea();

            // Assert
            Assert.AreEqual(Math.PI * radius * radius, area, 0.001); // Use an epsilon for comparing floating-point numbers
        }
    }
}
