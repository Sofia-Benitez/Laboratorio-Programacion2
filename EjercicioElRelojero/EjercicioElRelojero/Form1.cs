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

namespace EjercicioElRelojero
{
    public partial class Form1 : Form
    {
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CancellationToken cancelationToken = cancellationTokenSource.Token;
            Task task = Task.Run(IniciarAccion, cancelationToken);
        }
      
        public void IniciarAccion()
        {
            while (!cancellationTokenSource.IsCancellationRequested)
            {
                AsignarHora();
            }
       
        }
        public void AsignarHora()
        {
            if (InvokeRequired)
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
            cancellationTokenSource.Cancel();
            MessageBox.Show("Cerrando...");  
        }

        
    }
}
