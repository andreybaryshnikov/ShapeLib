using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ShapeLib.Figure;

namespace ShapeLib.Test
{
    public class TriangleTest
    {
        [Fact]
        public void CreationGoodParametersTest()
        {
            var sideA = 3;
            var sideB = 4;
            var sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            Assert.Equal(sideA, triangle.SideA);
            Assert.Equal(sideB, triangle.SideB);
            Assert.Equal(sideC, triangle.SideC);
        }

        [Fact]
        public void CreationBadParametersTest_NegativeSide_ThrowsArgumentOutOfRangeException()
        {
            var sideA = 3;
            var sideB = 4;
            var sideC = 5;            

            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-sideA, sideB, sideC));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(sideA, -sideB, sideC));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(sideA, sideB, -sideC));
        }

        [Fact]
        public void CreationBadParametersTest_InconsistentSide_ThrowsArgumentOutOfRangeException()
        {
            var sideA = 3;
            var sideB = 4;
            var sideC = 7.5;

            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(sideA, sideB, sideC));            
        }

        [Fact]
        public void CalculateSquareTest()
        {
            var sideA = 3;
            var sideB = 4;
            var sideC = 5;

            var p = (sideA + sideB + sideC) / 2;            

            Triangle triangle = new Triangle(sideA, sideB, sideC);

            Assert.Equal(Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC)), triangle.Square);
        }

        [Fact]
        public void CheckIsRightTest_RightTriangle()
        {
            var sideA = 3;
            var sideB = 4;
            var sideC = 5;            

            Triangle triangle = new Triangle(sideA, sideB, sideC);

            Assert.True(triangle.IsRight);
        }

        [Fact]
        public void CheckIsRightTest_NotRightTriangle()
        {
            var sideA = 3;
            var sideB = 3;
            var sideC = 5;

            Triangle triangle = new Triangle(sideA, sideB, sideC);

            Assert.False(triangle.IsRight);
        }
    }
}
