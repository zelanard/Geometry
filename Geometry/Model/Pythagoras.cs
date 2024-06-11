using System;

namespace Geometry.Model
{
    public class Pythagoras
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public float Hypotenusen(float a, float b)
        {
            float aSquared = a * a;
            float bSquared = b * b;
            float c = (float)Math.Sqrt(aSquared + bSquared);

            return c;
        }
    }
}