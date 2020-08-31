using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesFilesDateTime
{

    public class Rectangle
    {
        public int width { get; set; }

        public int height { get; set; }
        
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
            creationDate = DateTime.Now;

        }

        public DateTime creationDate { get; set; }

        public Rectangle()
        {
        }

        public double area()
        {
            return width * height;
        }

        public override string ToString()
        {
            var diff = DateTime.Now = creationDate;
            string output = $"The rectangle has a width of {width} and height of {height}" + $"The rectangle was created {diff.TotalSeconds}";
        }
    }
    
}
