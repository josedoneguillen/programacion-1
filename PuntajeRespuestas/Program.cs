using System;

namespace PuntajeRespuestas
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Declaracion de variables */
            int pf, rc, ri, rb, prc, pri;

            /* Solicitar al usuario cantidad de respuestas correctas */
            Console.Write("Ingrese la cantidad de respuestas correctas: ");
            rc = Convert.ToInt32(Console.ReadLine());

            /* Solicitar al usuario cantidad de respuestas incorrectas */
            Console.Write("Ingrese la cantidad de respuestas incorrectas: ");
            ri = Convert.ToInt32(Console.ReadLine());

            /* Solicitar al usuario cantidad de respuestas en blanco */
            Console.Write("Ingrese la cantidad de respuestas en blanco: ");
            rb = Convert.ToInt32(Console.ReadLine());

            /* Calculos */
            prc = rc * 4;
            pri = ri * -1;
            pf = prc + pri;

            /* Imprimir resultados */
            Console.WriteLine("Puntaje de respuestas correctas: " + prc);

            Console.WriteLine("Puntaje de respuestas incorrectas: " + pri);

            Console.WriteLine("Puntaje de respuestas en blanco: " + rb);

            Console.WriteLine("Puntaje final: " + pf);

            /* Esperar letra para cerrar */
            Console.ReadKey();
        }
    }
}
