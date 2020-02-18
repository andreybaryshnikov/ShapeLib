using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLib.Figure
{
    public class Circle : Figure
    {

        #region properties

        public double Radius { get; }

        #endregion

        #region ctor

        /// <summary>
        /// 
        /// </summary>
        /// <param name="radius"></param>
        /// <exception cref="ArgumentOutOfRangeException">Invalid radius value</exception>
        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentOutOfRangeException("The radius should be positive");
            Radius = radius;
        }

        #endregion

        protected override double CalculateSquare()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
