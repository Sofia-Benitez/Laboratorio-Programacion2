using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace EjercicioAvisameSiCambia
{
    public partial class FrmAvisador : Form
    {
        private Persona persona;
        public FrmAvisador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(persona is null)
            {
                persona = new Persona();
                persona.EventoString += NotificarCambio;
                button1.Text = "Actualizar";

            }

            if(txtNombre.Text != persona.Nombre)
            {
                persona.Nombre = txtNombre.Text;
            }
            if(txtApellido.Text!= persona.Apellido)
            {
                persona.Apellido = txtApellido.Text;
            }

            lblMostrar.Text = persona.Mostrar();

        }

        public void NotificarCambio(string cambio)
        {
            MessageBox.Show(cambio);
        }
    }
}
