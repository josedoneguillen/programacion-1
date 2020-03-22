using System;

namespace CuentaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Objeto de cada clase y muestrando su funcionamiento */

            //Instancia cuenta de ahorro
            cuentaAhorro ahorro = new cuentaAhorro(500, 0.05M);


            /* Mostrar interes ganado cuenta de ahorro */
            Console.WriteLine("El interes ganado por la cuenta de ahorro es: {0}", ahorro.interesGanado());

            /* Mostrar balance de la cuenta de ahorro */
            Console.WriteLine("El balance de la cuenta de ahorro es: {0}", ahorro.consultarBalance() + ahorro.interesGanado());


            //Instancia de cuenta corriente
            cuentaCorriente corriente = new cuentaCorriente(500, 50);

            /* Realizar retiro en cuenta corriente */
            corriente.debito(100);

            /* Mostrar balance de la en cuenta corriente */
            Console.WriteLine("El balance de la cuenta corriente es: {0}", corriente.consultarBalance());
        }
    }

    /* Clase base llamada cuenta */
    class cuenta
    {
        /*  variable de instancia privada de tipo decimal que representará el balance de la cuenta */
        private decimal balance;

        /* constructor que recibe un monto para el balance inicial de la cuenta */
        public cuenta(decimal balanceInicial) 
        {

            /* Valide que el balance inicial sea igual o mayor a 0 */
            if (balanceInicial >= 0)
            {
                this.balance = balanceInicial;
            }
            else {
                Console.WriteLine("El balance inicial de la cuenta debe ser mayor o igual a 0");
            }
            
        }

        /* Método público llamado Crédito que incremente el balance */
        public void credito(decimal aumento) 
        {
            this.balance += aumento;
        }

        /* método publico llamado débito que des incremente el balance */
        public void debito(decimal decremento)
        {
            /* validar que no exceda el balance de la cuenta */
            if (this.balance >= decremento) 
            {
                this.balance -= decremento;
            }
            else
            {
                Console.WriteLine("Su cuenta no tiene fondos suficientes");
            }

        }

        /* Método que devuelva el balance actual de la cuenta */
        public decimal consultarBalance()
        {
            return this.balance;
        }
    }
    /* Clase derivada llamada cuentaAhorro */
    class cuentaAhorro : cuenta
    {
        /*  Variable de instancia tipo decimal, la cual indicara la tasa de interés asignada a la cuenta */
        public decimal tasa;

        /* El constructor de esta clase, debe recibir el balance inicial de la cuenta y la tasa de interés. */
        public cuentaAhorro(decimal balanceInicial, decimal t) : base(balanceInicial)
        {
            this.tasa = t;
        }

        /* Método para mostrar el interés ganado por la cuenta. */
        public decimal interesGanado()
        {
            return (consultarBalance() * this.tasa);
        }
    }
    /* Clase derivada llamada cuentaCorriente */
    class cuentaCorriente : cuenta
    {
        /*  Variable de instancia tipo decimal, la cual indicara la tasa de interés asignada a la cuenta */
        public decimal cargoTransaccion;

        /* El constructor de esta clase, debe recibir el balance inicial de la cuenta y la tasa de interés. */
        public cuentaCorriente(decimal balanceInicial, decimal c) : base(balanceInicial)
        {
            this.cargoTransaccion = c;
        }

        /* Modificar método público llamado Crédito que incremente el balance */
        public new void credito(decimal aumento)
        {
            base.credito(aumento - cargoTransaccion);
        }

        /* Modificar método publico llamado débito que des incremente el balance */
        public new void debito(decimal decremento)
        {
            base.debito(decremento + cargoTransaccion);

        }
    }


}
