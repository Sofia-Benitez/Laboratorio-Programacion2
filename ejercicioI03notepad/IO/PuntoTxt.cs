using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public class PuntoTxt : Archivo, IArchivo<string>
        
    {
        protected override string Extension
        {
            get
            {
                return ".txt";
            }
        }

        public void Guardar(string ruta, string contenido)
        {
            if (ValidarSiExisteElArchivo(ruta) && ValidarExtension(ruta))
            {
                Escribir(ruta, contenido);
            }
        }

      
        public void GuardarComo(string ruta, string contenido)
        {
            if (ValidarExtension(ruta))
            {
                Escribir(ruta, contenido);
            }
        }

        public string Leer(string ruta)
        {
            if (ValidarSiExisteElArchivo(ruta) && ValidarExtension(ruta))
            {
                using (StreamReader streamReader = new StreamReader(ruta))
                {
                    return streamReader.ReadToEnd();
                }
            }

            return string.Empty;
        }

        private void Escribir(string ruta, string contenido)
        {
            using (StreamWriter streamWriter = new StreamWriter(ruta))
            {
                streamWriter.Write(contenido);
            }
        }
    }
}
