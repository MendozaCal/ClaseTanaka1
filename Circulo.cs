using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTANAKA01
{
    internal class Circulo
    {
        private float r;

        public Circulo(float r)
        {
            this.r = r;
        }

        public float GetArea()
        {
            return 3.14f * r * r;
        }

        public float GetPerimeter()
        {
            return 3.14f * (r + r);
        }
    }
}
