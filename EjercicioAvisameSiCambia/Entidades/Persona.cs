using System;

namespace Entidades
{
    public delegate void DelegadoString(string msg);
    public class Persona
    {
        private string apellido;
        private string nombre;

        public event DelegadoString EventoString;
        public Persona()
        {
        }

        public string Apellido
        {
            get => apellido;
            set
            {
                apellido = value;
                EventoString(apellido);
            }
        }

        public string Nombre
        { 
            get => nombre;
            set
            {
                nombre = value;
                EventoString(nombre);
            }

            
        
        }

        public string Mostrar()
        {
            return nombre + " " + apellido;
        }
    }
}
