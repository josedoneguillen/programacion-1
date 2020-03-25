using System;

namespace PromedioEstudiante
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Declaracion de variables */
            double nta1, nta2, nta3, promedio;

            /* Solicitar al usuario nota parcial */
            Console.Write("Ingrese, primera nota parcial: ");
            nta1 = Convert.ToDouble(Console.ReadLine());

            /* Solicitar al usuario nota parcial */
            Console.Write("Ingrese, segunda nota parcial: ");
            nta2 = Convert.ToDouble(Console.ReadLine());

            /* Solicitar al usuario nota parcial */
            Console.Write("Ingrese, tercera nota parcial: ");
            nta3 = Convert.ToDouble(Console.ReadLine());

            /* Realizar calculo del promedio */
            promedio = (nta1 + nta2 + nta3) / 3;

            /* Imprimir resultado promedio */
            Console.WriteLine("El promedio final es: " + promedio.ToString("F"));

            /* Esperar letra para cerrar */
            Console.ReadKey();
        }
    }
}
