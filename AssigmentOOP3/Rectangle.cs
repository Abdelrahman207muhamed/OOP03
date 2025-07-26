using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentOOP3
{
    internal class Rectangle : IRectangle
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Width => width;

        public double Height => height;

        public double Area => width * height;

        double IRectangle.Width { get ; set ; }
        double IRectangle.Height { get ; set ; }
        double IShape.Area { get; set; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle: Width = {Width:F2}, Height = {Height:F2}, Area = {Area:F2}");
        }

    }
}
