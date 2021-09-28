using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public abstract class Aplicacion
    {
        protected string nombre;
        protected SistemaOperativo sistemaOperativo;
        protected int tamanioMb;

        protected Aplicacion(string nombre, SistemaOperativo sistemaOperativo, int tamanio)
        {
            this.nombre = nombre;
            this.sistemaOperativo = sistemaOperativo;
            this.tamanioMb = tamanio;
        }


        public SistemaOperativo SistemaOperativo
        {
            get
            {
                return this.sistemaOperativo;
            }
        }

        protected abstract int Tamanio { get; }

        public implicit operator Aplicacion(List<Aplicacion> listaApp)
        {
            Aplicacion aplicacion = null;
            foreach (var item in listaApp)
            {
                if(aplicacion==null || )
            }
        }

        public virtual string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre de la App: {this.nombre}");
            sb.AppendLine($"SO: {this.sistemaOperativo}");
            sb.AppendLine($"Tamaño en MB: {this.tamanioMb.ToString()}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.ObtenerInformacionApp();
        }

        public static bool operator ==(List <Aplicacion> listaApp, Aplicacion app)
        {
            foreach (Aplicacion item in listaApp)
            {
                if(item.nombre==app.nombre)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(List<Aplicacion> listaApp, Aplicacion app)
        {
            return !(listaApp == app);
        }

        public static bool operator +(List<Aplicacion> listaApp, Aplicacion app)
        {
            if(listaApp!=app)
            {
                listaApp.Add(app);
                return true;
            }
            return false;
        }
    }
}
