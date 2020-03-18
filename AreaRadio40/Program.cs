using System;

namespace AreaRadio40
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaracion de variables
            double Area, Radio = 40;

            //Realizar calculo
            Area = Radio * Radio * Math.PI;

            // Imprimir resultado
            Console.WriteLine($"El area del circulo es de: {Area}");

            // Esperar para cerrar
            Console.ReadKey();
        }
    }
}
