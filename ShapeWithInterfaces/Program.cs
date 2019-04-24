using System;
using ShapeWithInterfaces.Model.Entities;
namespace ShapeWithInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            IShape s1 = new Circle() { Radius = 2.0, Color = Model.Enums.Color.White };
            IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Model.Enums.Color.Black };

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.ReadLine(); 
        }
    }
}
