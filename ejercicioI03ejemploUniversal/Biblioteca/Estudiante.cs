using System;
using System.Text;

namespace Biblioteca
{
    public class Estudiante
    {
        private string apellido;
        private string nombre;
        private string legajo;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante() // constructor estatico
        {
            random = new Random();
        }

        //cnstructor de instancia
        public Estudiante(string apellido, string nombre, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
          
        }

        public void SetNotaPrimerParcial(int nuevaNotaPrimerParcial)
        {
           this.notaPrimerParcial = nuevaNotaPrimerParcial;
        }

        public void SetNotaSegundoParcial(int nuevaNotaSegundoParcial)
        {
             this.notaSegundoParcial = nuevaNotaSegundoParcial;
        }

        public float CalcularPromedio()
        {
            float promedio = (this.notaPrimerParcial + (float)this.notaSegundoParcial) / 2;
            return promedio;
        }

        public double CalcularNotaFinal()
        {
            double notaFinal = -1;

            if(this.notaPrimerParcial>=4 && this.notaSegundoParcial>=4)
            {
                notaFinal= random.Next(6, 11);
            }

            return notaFinal;
        }

        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Nombre: {this.nombre}. Apellido: {this.apellido}. Legajo: {this.legajo}");
            stringBuilder.AppendLine($"Nota primer parcial: {this.notaPrimerParcial}. Nota segundo parcial: {this.notaSegundoParcial}");
            stringBuilder.AppendLine($"Promedio: {CalcularPromedio()}");

            if(CalcularNotaFinal() == -1)
            {
                stringBuilder.AppendLine("Alumno desaprobado");
            }
            else
            {
                stringBuilder.AppendLine($"Nota final: {CalcularNotaFinal()}");
            }
            

            string mensaje = stringBuilder.ToString();

            return mensaje;
        }
    }


}
