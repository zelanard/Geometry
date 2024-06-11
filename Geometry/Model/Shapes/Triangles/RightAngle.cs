using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Model.Shapes.Triangles
{
    /// <summary>
    /// 
    /// </summary>
    public class RightAngle : Polygon
    {
        public float Height { get; private set; }
        public float Length { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="height"></param>
        /// <param name="length"></param>
        /// <param name="sides"></param>
        public RightAngle(float height, float length) : base(3) 
        {
            Height = height;
            Length = length;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override float Area()
        {
            return (Height * Length) / 2;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override float Circumfence()
        {
            return Height + Length + this.Pythagoras.Hypotenusen(Height, Length);
        }
    }
}
