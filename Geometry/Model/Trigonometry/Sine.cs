using System;

namespace Geometry.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Sine
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="opkat"></param>
        /// <param name="hypo"></param>
        /// <returns></returns>
        public float SinV(float opkat, float hypo)
        {
            return opkat / hypo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hypo"></param>
        /// <param name="sinV"></param>
        /// <returns></returns>
        public float OpKat(float hypo, float sinV)
        {
            return sinV * hypo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sinV"></param>
        /// <param name="opkat"></param>
        /// <returns></returns>
        public float Hypo(float sinV, float opkat)
        {
            return opkat / sinV;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="opkat"></param>
        /// <param name="hypo"></param>
        /// <returns></returns>
        public float Angle(float opkat, float hypo)
        {
            return (float)Math.Asin(SinV(opkat, hypo));
        }
    }
}
