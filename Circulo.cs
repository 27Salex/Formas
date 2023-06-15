using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    public class Circulo : Forma
    {
        private int radio;

        public Circulo(int r)
        {
            radio = r;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(radio, 2);
        }
        public override double Perimetro()
        {
            return 2 * Math.PI * radio;
        }
    }
    
}
