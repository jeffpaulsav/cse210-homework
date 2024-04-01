using Learning05;
using System;
using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("purple", 4);
        Rectangle rectangle = new Rectangle("green", 4, 6);
        Circle circle = new Circle("Turquoise", 5.5);

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes) 
        { 
            Console.WriteLine(shape.GetArea());
            Console.WriteLine(shape.GetColor());
        }
        
    }
}