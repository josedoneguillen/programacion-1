/*
Esta actividad consiste en la creación de una clase. La clase se debe llamar Factura, esta factura pudiera ser usada por un negocio para presentar un artículo vendido. Realiza lo siguiente:

a) Debe incluir cuatro piezas de información como variables de instancia o propiedades automáticas:
1. Un número de pieza - tipo string.
2. Descripción de la pieza – Tipo string.
3. Cantidad del artículo que se está comprando - Tipo int
4. Precio por artículo – Tipo decimal.

b) La clase debe tener un constructor que inicialice los cuatro valores. Crear un método para acceder y leer cada variable.
c) Validar que, si se pasa un valor negativo para cantidad o precio, el valor de la variable de instancia no debe modificarse.
d) Crear un método llamado GetMontoFactura que calcule el importe de la factura y lo devuelva como un valor decimal.
e) Escribe un programa donde muestre el funcionamiento de la clase.

Para realizar la entrega de la actividad utiliza un procesador de texto y coloca las pantallas donde se evidencie el proceso realizado, entrega de la forma como se especifica a continuación.
*/
using System;

namespace facturaNegocio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al programa para ver facturas");

            // Creamos una instancia de la clase factura es decir un objeto
            Factura fact1 = new Factura("123456", "Una pieza de prueba", 10, 10.95);

            // Obtener descripcion de la factura
            Console.WriteLine(fact1.DescPieza);

            // Modificar cantidad de la factura por un numero negativo
            fact1.Cantidad = -10;

            // Obtener cantidad de la factura
            Console.WriteLine(fact1.Cantidad);

            // Obtener el total de la factura llamando el metodo GetMontoFactura
            Console.WriteLine(fact1.GetMontoFactura());

            // Esperar letra para cerrar la consola
            Console.ReadKey();
        }
    }
}
