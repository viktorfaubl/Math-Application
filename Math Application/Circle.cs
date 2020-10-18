using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

/*
 *     2. Define a Circle object which retains the aforementioned characteristics of a Shape. The calculations for a circle are:
    - Area of circle = Pi*R*R  where R=Radius ,Pi=3.14
    - Perimeter (circumference) of circle = 2*Pi*R where R=Radius ,Pi=3.14
 */
namespace Math_Application
{
    class Circle : Shape
    {
        private static long _instanceCount;

        private static readonly decimal Pi = new decimal(3.14);
        public decimal Radius { get;}
        public override string Name { get;}
        public override decimal Perimeter { get; }
        public override decimal SurfaceArea { get; }

        public Circle(decimal radius)
        {
            Radius = radius;
            SurfaceArea = Pi * Radius * Radius;
            Perimeter = 2 * Pi * Radius;
            Name = "Circle";

            Interlocked.Increment(ref _instanceCount);
        }

        public static long GetActiveInstances()
        {
            return _instanceCount;
        }

    }
}
