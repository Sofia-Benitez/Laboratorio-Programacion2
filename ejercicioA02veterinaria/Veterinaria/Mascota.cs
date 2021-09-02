using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    public class Mascota
    {
        public string nombre;
        public string especie;
        public DateTime fechaNacimiento;
        public string[] historialVacunas = new string[5];
       
        

        public Mascota(string nombre, string especie, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.especie = especie;
            this.fechaNacimiento = fechaNacimiento;
        }

        

        public void AgregarVacuna(string nuevaVacuna)
        {
            for (int i = 0; i < this.historialVacunas.Length; i++)
            {
                if((historialVacunas[i] is null))
                {
                    historialVacunas[i] = nuevaVacuna;
                    break;
                }
            }
        }

        public string MostrarMascota()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Especie: {this.especie}");
            sb.AppendLine($"Fecha nacimiento: {this.fechaNacimiento.ToShortDateString()}");
            sb.AppendLine("Vacunas:");
            for (int i = 0; i < this.historialVacunas.Length; i++)
            {
                if(!(historialVacunas[i] is null))
                {
                    sb.AppendLine($"{i+1}- {historialVacunas[i]}");
                }
            }   

            return sb.ToString();

        }

    }
}
