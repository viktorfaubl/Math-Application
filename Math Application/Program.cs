using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

/*
    1. Define a Shape object, where the object is any two-dimensional figure, and has the following characteristics: a name, perimeter and
    a surface area.

    2. Define a Circle object which retains the aforementioned characteristics of a Shape. The calculations for a circle are:
    - Area of circle = Pi*R*R  where R=Radius ,Pi=3.14
    - Perimeter (circumference) of circle = 2*Pi*R where R=Radius ,Pi=3.14

    3. Define a Triangle object which retains the aforementioned characteristics of a Shape. The name of the triangle should take into
    account if it is equilateral (all 3 sides are the same length), isosceles (only 2 sides are the same length) or scalene (no 2 sides are
    the same).
    - Area of triangle = (Height * base) / 2
    - Perimeter of triangle = a + b +c

    4. Define 2 different quadrilaterals, a Square and Rectangle which retains the aforementioned characteristics of a Shape.
      The name should take into account if all sides are the same length.
      - Area of Square/Rectangle = width*length
      - Perimeter of Square/Rectangle = (width + length) * 2

    5. We want to be able to sort a collection of Shapes by Area or Perimeter.
      Define methods/classes/interfaces that support this scenario and provide an example in Main.
      
    6. We want to be able serialize/store shapes in various formats on disk.
      Define methods/classes/etc that support this scenario and provide an example in Main (xml/json/binary/etc pick one)

    7. We want to be able track(in memory) the number of Shape objects created (per class)
      Define methods/classes/etc that support this scenario and provide an example in Main

    -Main should initialize all classes and output all characteristics as per above.
     All characteristics when called should be output to the console.
    -Text output format is up to you.
    -You can add/remove classes as you see fit 
    -You can add/remove/move(between classes) characteristics as you see fit 
 */
namespace Math_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle(12);
            
            var triangle1 = new Triangle(3,3,3,2);
            var triangle2 = new Triangle(3, 3, 4, 2);
            var triangle3 = new Triangle(2, 3, 4, 1);
            var quadrilateral1 = new QuadrilateralFactory().GetQuadrilateral(4,4);
            var quadrilateral2 = new QuadrilateralFactory().GetQuadrilateral(4, 12);
            
            //Sorting - Extension Method could be used also, but would overcomplicate
            var shapes = new List<Shape>
            {
                circle,
                triangle1,
                triangle2,
                triangle3,
                quadrilateral1,
                quadrilateral2
            };

            var perimeterOrdered = shapes.OrderBy(o => o.Perimeter).ToList();
            var areaOrdered = shapes.OrderBy(o => o.SurfaceArea).ToList();

            //Serialization : JSON
            foreach (var shape in perimeterOrdered)
            {
                var json = JsonSerializer.Serialize(shape);
                Console.WriteLine(json);
            }
            


            //Number of Shape object created - Strategy Pattern maybe?
            Console.WriteLine(Circle.GetActiveInstances());
            Console.WriteLine(Triangle.GetActiveInstances());
            Console.WriteLine(Square.GetActiveInstances());
            Console.WriteLine(Rectangle.GetActiveInstances());
        }
    }
}
