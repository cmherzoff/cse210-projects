using System;

class Program
{
    static void Main(string[] args)
    {
        Circle myCircle = new Circle(100);

        // myCircle.SetRadius(-10);

        double area = myCircle.GetArea();

        Console.WriteLine(area);
    }
} 