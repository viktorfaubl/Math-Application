using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

/*
    4. Define 2 different quadrilaterals, a Square and Rectangle which retains the aforementioned characteristics of a Shape.
      The name should take into account if all sides are the same length.
      - Area of Square/Rectangle = width*length
      - Perimeter of Square/Rectangle = (width + length) * 2
 */
namespace Math_Application
{
    class Rectangle : Shape
    {
        public decimal Width { get; }
        public decimal Length { get; }
        public override string Name { get; }
        public override decimal Perimeter { get; }
        public override decimal SurfaceArea { get; }
        private static long _instanceCount;

        public Rectangle(decimal width, decimal length)
        {
            Width = width;
            Length = length;
            SurfaceArea = Width * Length;
            Perimeter = (Width + Length) / 2;
            Name = "Rectangle";
            Interlocked.Increment(ref _instanceCount);
        }

        public static long GetActiveInstances()
        {
            return _instanceCount;
        }
    }
}