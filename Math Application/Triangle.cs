using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

/*
    3. Define a Triangle object which retains the aforementioned characteristics of a Shape. The name of the triangle should take into
    account if it is equilateral (all 3 sides are the same length), isosceles (only 2 sides are the same length) or scalene (no 2 sides are
    the same).
    - Area of triangle = (Height * base) / 2
    - Perimeter of triangle = a + b +c
 */
namespace Math_Application
{
    class Triangle : Shape
    {
        public decimal A { get; }
        public decimal B { get; }
        public decimal C { get; }
        public decimal Height { get; }

        public override string Name { get; }
        public override decimal Perimeter { get; }
        public override decimal SurfaceArea { get; }

        private static long _instanceCount;

        public Triangle(decimal a, decimal b, decimal c, decimal height)
        {
            A = a;
            B = b;
            C = c;
            Height = height;
            // Assuming the Height is provided and A = base. Further clarification would needed.
            // If there is no Height then Heron's formula could be used
            SurfaceArea = (Height * A) / 2;
            Perimeter = A + B + C;
            if (A == B && B == C)
            {
                Name = "Equilateral Triangle";
            }
            else
            {
                if (A == B || A == C || B == C)
                {
                    Name = "Isosceles Triangle";
                }
                else
                {
                    Name = "Scalene Triangle";
                }
            }
            Interlocked.Increment(ref _instanceCount);
        }

        public static long GetActiveInstances()
        {
            return _instanceCount;
        }

    }
}
