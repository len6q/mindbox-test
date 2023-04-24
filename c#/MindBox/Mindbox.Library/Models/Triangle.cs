using Mindbox.Library.Interfaces;
using System;

namespace Mindbox.Library.Models
{
    public class Triangle : IShape
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        public Triangle(double a, double b, double c)
        {
            double[] sides = { a, b, c };
            Array.Sort(sides);
            if(sides[0] + sides[1] <= sides[2])
            {
                throw new ArgumentException($"({a}, {b}, {c}) Треугольника с такими сторонами не существует");
            }

            (_a, _b, _c) = (a, b, c);
        }

        public double GetArea()
        {
            double p = (_a + _b + _c) / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        public bool IsRight()
        {
            double[] sides = { _a, _b, _c };
            Array.Sort(sides);
            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }
    }
}
