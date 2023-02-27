using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapeList = new List<Shape>();

        Square square = new Square("red", 5);
        Console.WriteLine(square.GetArea());
        shapeList.Add(square);

        Rectangle rect = new Rectangle("blue", 5, 2);
        Console.WriteLine(rect.GetArea());
        shapeList.Add(rect);

        Circle circle = new Circle("green", 3);
        Console.WriteLine(circle.GetArea());
        shapeList.Add(circle);

        foreach (Shape shape in shapeList)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }
        
    }
}