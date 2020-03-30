using System;
using System.IO;

namespace CompararArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaracion de variables
            string File1Route = @"C:\csharp\test1.txt";
            string File2Route = @"C:\csharp\test2.txt";
            int File1Size;
            int File2Size;
            FileStream File1;
            FileStream File2;

            /* Validar que las rutas no apunten al mismo archivo */
            if (File1Route != File2Route)
            {

                // Abrir archivos
                File1 = new FileStream(File1Route, FileMode.Open); 
                File2 = new FileStream(File2Route, FileMode.Open);

                // Cliclo do While para leer cada byte del archivo
                do
                {
                    // Uso de la funcion ReadByte
                    File1Size = File1.ReadByte();
                    File2Size = File2.ReadByte();

                } while ( (File1Size  == File2Size) && (File1Size != -1 && File2Size != -1) );

                //Cerrar los archivos
                File1.Close();
                File2.Close();

                // Comparar bytes para saber si los archivos son iguales
                if ((File1Size - File2Size) == 0)
                {
                    Console.WriteLine("Los archivos son iguales");
                }
                else
                {
                    Console.WriteLine("Los archivos no son iguales");
                }

                }
            else 
            {
                // Imprimir mensaje al usuario
                Console.WriteLine("Estas revisando el mismo archivo");
            }

            // Esperar letra para cerrar
            Console.ReadKey();
        }
    }
}
