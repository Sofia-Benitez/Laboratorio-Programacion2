using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class AppMusical : Aplicacion
    {
        protected List<string> listaCanciones;

        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb):this(nombre, sistemaOperativo, tamanioMb, new List<string>())
        {

        }

        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb, List<string> listaCanciones) : base(nombre, sistemaOperativo, tamanioMb)
        {
            if(listaCanciones is not null)
            {
                this.listaCanciones = listaCanciones;
            }
            else
            {
                this.listaCanciones = new List<string>();
            }
        }

        protected override int Tamanio
        {
            get
            {
                return this.tamanioMb + listaCanciones.Count*2;
            }
        }

        public override string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"{Environment.NewLine}Lista canciones: ");
            foreach (string item in listaCanciones)
            {
                sb.AppendLine(item);
            }
            return sb.ToString();
        }
    }
}
