using System;

namespace Geometry.Model.Shapes
{
    public class Parallelogram : Quadrilateral
    {
        public float Length { get; private set; }
        public float Height { get; private set; }
        public float Width { get; private set; }
        public float PointyAngles { get; private set; }
        public Parallelogram(float length, float height, float pointyAngles) : base(4)
        {
            Length = length;
            Height = height;
            Width = height * this.Sine.Hypo(((float)Math.Sin(pointyAngles)).ToAngle(), height);
        }

        public override float Area()
        {
            return Length * Height * (float)Math.Sin(PointyAngles);
        }

        public override float Circumfence()
        {
            return (Length * 2) + (Width * 2);
        }
    }
}
