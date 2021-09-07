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
    public partial class frmMensaje : Form
    {
        public frmMensaje(string titulo, string mensaje)
        {
            InitializeComponent();
            lblTitulo.Text = titulo;
            lblMensaje.Text = mensaje;
        }
    }
}
