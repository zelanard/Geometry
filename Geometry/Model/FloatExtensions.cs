using System;

namespace Geometry.Model
{
    public static class FloatExtensions
    {
        public static float ToAngle(this float value)
        {
            return value * (180 / (float)Math.PI);
        }
    }
}
