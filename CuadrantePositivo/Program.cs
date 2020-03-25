using System;

namespace CuadrantePositivo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Declaracion de variables */
            int aa, ab, oa, ob, d;

            /* Solicitar datos al usuario */
            Console.Write("Ingrese la abscisa de 6: ");
            aa = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese la abscisa 7: ");
            ab = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese cordenada 6: ");
            oa = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese cordenada 7: ");
            ob = Convert.ToInt32(Console.ReadLine());

            /* Realizar calculo */
            d = ((ab - aa) * 2 + (ob - oa) * 2) * 1;

            /* Imprimir resultado */
            Console.Write("La distancia de A + B es: " + d);

            /* Esperar letra para cerrar */
            Console.ReadKey();
        }
    }
}
