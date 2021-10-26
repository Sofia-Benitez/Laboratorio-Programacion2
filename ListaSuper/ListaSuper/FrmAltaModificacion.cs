using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaSuper
{
    public partial class FrmAltaModificacion : Form
    {
        
        
        public FrmAltaModificacion(string titulo, string textoObjeto, string txtConfirmar)
        {
            InitializeComponent();
            Text = titulo;
            txtObjeto.Text = textoObjeto;
            btnConfirmar.Text = txtConfirmar;
            
        }

        public string Objeto
        {
            get
            {
                return txtObjeto.Text;
            }
        }

        private void FrmAltaModificacion_Load(object sender, EventArgs e)
        {
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            Confirmar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        

        private void Confirmar()
        {
            if (string.IsNullOrWhiteSpace(this.Objeto))
            {
                MessageBox.Show("Error. El campo esta vacío");
            }
            else
            {

                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void Cancelar()
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtObjeto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Confirmar();
            }
            else if (e.KeyChar == (char)27)
            {
                Cancelar();
            }
        }
    }
}
