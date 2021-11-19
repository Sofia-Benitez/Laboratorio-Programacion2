using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Formulario
{
    public partial class Cuartel : Form
    {
        private List<Bombero> bomberos;
        private List<PictureBox> fuegos;
        private CancellationTokenSource cancellationTokenSource; 
        public Cuartel()
        {
            InitializeComponent();
            cancellationTokenSource = new CancellationTokenSource();

            fuegos = new List<PictureBox>();
            fuegos.Add(fuego1);
            fuegos.Add(fuego2);
            fuegos.Add(fuego3);
            fuegos.Add(fuego4);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            bomberos = new List<Bombero>();
            Bombero b1 = new Bombero("M. Palermo");
            b1.MarcarFin += OcultarBombero;
            bomberos.Add(b1);
            Bombero b2 = new Bombero("G. Schelotto");
            b2.MarcarFin += OcultarBombero;
            bomberos.Add(b2);
            Bombero b3 = new Bombero("C. Tevez");
            b3.MarcarFin += OcultarBombero;
            bomberos.Add(b3);
            Bombero b4 = new Bombero("F. Gago");
            b4.MarcarFin += OcultarBombero;
            bomberos.Add(b4);
        }

        private void btnEnviar1_Click(object sender, EventArgs e)
        {
            try
            {
                DespacharServicio(0);
            }
            catch(BomberoOcupadoException)
            {
                MostrarMensaje(0);
            }
            
        }

        private void btnEnviar2_Click(object sender, EventArgs e)
        {
            try
            {
                DespacharServicio(1);
            }
            catch (BomberoOcupadoException)
            {
                MostrarMensaje(1);
            }
           
        }

        private void btnEnviar3_Click(object sender, EventArgs e)
        {
            try
            {
                DespacharServicio(2);
            }
            catch (BomberoOcupadoException)
            {
                MostrarMensaje(2);
            }
        }

        private void btnEnviar4_Click(object sender, EventArgs e)
        {
            try
            {
                DespacharServicio(3);
            }
            catch (BomberoOcupadoException)
            {
                MostrarMensaje(3);
            }
        }

        private void MostrarMensaje(int index)
        {
            MessageBox.Show($"Salida de bombero {index} no concretada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void DespacharServicio(int index)
        {
            VerificarSiBomberoEstaEnSalida(index);
            fuegos[index].Visible = true;
            Bombero bombero = bomberos[index];
            
            Task.Run(() => bombero.AtenderSalida(index), cancellationTokenSource.Token); // con lambda le paso al task run un metodo que recibe parametros

        }

        private void VerificarSiBomberoEstaEnSalida(int index)
        {
            foreach (Salida salida in bomberos[index].Salidas)
            {
                if (salida.FechaFin == default)
                {
                    throw new BomberoOcupadoException();
                }
            }
        }

        private void OcultarBombero(int bomberoIndex)
        {
            if(this.InvokeRequired)
            {
                Action<int> delegadoOcultarBombero = OcultarBombero;
                Invoke(delegadoOcultarBombero, bomberoIndex);
            }
            else
            {
                fuegos[bomberoIndex].Visible = false;
            }
           
        }

        private void Cuartel_FormClosing(object sender, FormClosingEventArgs e)
        {
            cancellationTokenSource.Cancel();
        }

        private void btnReporte1_Click(object sender, EventArgs e)
        {
            Bombero bombero = bomberos[0];
            bombero.Guardar(bombero);

        }

        private void btnReporte2_Click(object sender, EventArgs e)
        {
            Bombero bombero = bomberos[1];
            bombero.Guardar(bombero);
        }

        private void btnReporte3_Click(object sender, EventArgs e)
        {
            Bombero bombero = bomberos[2];
            bombero.Guardar(bombero);
        }

        private void btnReporte4_Click(object sender, EventArgs e)
        {
            Bombero bombero = bomberos[3];
            bombero.Guardar(bombero);
        }
    }
}
