using System;

namespace AnioDiaHoraEnSegundos
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Declaracion de variables */
            int Min = 60;
            int Hour = Min * Min;
            int Day = Hour * 24;
            int Year = Day * 365;

            /* Imprimir resultados */
            Console.WriteLine($"Segundos en una hora: {Hour}");
            Console.WriteLine($"Segundos en un dia: {Day}");
            Console.WriteLine($"Segundos en un año: {Year}");

            //Esperar para cerrar
            Console.ReadKey();
        }
    }
}
