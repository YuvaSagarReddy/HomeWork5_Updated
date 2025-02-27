using System;
namespace Homework_5
{
    public abstract class Shape
    {
        public string Color { get; set; }

        public Shape(string acolor)
        {
            Color = acolor;
        }

        public abstract double GetArea();

        public override string ToString()
        {
            return $"{Color} Shape";
        }
    }

    public class Rectangle:Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(string color, double width, double height): base(color)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width*Height;
        }

        public override string ToString()
        {
            return $"{Color} Rectangle (Width: {Width}, Height: {Height}, Area: {GetArea():F2})";
        }
    }

    public class Circle:Shape
    {
        public double Radius { get; set; }

        public Circle(string color, double radius): base(color)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI*Radius*Radius;
        }

        public override string ToString()
        {
            return $"{Color} Circle (Radius: {Radius}, Area: {GetArea():F2})";
        }
    }
}

