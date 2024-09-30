using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeBL
{
    public class Circle : GeometricObject
    {
        private double radius;
        public double Radius { get; set; }
        public override double Area()
        {
            return 3.14 * Radius * Radius;
        }
        public  Circle(double radiusvalue, string colorvalue, bool filledvalue): base(colorvalue , filledvalue) 
        {
            Radius = radiusvalue;
            
        }
        public double Diameter()
        {
            return 2 * Radius;
        }
        public override double Perimeter()
        {
            return 2 * 3.14 * Radius;
        }
        public void PrintCircle()
        {
            Console.WriteLine($"area of circle:{Area()} diameter of a circle: {Diameter()} perimeter of a circle: {Perimeter()}");
        }

        public override string ToString()
        {
            return Color;
        }
    }
}
