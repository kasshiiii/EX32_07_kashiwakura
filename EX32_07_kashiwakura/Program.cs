using System;
using Abstract;

namespace EX32
{
    class program
    {
        static void Main()
        {
            float height, width;

            Rectangle rectangle = new Rectangle(3, 5);
            RightTriangle rightTriangle = new RightTriangle(2, 7);
            Circle circle = new Circle(5);
            Triangle triangle = new Triangle(5, 5, 5);
            Surface[] surfaces = {rectangle, rightTriangle, circle, triangle };
            for(var i = 0; i < surfaces.Length; i++)
            {
                Console.WriteLine($"Surfaceの面積は{surfaces[i].GetSurface()}");
                Console.WriteLine($"Surfaceの周囲長は{surfaces[i].GetCircumference()}");
                surfaces[i].GetBounds(out height, out width);
               Console.WriteLine($"Surfaceが入る長方形の長さは縦{height} 横{width}");
            }
        }
    }
}