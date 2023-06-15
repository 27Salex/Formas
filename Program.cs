using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Formas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculadora de diagramas";
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;

            Diagrama diagrama = new Diagrama();
            
            Console.WriteLine(diagrama.CalcularResultados());
            Thread.Sleep(1000);
            Console.ReadKey();
        }
    }
}
