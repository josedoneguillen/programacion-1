/*
 En esta actividad realizarás un programa para poner en práctica los conceptos vistos sobre los tipos de datos.
 
    1. Escribe un programa en el cual se solicite al usuario que introduzca:
        a. Nombre
        b. Apellido
        c. Edad
        d. Ciudad donde vive
        e. Si es soltero o casado
        f. Que sueldo le gustaría percibir

    2. A cada pregunta, le mostrará en pantalla lo que acaba de escribir, pero con un comentario apropiado.
    Por ejemplo:
        • Favor dígame su nombre: Antonio
        • Resp. Saludos Antonio, dígame su apellido: Pérez
        • Resp. Bienvenido Antonio Pérez….
        • Y así sucesivamente hasta completar el cuestionario.

Para realizar la entrega de la actividad utiliza un procesador de texto y coloca las pantallas donde se evidencie el proceso realizado, 
entrega de la forma como se especifica a continuación. 
*/

using System;

namespace cuestionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuestionario");

            // Declaracion de variales
            string firstName;
            string lastName;
            int age;
            string city;
            bool married = false;
            double salary;

            // Solicitar al usuario que ingrese su nombre
            Console.WriteLine("Favor dígame su nombre:");

            // Almacenar el valor introducido por el cliente el la variable firstName
            firstName = Console.ReadLine();

            // Solicitar al usuario que ingrese su apellido
            Console.WriteLine($"Saludos {firstName}, dígame su apellido:");

            // Almacenar el valor introducido por el cliente el la variable lastName
            lastName = Console.ReadLine();

            // Solicitar al usuario que ingrese su edad
            Console.WriteLine($"Bienvenido {firstName} {lastName}, cual es su edad:");

            // Almacenar el valor introducido por el cliente el la variable age
            age = Convert.ToInt32(Console.ReadLine());

            // Solicitar al usuario que ingrese su ciudad
            Console.WriteLine($"{firstName} {lastName}, si tiene {age} años, cual es su ciudad:");

            // Almacenar el valor introducido por el cliente el la variable city
            city = Console.ReadLine();

            // Solicitar al usuario que ingrese su ciudad
            Console.WriteLine($"{firstName} {lastName}, usted tiene {age} años y vive en {city}, digame si esta casado:");
            Console.WriteLine("1- Si" + Environment.NewLine + "2- No");

            // Almacenar el valor introducido por el cliente el la variable city
            married = (Console.ReadLine() == "1") ? true : false;

            // Solicitar al usuario que ingrese su sueldo deseado
            Console.WriteLine($"{firstName} {lastName}, con {age} años viviendo en {city}, Que sueldo le gustaría percibir:");

            // Almacenar el valor introducido por el cliente el la variable salary
            salary = Convert.ToDouble(Console.ReadLine());


        }
    }
}
