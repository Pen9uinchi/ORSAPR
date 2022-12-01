using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotBuilder
{
    /// <summary>
    /// Class defines a point representing a location in (x,y,z) coordinate space
    /// </summary>
    public class Point3D : Point2D
    {
        /// <summary>
        /// Coordinate Z
        /// </summary>
        private double _z;

        /// <summary>
        /// Get or set coordinate Z
        /// </summary>
        public double Z
        {
            get => _z;
            set => _z = value;
        }
    }
}
