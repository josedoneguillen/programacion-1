using System;
using System.Collections.Generic;
using System.Text;

namespace facturaNegocio
{
    class Factura
    {
        /* Atributos */
        private string noPieza;
        private string descPieza;
        private int cantidad;
        private double precioUnd;

        /* Constructor para inicializar atributos */
        public Factura(string noPieza, string descPieza, int cantidad, double precioUnd) 
        {
            /* Asignacion de los atributos por valor en los parametros del constructor de la clase */
            this.noPieza = noPieza;
            this.descPieza = descPieza;
            this.cantidad = cantidad;
            this.precioUnd = precioUnd;
        }

        /* Metodo para leer y acceder al atributo noPieza */
        public string NoPieza {
            get 
            {
                return noPieza;
            }
            set 
            {
                noPieza = value;
            }
        }

        /* Metodo para leer y acceder al atributo descPieza */
        public string DescPieza
        {
            get
            {
                return descPieza;
            }
            set
            {
                descPieza = value;
            }
        }

        /* Metodo para leer y acceder al atributo cantidad */
        public int Cantidad
        {
            get
            {
                return cantidad;
            }
            set
            {
                /* Solo modificar el atributo cantidad si el valor recibido es positivo */
                if (value > 0) 
                {
                    cantidad = value;
                }
                
            }
        }

        /* Metodo para leer y acceder al atributo precioUnd */
        public double PrecioUnd
        {
            get
            {
                return precioUnd;
            }
            set
            {
                /* Solo modificar el atributo precioUnd si el valor recibido es positivo */
                if (value > 0)
                {
                    precioUnd = value;
                }

            }
        }

        /* Metodo para obtener el valor de la factura en tipo decimal */
        public decimal GetMontoFactura()
        {
            return (decimal)(this.cantidad * this.precioUnd);
        }

    }
}
