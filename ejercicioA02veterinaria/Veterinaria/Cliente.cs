using System;
using System.Text;


namespace Veterinaria
{
    public class Cliente
    {
        private string apellido;
        private string nombre;
        private string telefono;
        private string direccion;
        public Mascota[] mascotas = new Mascota[5];

      
        public Cliente(string apellido, string nombre, string telefono, string direccion)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.telefono = telefono;
            this.direccion = direccion;
  
        }

        public void AgregarMascota(Mascota nuevaMascota)
        {
            for (int i = 0; i <this.mascotas.Length; i++)
            {
                if(this.mascotas[i] == null)
                {
                    this.mascotas[i] = nuevaMascota;
                    break;
                }
            }
           
        }

        

        public string MostrarCliente()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Telefono: {this.telefono}");
            sb.AppendLine($"Direccion: {this.direccion}");
            sb.AppendLine("-----Mascotas-----");
            for (int i = 0; i < this.mascotas.Length; i++)
            {
                if(!(mascotas[i] is null))
                {
                    sb.AppendLine($"{this.mascotas[i].MostrarMascota()}");
                }
                
            }
            return sb.ToString();

        }
    }
}
