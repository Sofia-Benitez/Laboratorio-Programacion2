using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public class PuntoTxt<T> : Archivo, IArchivo<T>
    {
        protected override string Extension
        {
            get
            {
                return ".txt";
            }
        }

        public void Guardar(string ruta, T contenido)
        {
            throw new NotImplementedException();
        }

        public void GuardarComo(string ruta, T contenido)
        {
            throw new NotImplementedException();
        }

        public T Leer(string ruta)
        {
            throw new NotImplementedException();
        }
    }
}
