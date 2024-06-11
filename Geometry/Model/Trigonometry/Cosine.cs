using System;

namespace Geometry.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Cosine
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hoskat"></param>
        /// <param name="hypo"></param>
        /// <returns></returns>
        public float CosV(float hoskat, float hypo)
        {
            return hoskat / hypo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cosC"></param>
        /// <param name="hypo"></param>
        /// <returns></returns>
        public float HosKat(float cosC, float hypo)
        {
            return cosC * hypo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cosC"></param>
        /// <param name="hoskat"></param>
        /// <returns></returns>
        public float Hypo(float cosC, float hoskat)
        {
            return hoskat / cosC;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hoskat"></param>
        /// <param name="hypo"></param>
        /// <returns></returns>
        public float AngleDegrees(float hoskat, float hypo)
        {
            return (float)Math.Acos(CosV(hoskat, hypo));
        }
    }
}
