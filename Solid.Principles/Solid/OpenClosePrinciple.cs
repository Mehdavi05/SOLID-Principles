using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

//2. Open/Closed Principle (OCP)
//Principle: Software entities(classes, modules, functions, etc.) should be open for extension but closed
//for modification.

namespace Solid
{
    // Abstract base class representing a shape
    public abstract class Shape
    {
        public abstract void Draw();
    }

    // Class representing a circle
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle with radius " + Radius);
        }
    }

    // Class representing a rectangle
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle with width " + Width + " and height " + Height);
        }
    }

    // Class responsible for drawing shapes
    public class ShapeDrawer
    {
        private readonly List<Shape> _shapes;

        public ShapeDrawer()
        {
            _shapes = new List<Shape>();
        }

        public void AddShape(Shape shape)
        {
            _shapes.Add(shape);
        }

        public void DrawAllShapes()
        {
            foreach (var shape in _shapes)
            {
                shape.Draw();
            }
        }
    }
}
