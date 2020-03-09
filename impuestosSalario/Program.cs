/*
 * 1. Realiza un programa que solicite el salario mensual de una persona.
 * 2. Si el salario introducido sobre pasa el mínimo para el cálculo del IRS, proyectar ese salario a 1 año y luego calcular el impuesto que pagaría. 
 * 3. Mostrar resultado en pantalla con un comentario apropiado. 
 */
using System;

namespace impuestosSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaracion de variables
            double salario, salarioAnual, impuestoISR = 0.00;

            // Solicitar al usuario ingresar su salario
            Console.WriteLine("Favor de ingresar su sueldo");

            // Almacenar el sueldo en la variable salario
            salario = Convert.ToDouble(Console.ReadLine());

            // Calcular salario anual
            salarioAnual = salario * 12;

            //Declaracion if/else para evaluar en que rango esta el salario anual
            if (salarioAnual >= 399923.01 && salarioAnual <= 599884.00) 
            {

                //Si el salario anual es mayor o igual a 399,923.01 hasta 599,884.00 la tasa de impuestos es de 15% de ese monto
                impuestoISR = salarioAnual * 0.15;

            } 
            else if (salarioAnual >= 599884.01 && salarioAnual <= 883171.00) 
            {
                //Si el salario anual es mayor o igual a 599,884.01 hasta 883,171.00 la tasa de impuestos es de 20,994.00 mas el 20% del sueldo anual
                impuestoISR = 29994.00 + (salarioAnual * 0.20);
            }
            else if (salarioAnual >= 883171.01)
            {
                //Si el salario anual es mayor o igual a 883,171.00 la tasa de impuestos es de 76,652.00 mas el 25% del sueldo anual
                impuestoISR = 76652.00 + (salarioAnual * 0.25);
            }

            //Imprimir resultado en pantalla
            if (impuestoISR == 0.00)
            {
                Console.WriteLine("Usted esta excento del impuesto ISR");
            }
            else 
            {
                Console.WriteLine($"Su sueldo anual es de RD$ {salarioAnual} por lo que debera pagar RD$ {impuestoISR} de impuesto ISR");
            }

            //Esperar tecla para cerrar la consola
            Console.ReadKey();

        }
    }
}
