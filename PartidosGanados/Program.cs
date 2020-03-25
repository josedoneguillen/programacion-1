using System;

namespace PartidosGanados
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Declaracion de variables */
            int pt, pg, pe, pp, ppg, ppe;

            /* Solicitar al usuario cantidad de partidos */
            Console.Write("Ingrese la cantidad de partidos ganados: ");
            pg = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese la cantidad de partidos empatados: ");
            pe = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese la cantidad de partidos perdidos: ");
            pp = Convert.ToInt32(Console.ReadLine());

            /* Calculos */
            ppg = pg * 3;
            ppe = pe * 1;
            pt = ppg + ppe;

            /* Imprimir resultados */
            Console.WriteLine("Puntaje de partidos ganados:  " + ppg);    
            Console.WriteLine("Puntaje de partidos empatados: " + ppe);
            Console.WriteLine("Puntaje de partidos perdidos: " + pp);
            Console.WriteLine("Puntaje total: " + pt);

            /* Esperar letra para cerrar */
            Console.ReadKey();

        }
    }
}
