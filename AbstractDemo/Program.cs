using System;

namespace AbstractDemo
{
    abstract class Shape
    {
        public abstract double GetArea();
    }

    class Circle : Shape
    {
        private double radius;

        public Circle(double r)
        {
            radius = r;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius; // πr² formula for the radius of a circle
        }
    }

    class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        public override double GetArea()
        {
            return length * width; // l × w or l x b 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Abstract Classes & Methods ---");

            Circle circle = new Circle(5.0);   
            Rectangle rectangle = new Rectangle(4.0, 6.0); 

            Console.WriteLine($"Circle (Radius = 5) Area: {circle.GetArea():F2}"); // :F2 rounds the figures to 2 decimal places
            Console.WriteLine($"Rectangle (4 x 6) Area: {rectangle.GetArea():F2}");

            Console.ReadKey();
        }
    }
}