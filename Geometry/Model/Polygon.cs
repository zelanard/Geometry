namespace Geometry.Model
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Polygon : IPolygon
    {
        public int Sides { get; }
        protected Cosine Cosine = new Cosine();
        protected Sine Sine = new Sine();
        protected Pythagoras Pythagoras = new Pythagoras();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sides"></param>
        protected Polygon(int sides)
        {
            Sides = sides;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int AngleSum()
        {
            int sum = 180 * (Sides - 2);
            return sum;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public float Sum(params float[] values)
        {
            float sum = 0;
            foreach (float i in values)
            {
                sum += i;
            }
            return sum;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract float Area();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract float Circumfence();

    }
}
