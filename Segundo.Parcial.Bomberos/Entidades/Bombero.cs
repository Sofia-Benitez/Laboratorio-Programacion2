using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Entidades
{
    public class Bombero: IArchivos<string>
    {
        private string nombre;
        private List<Salida> salidas;

        public Bombero()
        {
            salidas = new List<Salida>();
        }
        public Bombero(string nombre):this()
        {
            this.nombre = nombre;
        }

        void IArchivos<string>.Guardar(string info)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta = Path.Combine(ruta, "bomberos.xml");
            using (StreamWriter streamWriter = new StreamWriter(ruta))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(string));
                xmlSerializer.Serialize(streamWriter, info);
            }
        }

        string IArchivos<string>.Leer()
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta = Path.Combine(ruta, "bomberos.xml");
            using (StreamReader streamReader = new StreamReader(ruta))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(string));
                return xmlSerializer.Deserialize(streamReader) as string;
            }
        }

        public void Guardar(Bombero info)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta = Path.Combine(ruta, "bomberos.xml");
            using (StreamWriter streamWriter = new StreamWriter(ruta))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Bombero));
                xmlSerializer.Serialize(streamWriter, info);
            }
        }

        public Bombero Leer()
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta = Path.Combine(ruta, "bomberos.xml");
            using (StreamReader streamReader = new StreamReader(ruta))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Bombero));
                return xmlSerializer.Deserialize(streamReader) as Bombero;
            }
        }
    }
}
