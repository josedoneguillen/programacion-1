/*
 * Crear  un  programa algoritmo  que  solicite  un  numero entero y diferentea cero, e indique si es par.
 */
using System;

namespace NumeroPar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            int numero = 0;
            bool error = false;

            // Ciclo do While para solicitar numero mientras exista un error
            do
            {
                // Definir error como falso en cada iteracion
                error = false;

                // Limpiar la consola en cada iteracion
                Console.Clear();

                // Solicitar numero al usuario
                Console.WriteLine("Ingrese un numero entero");

                // Manejo de excepciones para evitar ingresar otro numero que no sea entero
                try
                {

                    // Almacenar numero ingresado por el usuario
                    numero = Convert.ToInt32(Console.ReadLine());

                    // Sentencia if para validar diferente a cero
                    if (numero <= 0)
                    {
                        // Mostrar mensaje al usuario
                        Console.WriteLine("El numero ingresado es menor o igual a 0");

                        // Esperar letra para continuar
                        Console.WriteLine("Presione <ENTER> para continuar");
                        Console.ReadKey();

                        // Cambiar el estado del error a true para que el ciclo vuelva a pedir el numero
                        error = true;
                    }
                    else
                    {
                        // Sentencia if para validar si el numero es par
                        if (numero % 2 == 0)
                        {
                            // Mostrar mensaje al usuario
                            Console.WriteLine($"El numero {numero} es par");
                        }
                        else
                        {
                            // Mostrar mensaje al usuario
                            Console.WriteLine($"El numero {numero} no es par");
                        }
                    }

                }
                catch (Exception e)
                {

                    // Imprimir mensaje de error
                    Console.WriteLine(e.Message);

                    // Esperar letra para continuar
                    Console.WriteLine("Presione <ENTER> para continuar");
                    Console.ReadKey();

                    // Cambiar el estado del error a true para que el ciclo vuelva a pedir el numero
                    error = true;

                }

            } while (error);


            // Esperar letra para cerrar
            Console.ReadKey();
        }
    }
}
