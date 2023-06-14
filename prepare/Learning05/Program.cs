using System;

class Program
{
    static void Main(string[] args)
    {
        
        Square square = new Square("blue", 4);

        Retangle retangle = new Retangle("white", 12, 8);

        Circle circle = new Circle("green", 7);

        List<Shape> shapes =  new  List<Shape>();
        shapes.Add(square);
        shapes.Add(retangle);
        shapes.Add(circle);

        foreach (Shape sha in shapes)
        {
            Console.WriteLine($"The area of the {sha.GetColor()} shape is {sha.GetArae()}.");

        }
    }
}