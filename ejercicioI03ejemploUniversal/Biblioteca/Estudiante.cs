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
        public Estudiante(string apellido, string nombre, string legajo, int notaPrimerParcial, int notaSegundoParcial, Random random)
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
            if(this.notaPrimerParcial>=4 && this.notaSegundoParcial>=4)
            {
                return random.Next(6, 11);
            }
            else
            { 
                return -1;
            }
            
        }

        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();



            string mensaje = stringBuilder.ToString();

            return mensaje;
        }
    }


}
