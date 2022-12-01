using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Circle : Surface //円
    {
        readonly public float radius;
        public Circle(float radius = 0)
        {
            this.radius = radius;
        }
        public override float GetSurface()
        {
            return radius * radius * MathF.PI;
        }
        public override float GetCircumference()
        {
            return radius * 2 * MathF.PI;
        }
        public override void GetBounds(out float height,out float width)
        {
            height = radius * 2.0f;
            width = radius * 2.0f;
        }
    }
}