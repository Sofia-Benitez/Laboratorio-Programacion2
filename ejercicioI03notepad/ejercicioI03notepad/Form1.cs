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

namespace ejercicioI03notepad
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private string ultimoArchivo;

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
            saveFileDialog.Filter = "Archivo de texto|*.txt";

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
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ultimoArchivo = openFileDialog.FileName;
                    using(StreamReader streamReader = new StreamReader(ultimoArchivo))
                    {
                        rtxbNotepad.Text = streamReader.ReadToEnd();
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
            if(!File.Exists(ultimoArchivo))
            {
                UltimoArchivo = SeleccionarUbicacionGuardado();
            }
            GuardarArchivo(UltimoArchivo);
        }
        private string SeleccionarUbicacionGuardado()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                return saveFileDialog.FileName;
            }

            return string.Empty;
        }

        private void GuardarArchivo(string ruta)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(ruta))
                {
                    using StreamWriter streamWriter = new StreamWriter(ultimoArchivo);
                    streamWriter.Write(rtxbNotepad.Text);
                }
            }
            catch (Exception ex)
            {
                MostrarMensajeError(ex);
            }
        }


        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UltimoArchivo = SeleccionarUbicacionGuardado();

            GuardarArchivo(UltimoArchivo);
        }

       
    }
}
