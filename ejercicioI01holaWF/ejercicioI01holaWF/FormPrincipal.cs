using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioI01holaWF
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            comboBoxMateria.Items.Add("Laboratorio I");
            comboBoxMateria.Items.Add("Laboratorio II");
            comboBoxMateria.Items.Add("Programacion I");
            comboBoxMateria.Items.Add("Programacion II");
            comboBoxMateria.Items.Add("Sistemas de procesamiento de datos");
            comboBoxMateria.Items.Add("Arquitectura y sistemas operativos");
            comboBoxMateria.Items.Add("Matematica");
            comboBoxMateria.Items.Add("Ingles");
            comboBoxMateria.Items.Add("Estadistica");

        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string materia = comboBoxMateria.Text;
            string titulo = "Hola Windows Form!";

            if (String.IsNullOrWhiteSpace(nombre) && String.IsNullOrWhiteSpace(apellido)) 
            {
                MessageBox.Show("Se deben completar los siguientes campos: \n Nombre \n Apellido", "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
               

                

            }
            else if(String.IsNullOrWhiteSpace(apellido))
            {
                MessageBox.Show("Se deben completar los siguientes campos:\n Apellido", "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Se deben completar los siguientes campos: \n Nombre", "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                string mensaje = $"Soy {nombre} {apellido} y mi materia preferida es {materia}";
                frmMensaje frmMensaje = new frmMensaje(titulo, mensaje);
                frmMensaje.ShowDialog();
            }
            
        }
    }
}
