/*
 * 1. Escribir un programa que lea:
 *      a. El nombre,
 *      b. Horas trabajadas,
 *      c. Precio por horas de varios empleados.
 *      
 * 2. El programa Dejará de solicitar información cuando el usuario introduzca x o X.
 * 
 * 3. Debes ir guardando cada nombre, horas y precio por horas.
 * 
 * 4. Realiza el cálculo del monto a pagar a cada empleado.
 * 
 * 5. Al finalizar el programa muestra el nombre, la cantidad de horas trabajadas, precio por hora y el monto a recibir por cada uno.
 * 
 * 6. Como mínimo se deben leer 5 empleados.
 */
using System;
using System.Collections.Generic;

namespace sueldoPorHoraEmpleados
{
    class Program
    {
        //Declarando estructura de empleados
        public struct empleado {
            public string nombre { set; get; }
            public int horasTrabajadas { set; get; }
            public double precioPorHora { set; get; }
        }

        /* Declaracion de lista statica de tipo empleado para almacenar los empleados */
        public static List<empleado> empleados = new List<empleado>();

        static void Main(string[] args)
        {
            // Declaracion de variables
            char salir;
            string nombre;
            int horasTrabajadas;
            double precioPorHora;

            // Ciclo do while para agregar empleados miestras el usuario no presione x o X
            do 
            {
                //Limpiar la consola en cada iteracion
                Console.Clear();

                //Solicitar al usuario el nombre del empleado
                Console.WriteLine("Ingrese el nombre del empleado:");

                //Almacenar el nombre del empleado en la variable nombre
                nombre = Console.ReadLine();

                //Solicitar al usuario las horas que trabajo el empleado
                Console.WriteLine("Ingrese las horas que trabajo el empleado:");

                //Almacenar las horas que trabajo el empleado en la variable horasTrabajadas
                horasTrabajadas = Convert.ToInt32(Console.ReadLine());

                //Solicitar al usuario las horas que trabajo el empleado
                Console.WriteLine("Ingrese el precio por hora de trabajo para empleado:");

                //Almacenar el precio por hora de trabajo para empleado en la variable precioPorHora
                precioPorHora = Convert.ToDouble(Console.ReadLine());

                //Crear nuevo empleado en la lista empleados utilizando los datos suministrados por el usuario
                empleados.Add(new empleado {nombre = nombre, horasTrabajadas = horasTrabajadas, precioPorHora = precioPorHora});

                //Presentar al usuario la opcion de continuar agregando empleados o salir del ciclo
                Console.WriteLine("El empleado fue agregado! si desea agregar otro presione <X> de lo contrario cualquier otra letra lo enviara a ver los empleados agregados.");
                salir = Convert.ToChar(Console.ReadLine());

            } while (salir != 'x' || salir != 'x');

            //Limpiar la consola al salir del ciclo
            Console.Clear();

            //Imprimir titulo de la lista
            Console.WriteLine("Listado de empleados" + Environment.NewLine);

            // Al salir del ciclo utilizaremos un ciclo foreach para iterar los objetos de la lista empleados
            foreach (empleado empleado in empleados) 
            {
                //Impirmir nombre
                Console.WriteLine($"Nombre: {empleado.nombre}");

                //Impirmir horasTrabajadas
                Console.WriteLine($"Horas trabajadas: {empleado.horasTrabajadas}");

                //Impirmir precioPorHora
                Console.WriteLine($"Precio por hora: {empleado.precioPorHora}");

                //Impirmir el total a recibir
                Console.WriteLine("Total a recibir: " + (empleado.horasTrabajadas * empleado.precioPorHora));

                // Imprimir separador de lista
                Console.WriteLine(Environment.NewLine + "========================================================" + Environment.NewLine);

            }

            //Esperar letra para cerrar el programa
            Console.ReadKey();
        }
    }
}
