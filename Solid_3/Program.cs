using System;
// Liskov substitution principle!
namespace Solid_3
{
    internal interface IShape
    {
        double GetArea();
    }

    internal class Rectangle : IShape
    {
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; set; }
        public int Height { get; set; }

        public double GetArea()
        {
            return Width * Height;
        }
    }

    internal class Square : IShape
    {
        public int Side { get; set; }

        public Square(int i)
        {
            Side = i;
        }

        public double GetArea()
        {
            return Side * Side;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IShape square = new Square(5);
            Console.WriteLine(square.GetArea());
            IShape rect = new Rectangle(5, 10);
            Console.WriteLine(rect.GetArea());

            rect = square;
            Console.WriteLine(rect.GetArea());
        }

    }
}