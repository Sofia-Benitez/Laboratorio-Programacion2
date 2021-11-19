using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace EjercicioElRelojero
{
    public partial class Form1 : Form
    {
        //CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        Temporizador temporizador;

        public Form1()
        {
            InitializeComponent();
            temporizador = new Temporizador(1000);
            temporizador.TiempoCumplido += AsignarHora;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ActualizarHoraHilos();
            ActualizarHoraTemporizador();
            
        }
      
        public void IniciarAccion()
        {
            //while (!cancellationTokenSource.IsCancellationRequested)
            //{
            //    AsignarHora();
            //}

        }
        public void AsignarHora()
        {
            if (this.InvokeRequired)
            {
                Action delegado = AsignarHora;
                this.Invoke(delegado);
            }
            else
            {
                label1.Text = $" {DateTime.Now:HH:mm:ss} ";
            }
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //cancellationTokenSource.Cancel();
            MessageBox.Show("Cerrando...");  
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            temporizador.IniciarTemporizador();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            temporizador.DetenerTemporizador();
        }

        public void ActualizarHoraTemporizador()
        {
            temporizador.IniciarTemporizador();
        }

        public void ActualizarHoraHilos()
        {
            //CancellationToken cancelationToken = cancellationTokenSource.Token;
            //Task task = Task.Run(IniciarAccion, cancelationToken);
        }
    }
}
