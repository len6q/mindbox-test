using Mindbox.Library.Models;
using System;
using Xunit;

namespace Mindbox.Tests
{
    public class LibraryTests
    {
        [Fact]
        public void Circle_Get_Area()
        {
            double radius = 5;
            double expected = 78.53981633974483;

            var circle = new Circle(radius);
            double actual = circle.GetArea();

            Assert.Equal(expected, actual);
        }  
        
        [Fact]        
        public void Circle_Throws_Exception_With_Wrong_Param()
        {
            double radius = -2;         
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }

        [Fact]
        public void Triangle_Get_Area()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;

            var triangle = new Triangle(a, b, c);
            double actual = triangle.GetArea();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Triangle_Throws_Exception_With_Wrong_Param()
        {
            double a = 1;
            double b = 2;
            double c = 5;

            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Fact]
        public void Triangle_Is_Right()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            
            var triangle = new Triangle(a, b, c);
            bool actual = triangle.IsRight();

            Assert.True(actual);
        }
    }
}
