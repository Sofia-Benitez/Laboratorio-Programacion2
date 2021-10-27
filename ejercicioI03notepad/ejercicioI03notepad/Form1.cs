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
using IO;

namespace ejercicioI03notepad
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private string ultimoArchivo;
        private PuntoJson<string> puntoJson;
        private PuntoTxt puntoTxt;
        private PuntoXML<string> puntoXml;

        private string UltimoArchivo
        {
            get
            {
                return ultimoArchivo;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    ultimoArchivo = value;
                }
            }
        }
        public Form1()
        {
            InitializeComponent();

            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            puntoJson = new PuntoJson<string>();
            puntoXml = new PuntoXML<string>();
            puntoTxt = new PuntoTxt();
            saveFileDialog.Filter = "Archivo de texto|*.txt| Archivo JSON|*.json| Archivo XML|*.xml";
            openFileDialog.Filter = "Archivo de texto|*.txt| Archivo JSON|*.json| Archivo XML|*.xml";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "0 caracteres";
        }

        private void rtxbNotepad_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"{rtxbNotepad.Text.Length} caracteres";
        }


        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ultimoArchivo = openFileDialog.FileName;

                try
                {
                    switch (Path.GetExtension(UltimoArchivo))
                    {
                        case ".json":
                            rtxbNotepad.Text = puntoJson.Leer(UltimoArchivo);
                            break;
                        case ".xml":
                            rtxbNotepad.Text = puntoXml.Leer(UltimoArchivo);
                            break;
                        case ".txt":
                            rtxbNotepad.Text = puntoTxt.Leer(UltimoArchivo);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MostrarMensajeError(ex);
                }
            }
        }

        private void MostrarMensajeError(Exception exception)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{exception.Message}");
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(UltimoArchivo))
            {
                GuardarComo();
            }
            else
            {
                Guardar();
            }
        }
        private string SeleccionarUbicacionGuardado()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                return saveFileDialog.FileName;
            }

            return string.Empty;
        }

        private void Guardar()
        {
            try
            {
                switch (Path.GetExtension(UltimoArchivo))
                {
                    case ".json":
                        puntoJson.Guardar(UltimoArchivo, rtxbNotepad.Text);
                        break;
                    case ".xml":
                        puntoXml.Guardar(UltimoArchivo, rtxbNotepad.Text);
                        break;
                    case ".txt":
                        puntoTxt.Guardar(UltimoArchivo, rtxbNotepad.Text);
                        break;
                }
            }
            catch (Exception ex)
            {
                MostrarMensajeError(ex);
            }
        }

        private void GuardarComo()
        {
            UltimoArchivo = SeleccionarUbicacionGuardado();

            try
            {
                switch (Path.GetExtension(UltimoArchivo))
                {
                    case ".json":
                        puntoJson.GuardarComo(UltimoArchivo, rtxbNotepad.Text);
                        break;
                    case ".xml":
                        puntoXml.GuardarComo(UltimoArchivo, rtxbNotepad.Text);
                        break;
                    case ".txt":
                        puntoTxt.GuardarComo(UltimoArchivo, rtxbNotepad.Text);
                        break;
                }
            }
            catch (Exception ex)
            {
                MostrarMensajeError(ex);
            }
        }


        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarComo();
        }

       
    }
}
