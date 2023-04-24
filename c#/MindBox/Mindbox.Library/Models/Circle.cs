using Mindbox.Library.Interfaces;
using System;

namespace Mindbox.Library.Models
{
    public class Circle : IShape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            if(radius <= 0)
            {
                throw new ArgumentException($"{radius} должно быть неотрицательным числом");
            }
            _radius = radius;
        }

        public double GetArea() => 
            Math.PI * Math.Pow(_radius, 2);        
    }
}
