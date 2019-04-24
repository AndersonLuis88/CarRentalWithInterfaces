using System;
using ShapeWithInterfaces.Model.Enums;
namespace ShapeWithInterfaces.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();

    }
}
