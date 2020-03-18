using System;

namespace CalcularRaizLog
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaracion de variables
            double Log9 = Math.Log(9);
            double Sqrt9 = Math.Sqrt(9);

            // Imprimir en resultado en pantalla
            Console.WriteLine("El Logaritmo de 9 es: " + Log9);
            Console.WriteLine("La Raiz Cuadrada de 9 es: " + Sqrt9);

            // Esperar para cerrar
            Console.ReadKey();
        }
    }
}
