using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotBuilder
{
    /// <summary>
    /// Class defines a point representing a location in (x,y) coordinate space
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Coordinate X
        /// </summary>
        private double _x;

        /// <summary>
        /// Coordinate Y
        /// </summary>
        private double _y;

        /// <summary>
        /// Get or set coordinate X
        /// </summary>
        public double X
        {
            get => _x;
            set => _x = value;
        }

        /// <summary>
        /// Get or set coordinate Y
        /// </summary>
        public double Y
        {
            get => _y;
            set => _y = value;
        }
    }
}
