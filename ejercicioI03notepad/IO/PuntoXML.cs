using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IO
{
    public class PuntoXML : Archivo, IArchivo<string>
    {
        protected override string Extension
        {
            get
            {
                return ".xml";
            }
        }

        public void Guardar(string ruta, string contenido)
        {
            throw new NotImplementedException();
        }

        public void GuardarComo(string ruta, string contenido)
        {
            throw new NotImplementedException();
        }

        public string Leer(string ruta)
        {
            throw new NotImplementedException();
        }

        private void Serializar(string ruta, string contenido)
        {
            using (StreamWriter streamWriter = new StreamWriter(ruta))
            {
                //XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                //xmlSerializer.Serialize(ruta, contenido);
            }
        }
    }
}
