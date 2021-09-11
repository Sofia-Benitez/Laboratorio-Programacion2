using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioI03contarPalabras
{
    public partial class FrmContadorPalabras : Form
    {
        public FrmContadorPalabras()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            Dictionary<string, int> diccionarioPalabras = ObtenerContadorPalabras();

           List<KeyValuePair<string,int>> podio = ObtenerPodio(diccionarioPalabras);
            MostrarPodio(podio);

        }

        //criterio de ordenamiento para ordenar el podio en ObtenerPodio()
        private int CompararRepeticiones(KeyValuePair<string, int> primerElemento, KeyValuePair<string,int> segundoElemento)
        {
            return segundoElemento.Value - primerElemento.Value;
        }
        
        private List<KeyValuePair<string, int>> ObtenerPodio(Dictionary<string, int> diccionarioPalabras)
        {
            //hago una lista con el diccionario
            List<KeyValuePair<string, int>> podio = diccionarioPalabras.ToList();
            //ordena con el metodo sort (usa un criterio por defecto o uno que le pasemos como referencia)
            podio.Sort(CompararRepeticiones);

            return podio;
            
        }
        private void MostrarPodio(List<KeyValuePair<string, int>> podio)
        {
            StringBuilder sb = new StringBuilder();

            if(podio.Count == 0)
            {
                sb.AppendLine("No se ingresaron palabras.");
            }
            else
            {
                for (int i = 0; i < podio.Count && i<3; i++)
                {
                    KeyValuePair<string, int> par = podio[i];
                    sb.AppendLine($"Palabra: {par.Key} Cantidad: {par.Value}");
                }
                //foreach (KeyValuePair<string, int> par in podio)
                //{
                //    sb.AppendLine($"Palabra: {par.Key}. Cantidad: {par.Value}");
                //}
            }

            

            MessageBox.Show(sb.ToString(), "Podio");
        }
        private Dictionary<string, int> ObtenerContadorPalabras()
        {
            Dictionary<string, int> diccionarioPalabras = new Dictionary<string, int>();

            string texto = richTextBox1.Text;
            string[] palabras = texto.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder();


            foreach (string palabra in palabras)
            {
                //si la palabra ya esta solo incremento el valor
                if (diccionarioPalabras.ContainsKey(palabra))
                {
                    diccionarioPalabras[palabra]++;
                }
                else
                {
                    //si no esta la agrego al diccionario
                    diccionarioPalabras.Add(palabra, 1);
                }
            }

            return diccionarioPalabras;
        }
    }
}
