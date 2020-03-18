using System;

namespace Nombre
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaracion de variables
            string Name;

            // Solicitar el nombre del usuario
            Console.WriteLine("Ingrese su nombre");

            // Almacenar la linea en la variable Name
            Name = Console.ReadLine();

            // Imprimir en resultado en pantalla
            Console.WriteLine("Hola, " + Name);

            // Esperar para cerrar
            Console.ReadKey();
        }
    }
}
