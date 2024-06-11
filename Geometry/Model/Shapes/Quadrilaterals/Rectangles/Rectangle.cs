namespace Geometry.Model.Shapes
{
    public class Rectangle : Quadrilateral
    {
        public float Length { get; private set; }
        public float Height { get; private set; }

        public Rectangle(int sides) : base(sides)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="length"></param>
        /// <param name="sides"></param>
        public Rectangle(float length) : base(4)
        {
            Length = length;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="length"></param>
        /// <param name="height"></param>
        /// <param name="sides"></param>
        public Rectangle(float length, float height) : this(length)
        {
            Height = height;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override float Area()
        {
            return Length * Height;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override float Circumfence()
        {
            return (Length * 2) + (Height * 2);
        }
    }
}
