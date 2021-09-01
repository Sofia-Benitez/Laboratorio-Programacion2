using System;
using System.Text;

namespace Biblioteca
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigoDeBarra,  float precio)
        {
            
            this.marca = marca;
            this.codigoDeBarra = codigoDeBarra;
            this.precio = precio;

        }

        public string GetMarca()
        {
            return marca;
        }

        public float GetPrecio()
        {
            return precio;
        }

        public static string MostrarProducto(Producto producto)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Codigo de barra {producto.codigoDeBarra}");
            sb.AppendLine($"Marca: {producto.marca}");
            sb.AppendLine($"Precio:$ {producto.precio}");

            return sb.ToString();
        }

        /*explicit: Realizará la conversión de un objeto Producto a string. 
         * Sólo retornará el atributo codigoDeBarras del producto.
         */

        public static explicit operator string(Producto producto)
        {
            return producto.codigoDeBarra;
        }
        //== (Producto, Producto): Retornará true si las marcas y códigos de barra son iguales, false caso contrario.
        public static bool operator ==(Producto producto1, Producto producto2)
        {
            return (producto1.marca == producto2.marca && 
                (producto1.codigoDeBarra == producto2.codigoDeBarra));
           
        }
        public static bool operator !=(Producto producto1, Producto producto2)
        {
            return !(producto1==producto2);
        }

        //== (Producto, string): Retornará true si la marca del producto coincide con la cadena pasada como argumento, false caso contrario.
        public static bool operator ==(Producto producto1, string marca)
        {
            return producto1.marca == marca;
        }

        public static bool operator !=(Producto producto1, string marca)
        {
            return !(producto1==marca);
        }


    }
}
