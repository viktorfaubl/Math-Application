using System;
using System.Collections.Generic;
using System.Text;

namespace Math_Application
{
    class QuadrilateralFactory
    {
        public Shape GetQuadrilateral(decimal width, decimal length)
        {
            if (width == length) return new Square(width,length);

            return new Rectangle(width,length);
        }
    }
}
