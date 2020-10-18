using System;
using System.Collections.Generic;
using System.Text;

namespace Math_Application
{
    public abstract class Shape
    {
        public abstract string Name { get; }
        public abstract decimal Perimeter { get; }
        public abstract decimal SurfaceArea { get; }
    }
}
