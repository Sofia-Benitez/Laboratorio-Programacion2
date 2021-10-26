using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ListaSuper
{
    public partial class FrmListaSuper : Form
    {
        private static string rutaArchivo;
        private List<string> listaSupermercado;
        static FrmListaSuper()
        {
            string rutaApplicationData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            const string nombreArchivo = "listaSupermercado.xml";
            rutaArchivo = Path.Combine(rutaApplicationData, nombreArchivo);
        }
        public FrmListaSuper()
        {
            InitializeComponent();
            
        }

        private void FrmListaSuper_Load(object sender, EventArgs e)
        {
            listaSupermercado = new List<string>();
            if (File.Exists(rutaArchivo))
            {
                RecuperarDatos();
                ActualizarLista();
            }
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaModificacion frmAltaModificacion = new FrmAltaModificacion("Agregar objeto", "", "Agregar");

            frmAltaModificacion.ShowDialog();
            if(frmAltaModificacion.DialogResult==DialogResult.OK)
            {
                listaSupermercado.Add(frmAltaModificacion.Objeto);
                GuardarDatos();
                ActualizarLista();
            }

            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(lstObjetos.SelectedItem is not null)
            {
                listaSupermercado.Remove(lstObjetos.SelectedItem.ToString());
                ActualizarLista();
            }
            else
            {
                MessageBox.Show("No se seleccionó ningun item");
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lstObjetos.SelectedItem is null)
            {
                MessageBox.Show("No se seleccionó ningun item");
            }
            else
            {
                FrmAltaModificacion frmAltaModificacion = new FrmAltaModificacion("Modificar objeto", lstObjetos.SelectedItem.ToString(), "Modificar");
                frmAltaModificacion.ShowDialog();

                if(frmAltaModificacion.DialogResult == DialogResult.OK)
                {
                    string objetoAModificar = lstObjetos.SelectedItem.ToString();
                    int index = listaSupermercado.IndexOf(objetoAModificar);
                    listaSupermercado[index] = frmAltaModificacion.Objeto;
                    GuardarDatos();
                    ActualizarLista();
                }
            }


        }

        private void RecuperarDatos()
        {
            
                using (StreamReader streamReader = new StreamReader(rutaArchivo))
                {
                    try
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(listaSupermercado.GetType());
                        listaSupermercado = xmlSerializer.Deserialize(streamReader) as List<string>;
                    }
                    catch (Exception ex)
                    {
                        MostrarMensajeDeError(ex);
                    }
                }
            
        }
        private void GuardarDatos()
        {
            using (StreamWriter streamWriter = new StreamWriter(rutaArchivo))
            {
                try
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(listaSupermercado.GetType());
                    xmlSerializer.Serialize(streamWriter, listaSupermercado);
                }
                catch (Exception ex)
                {
                    MostrarMensajeDeError(ex);
                }
            }
        }

        private void MostrarMensajeDeError(Exception ex)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(ex.Message);
            stringBuilder.AppendLine();
            stringBuilder.AppendLine(ex.StackTrace);

            MessageBox.Show(stringBuilder.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ActualizarLista()
        {
            lstObjetos.DataSource = null;
            lstObjetos.DataSource = listaSupermercado;
        }
    }
}
