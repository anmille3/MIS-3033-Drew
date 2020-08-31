using System;
using System.Collections.Generic;

namespace ClassesFilesDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle();
            rect1.width = 10;
            rect1.height = 20;

            Rectangle rect2 = new Rectangle(5, 2);

            Console.WriteLine($"The area of the rect1 is {rect1.area()}");
            Console.WriteLine($"The area of the rect2 is {rect2.area()}");

            List<Rectangle> rectangles = new List<Rectangle>();
            rectangles.Add(rect1);
            rectangles.Add(rect2);

            //Add a rectanlge
            rectangles.Add(new Rectangle(7, 7));

            foreach (var rect in rectangles)
            {
                Console.WriteLine(rect);
                //Console.WriteLine($"The area of the rectangle is {rect.area()}");
            }

        }
    }
}
