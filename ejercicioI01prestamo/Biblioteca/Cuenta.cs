using System;
using System.Text;

/*mostrar retornará una cadena de texto con todos los datos de la cuenta.
ingresar recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada.
retirar recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.
 * 
 * 
 */
namespace Biblioteca
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        {
            return titular;
        }

        public decimal GetCantidad()
        {
            return cantidad;
        }

        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Titular: {GetTitular()}. Cantidad: {GetCantidad()}");
            string mensaje = stringBuilder.ToString();

            return mensaje;
        }

        public bool Ingresar(decimal valor)
        {
            bool todoOk = false;

            if(valor>0)
            {
                this.cantidad += valor;
                todoOk=true;
            }

            return todoOk;
        }

        public decimal Retirar(decimal valor)
        {
            
            this.cantidad -= valor;
            return this.cantidad;
        }
    }
}
