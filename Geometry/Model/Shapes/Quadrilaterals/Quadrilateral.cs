namespace Geometry.Model
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Quadrilateral : Polygon
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sides"></param>
        protected Quadrilateral(int sides) : base(sides) { }
    }
}