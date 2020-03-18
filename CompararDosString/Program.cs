using System;
namespace CompararDosString
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaracion de variables
            string value1, value2;

            // Solicitar valores al usuario
            Console.WriteLine("Introduzca primer valor");
            value1 = Console.ReadLine();

            Console.WriteLine("Introduzca segundo valor");
            value2 = Console.ReadLine();

            // Declaracion if para comparar los dos valores
            if (value1 == value2)
            {
                Console.WriteLine(value1 + " y " + value1 + " son iguales");
            }
            else
            {
                Console.WriteLine(value1 + " y " + value1 + " son diferentes");
            }

            // Esperar para cerrar
            Console.ReadKey();
        }
    }
}
