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
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string titulo = "Hola Windows Form!";
            string mensaje = $"Soy {nombre} {apellido}";
            frmMensaje frmMensaje = new frmMensaje(titulo, mensaje);
            frmMensaje.ShowDialog();
        }
    }
}
