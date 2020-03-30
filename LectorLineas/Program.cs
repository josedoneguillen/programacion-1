using System;
using System.Text;
using System.IO;

namespace LectorLineas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaracion de variables
            string FilePath = @"C:\csharp\test1.txt";

            // Abrir el archivo en modo de lectura
            var FileS = new FileStream(FilePath, FileMode.Open, FileAccess.ReadWrite);

            // Leer el archivo en formato utf-8
            var SourceR = new StreamReader(FileS, Encoding.UTF8);

            // Variable que almacenara cada linea durante el ciclo
            string Line;

            // Variable para el nuevo texto
            string NewText = "";

            // Variable para contar cada linea
            int LineCount = 1;

            // Imprimir texto
            Console.WriteLine("Antes");

            // Ciclo while para recorrer cada linea
            while ((Line = SourceR.ReadLine()) != null)
            {

                // Imprimir linea
                Console.WriteLine(Line);

                // Guardar nueva linea
                NewText += LineCount + " " + Line + "\n";

                // Incrementar contador 
                LineCount++;
            }

            // Cerrar el archivo
            FileS.Close();

            // Limpiar archivo
            File.WriteAllText(FilePath, String.Empty);


            // Imprimir texto
            Console.WriteLine(Environment.NewLine + "=====================================" + Environment.NewLine);


            // Abrir el archivo en modo de lectura
            FileS = new FileStream(FilePath, FileMode.Open, FileAccess.ReadWrite);

            // Sobreescribir el archivo con el nuevo texto
            FileS.Write(Encoding.Unicode.GetBytes(NewText), 0, Encoding.Unicode.GetByteCount(NewText));

            // Cerrar el archivo
            FileS.Close();

            // Abrir el archivo en modo de lectura
            FileS = new FileStream(FilePath, FileMode.Open, FileAccess.Read);

            // Leer el archivo en formato utf-8
            SourceR = new StreamReader(FileS, Encoding.UTF8);


            // Imprimir texto
            Console.WriteLine("Despues");

            // Ciclo while para recorrer cada linea
            while ((Line = SourceR.ReadLine()) != null)
            {
                // Imprimir linea
                Console.WriteLine(Line);

            }

            // Cerrar el archivo
            FileS.Close();

            // Esperar letra para cerrar
            Console.ReadKey();
        }
    }
}
