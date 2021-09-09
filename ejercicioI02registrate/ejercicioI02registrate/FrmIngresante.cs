using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace ejercicioI02registrate
{
    public partial class FrmIngresante : Form
    {
        public FrmIngresante()
        {
            InitializeComponent();
            lbPais.Items.Add("Argentina");
            lbPais.Items.Add("Chile");
            lbPais.Items.Add("Uruguay");

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string mensaje;

            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            int edad = (int)numericUpDown1.Value;
            string pais = lbPais.Text;
            string[] cursos = new string[3];
            int index = 0;
            string genero;
            foreach (Control item in gbCursos.Controls)
            {
                if(item is CheckBox && ((CheckBox)item).CheckState == CheckState.Checked)
                {
                    
                    cursos[index] = item.Text;
                    index++;
                }
            }

           if(rbtnFemenino.Checked)
           {
                genero = "Femenino";
           }
           else if(rbtnMasculino.Checked)
           {
                genero = "Masculino";
           }
           else if(rbtnNoBinario.Checked)
           {
                genero = "No binario";
           }
            else
           {
                genero = "No seleccionado";
           }

            Ingresante ingresante = new Ingresante(nombre, edad, direccion, genero, pais, cursos);

            mensaje = ingresante.Mostrar();

            MessageBox.Show(mensaje);

        }
    }
}
