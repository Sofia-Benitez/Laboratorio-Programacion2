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
            Dictionary<string, int> diccionarioPalabras = new Dictionary<string, int>();

            string texto = richTextBox1.Text;
            string[] palabras = texto.Split(' ');
            StringBuilder sb = new StringBuilder();
            
            
            foreach(string palabra in palabras)
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

            //hago una lista con el diccionario
            List<KeyValuePair<string, int>> podio = diccionarioPalabras.ToList();

            MessageBox.Show( sb.ToString());
        }
    }
}
