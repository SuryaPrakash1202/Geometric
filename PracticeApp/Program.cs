using System;
using PracticeBL;
namespace PracticeApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Circle obj1 = new Circle(2.4,"white",true);
            Rectangle obj2 = new Rectangle(4, 5, "black", true);
            Console.WriteLine($"Area of a circle is :{ obj1.Area()}");
            Console.WriteLine($"Diameter of a circle :{obj1.Diameter()}");
            Console.WriteLine($"Permeter of a circle:{obj1.Perimeter()}");
            Console.WriteLine(obj1.ToString());
            obj1.PrintCircle();
            Console.WriteLine($"Area of a Rectangle is :{obj2.Area()}");
            Console.WriteLine($"Perimeter of a Rectangle:{obj2.Perimeter()}");



        }
    }
}    

