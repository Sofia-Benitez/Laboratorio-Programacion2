using System;
using System.Text;

namespace Biblioteca
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaNacimiento;
        private string dni;

        public Persona(string nombre, DateTime fechaNacimiento, string dni)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.dni = dni;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public string GetDni()
        {
            return dni;
        }

        public string GetFechaNacimiento()
        {
            return fechaNacimiento.ToShortDateString();
        }

        public void SetNombre(string nuevoNombre)
        {
            if(nuevoNombre.Length<30)
            {
               this.nombre = nuevoNombre;
            }
            
        }

        public void SetDni(string nuevoDni)
        {
            this.dni = nuevoDni;
        }

        public void SetFechaNacimiento(DateTime nuevaFechaNacimiento)
        {
            this.fechaNacimiento = nuevaFechaNacimiento;
        }

        private int CalcularEdad()
        {
            DateTime fechaActual = DateTime.Today;

            int edad = fechaActual.Year - this.fechaNacimiento.Year;

            return edad;

        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {GetNombre()}.");
            sb.AppendLine($"Fecha de nacimiento: {GetFechaNacimiento()}.");
            sb.AppendLine($"DNI: {GetDni()}");
            sb.AppendLine($"Edad: {CalcularEdad()}");

            return sb.ToString();

        }

        public string EsMayorDeEdad()
        {
            StringBuilder sb = new StringBuilder();
            if (CalcularEdad() >= 18)
            {
                sb.AppendLine("Es mayor de edad");
            }
            else
            {
                sb.AppendLine("Es menor de edad");
            }

            return sb.ToString();
        }
    }
}
