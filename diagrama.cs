using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    public class Diagrama : Forma
    {

        private List<Rectangulo> listaRectangulos = new List<Rectangulo>();
        private List<Circulo> listaCirculos = new List<Circulo>();
        private List<Rombo> listaRombos = new List<Rombo>();
        
        public Diagrama()
        {
            Console.WriteLine("Vamos a construir el diagrama");
            Console.WriteLine("Quieres circulo? pon 1 para SI o 2 para NO");
            if (Console.ReadLine() == "1")
            {

            }

        }

        public PonerCirculos()
        {
            Console.WriteLine("Introduce el radio del circulo");
        }
    }
}
