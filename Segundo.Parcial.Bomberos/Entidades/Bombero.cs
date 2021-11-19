using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Xml.Serialization;

namespace Entidades
{
    public delegate void FinDeSalida(int bomberoIndex);
    public class Bombero: IArchivos<string>, IArchivos<Bombero>
    {
        public event FinDeSalida MarcarFin;
        private string nombre;
        private List<Salida> salidas;
        private static string connectionString;
        public static Random random;


        public List<Salida> Salidas { get => salidas; set => salidas = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        
        public Bombero()
        {
            salidas = new List<Salida>();
            random = new Random();
        }
        public Bombero(string nombre):this()
        {
            this.nombre = nombre;
        }

        void IArchivos<string>.Guardar(string info)
        {
            LogDao logDao = new LogDao();
            logDao.Insertar(info);
        }

        string IArchivos<string>.Leer()
        {
            LogDao logDao = new LogDao();
            return  logDao.LeerLog();
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

        public void AtenderSalida(int bomberoIndex)
        {
            
            Salida salida = new Salida();
            salidas.Add(salida);

            Thread.Sleep(random.Next(2000, 4001));

            salida.FinalizarSalida();

            string log = $"Fecha inicio: {salida.FechaInicio:HH:mm:ss}. Fecha fin: {salida.FechaFin:HH:mm:ss}. Tiempo total:{salida.TiempoTotal}";

            IArchivos<string> archivo = this;
            archivo.Guardar(log);

            MarcarFin.Invoke(bomberoIndex);  

        }
    }
}
