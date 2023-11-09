using System;

class Program
{
    static void Main(string[] args)
    {
        Square zeSquare = new Square("square", 5);

        Console.WriteLine(zeSquare.GetColor());
        Console.WriteLine(zeSquare.GetArea());
    }
}