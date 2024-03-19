using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTANAKA01
{
    internal class Rectángulo
    {
        private float b;
        private float h;

        public Rectángulo(float b, float h)
        {
            this.b = b;
            this.h = h;
        }

        public float GetArea()
        {
            return b * h;
        }

        public float GetPerimeter()
        {
            return 2 * (b + h);
        }
    }
}
