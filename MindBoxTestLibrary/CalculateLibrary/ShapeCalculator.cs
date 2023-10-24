using MindBoxTestLibrary.CalculateLibrary.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTestLibrary.CalculateLibrary
{
    public static class ShapeCalculator
    {
        // Can add any tipe shape
        public static double CalculateArea(IShape shape)
        {
            switch (shape)
            {
                case Circle circle:
                    return circle.CalculateArea();
                case Triangle triangle:
                    return triangle.CalculateArea();
                default:
                    throw new ArgumentException("Unsupported shape type");
                       
            }
        }
    }
}
