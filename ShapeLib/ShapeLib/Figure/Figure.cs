using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLib.Figure
{
    public abstract class Figure : IShape
    {
        #region properties

        /// <summary>
        /// Returns square of figure
        /// </summary>
        public double Square => CalculateSquare();

        #endregion

        #region func

        protected abstract double CalculateSquare();

        #endregion
    }
}
