using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTANAKA01
{
    internal class Triangulo
    {
        float b;
        float h;
        public Triangulo(float b, float h)
        {
            this.b = b;
            this.h = h;
        }
        public float CalculateArea()
        {
            return (b*h)/2;
        }
    }
}
