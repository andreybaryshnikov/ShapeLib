using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ShapeLib.Figure;

namespace ShapeLib.Test
{
    public class CircleTest
    {
        [Fact]
        public void CreationGoodParametersTest() 
        {
            var radius = 1;
            Circle circle = new Circle(radius);

            Assert.Equal(circle.Radius, radius);
        }

        [Fact]
        public void CreationBadParametersTest_ThrowsArgumentOutOfRangeException()
        {
            var radius = -1;            

            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
        }

        [Fact]
        public void CalculateSquareTest()
        {
            var radius = 1;
            Circle circle = new Circle(radius);

            Assert.Equal(circle.Square, Math.PI * radius * radius);
        }

    }
}
