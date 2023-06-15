using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Formas
{
    public class Diagrama
    {

        private List<Forma> formas = new List<Forma>();
        private bool creandoDiagrama = true;

        public Diagrama()
        {
            while (creandoDiagrama)
            {
                Console.Clear();
                Console.WriteLine("Vamos a construir el diagrama");
                Console.WriteLine("Añadamos algunas figuras");
                Console.WriteLine();
                Console.WriteLine(ToString());
                Console.WriteLine();
                Console.WriteLine("Escoge una opción: " +
                    "\n\t(0) para circulo " +
                    "\n\t(1) para rectangulo " +
                    "\n\t(2) para rombo " +
                    "\n\t(3) para terminar el diagrama ");
                Choice(Console.ReadLine());
            }
        }
        
        private void Choice(string option)
        {
            switch (option)
            {
                case "0":
                    PonerCirculos();
                    break;
                case "1":
                    PonerRectangulos();
                    break;
                case "2":
                    PonerRombos();
                    break;
                case "3":
                    creandoDiagrama = false;
                    break;
                default:
                    Console.Write("Esa opcion no es vàlida");
                    Thread.Sleep(750);
                    Console.Write(".");
                    Thread.Sleep(750);
                    Console.Write(".");
                    Thread.Sleep(750);
                    Console.Write(".");
                    Thread.Sleep(7505);
                    break;
            }
        }

        private void PonerRombos()
        {
            Console.Clear();
            Console.WriteLine("Introduce un lado del rombo");
            int lado1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el otro lado del rombo");
            int lado2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la primera diagonal");
            int diagonal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la segunda diagonal");
            int diagonal2 = int.Parse(Console.ReadLine());

            Rombo rombo = new Rombo(lado1, lado2, diagonal1, diagonal2);
            formas.Add(rombo);
        }

        public string CalcularResultados()
        {
            Console.Clear();
            double[] resultado = new double[2];
            for (int i = 0; i < formas.Count; i++)
            {
                resultado[0] = formas[i].Area();
                resultado[1] = formas[i].Perimetro();
            }
            return "El resultado del àrea es: " + resultado[0] +
                "\nEl resultado del perímetro es:" + resultado[1];
        }

        public void PonerRectangulos()
        {
            Console.Clear();
            Console.WriteLine("Introduce la base del rectangulo");
            int lado = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la altura del rectangulo");
            int altura = int.Parse(Console.ReadLine());
            Rectangulo rectangulo = new Rectangulo(lado, altura);
            formas.Add(rectangulo);
        }

        public void PonerCirculos()
        {
            Console.Clear();
            Console.WriteLine("Introduce el radio del circulo");
            Circulo circulo = new Circulo(int.Parse(Console.ReadLine()));
            formas.Add(circulo);
        }

        public override string ToString()
        {
            int circulos = 0;
            int rectangulos = 0;
            int rombos = 0;

            if (formas.Count == 0)
                return "no tienes figuras todavia";

            foreach (var forma in formas)
            {
                if (forma.GetType() == typeof(Circulo))
                    circulos++;
                else if (forma.GetType() == typeof(Rectangulo))
                    rectangulos++;
                else if (forma.GetType() == typeof(Rombo))
                    rombos++;
            }
            return "Actualmente tienes\n\t " + circulos + " circulos,\n\t " + rectangulos + " Rectangulos\n\t " + rombos + " Rombos\n en total en tu diagrama.";
        }
    }
}
