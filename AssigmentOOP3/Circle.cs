using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentOOP3
{
    internal class Circle:ICircle
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Radius => radius;

        public double Area => Math.PI * radius * radius;

        double ICircle.Radius { get ; set ; }
        double IShape.Area { get ; set ; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle: Radius = {Radius:F2}, Area = {Area:F2}");
        }
    }
}
