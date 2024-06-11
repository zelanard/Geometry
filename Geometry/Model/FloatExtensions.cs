using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
