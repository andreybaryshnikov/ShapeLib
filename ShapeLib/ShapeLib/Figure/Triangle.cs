using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ShapeLib.Figure
{
    public class Triangle : Figure
    {
        #region properties

        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public bool IsRight => CheckIsRight();

        #endregion

        #region ctor

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Throws when sides length are inconsistent or negative </exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentOutOfRangeException("Triangle side should be greater than zero");
                        
            
            if(sideA > sideB + sideC || sideB > sideA + sideC || sideC > sideA + sideB)
                throw new ArgumentOutOfRangeException("One of the sides greater than sum of others");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        #endregion


        protected bool CheckIsRight()
        {
            var triangleSides = new[] { SideA, SideB, SideC };
            var maxSide = triangleSides.Max();
            
            //return maxSide * maxSide == triangleSides.OrderBy(p => p).Take(2).Select(p => p * p).Sum();
            return 2 * maxSide * maxSide == SideA * SideA + SideB * SideB + SideC * SideC; // a^2 + a^2 = a^2 + b^2 + c^2
        }       

        protected override double CalculateSquare()
        {
            var p = (SideA + SideB + SideC) / 2; //semiperimeter
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
    }
}
