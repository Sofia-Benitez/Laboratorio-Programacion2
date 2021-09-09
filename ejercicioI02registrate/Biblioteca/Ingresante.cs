using System;
using System.Text;

namespace Biblioteca
{
    public class Ingresante
    {
        private string[] cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante(string nombre, int edad, string direccion, string genero, string pais, string[] cursos)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.direccion = direccion;
            this.genero = genero;
            this.pais = pais;
            this.cursos = cursos;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Direccion: {this.direccion}");
            sb.AppendLine($"Edad: {this.edad}");
            sb.AppendLine($"Genero: {this.genero}");
            sb.AppendLine($"Pais: {this.pais}");
            sb.AppendLine("Cursos:");
            for (int i = 0; i < cursos.Length; i++)
            {
                if(!(cursos[i] is null))
                {
                    sb.AppendLine($"{this.cursos[i]}");
                }
            }
            
                
            
            

            return sb.ToString();
        }

    }
}
