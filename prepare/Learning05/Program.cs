using System;
using System.Collections.ObjectModel;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new();
        Square s = new("red", 5);
        shapes.Add(s);
        Rectangle r = new("white", 3, 4);
        shapes.Add(r);
        Circle c = new("blue", 10);
        shapes.Add(c);

        foreach (Shape i in shapes)
        {
            string color = i.GetColor();
            double area = i.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}