using System;

namespace Classes_and_circles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);

            Console.WriteLine("Arean av första cirkeln är:" + circle1.getArea());                        
            Console.WriteLine("Arean av andra cirkeln är:" + circle2.getArea());

            Console.WriteLine("Diametern i första cirkeln är:" + circle1.getDiameter());
            Console.WriteLine("Diametern i andra cirkeln är:" + circle2.getDiameter());

            Triangle triangle = new Triangle(13.5f, 26.5f);
            Console.WriteLine("Arean av triangeln är:" + triangle.getAreaofTriangle());
        }
    }
}
