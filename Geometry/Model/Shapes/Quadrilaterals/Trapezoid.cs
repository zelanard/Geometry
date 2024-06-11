using System;

namespace Geometry.Model.Shapes
{
    /// <summary>
    /// 
    /// </summary>
    public class Trapezoid : Quadrilateral
    {
        public float Top { get; private set; }
        public float Left { get; private set; }
        public float Bottom { get; private set; }
        public float Right { get; private set; }
        public float Height { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Top"></param>
        /// <param name="Height"></param>
        /// <param name="Bottom"></param>
        public Trapezoid(float top, float height, float bottom) : base(4)
        {
            Top = top;
            Bottom = bottom;
            Left = height;
            Right = height;
            Height = SetHeight();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override float Area()
        {
            float area = 0.5f * (Top + Bottom) * Height;
            return area;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override float Circumfence()
        {
            return Sum(Top, Left, Bottom, Right);
        }

        public float SetHeight()
        {
            float T = Top - Left;
            return (float)(2 / (Bottom - Top) * Math.Sqrt(Top * Bottom * T * T));
        }
    }
}
