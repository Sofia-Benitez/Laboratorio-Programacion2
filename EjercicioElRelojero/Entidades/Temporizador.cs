using System;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Temporizador
    {
        public delegate void DelegadoTemporizador();
        public event DelegadoTemporizador TiempoCumplido;
        private Task hilo;
        private int intervalo;
        private CancellationTokenSource cancellationTokenSource;
        private CancellationToken cancellationToken;
        private CancellationTokenSource cancelationTokenSource;

        public Temporizador(int intervalo)
        {
            this.intervalo = intervalo;
        }

        public bool EstaActivo
        {
            get
            {
                return hilo is not null &&
                    (hilo.Status == TaskStatus.Running ||
                    hilo.Status == TaskStatus.WaitingToRun ||
                    hilo.Status == TaskStatus.WaitingForActivation);
            }
        }

        public int Intervalo
        {
            get
            {
                return intervalo;
            }
            set
            {
                intervalo = value;
            }
        }

        private void CorrerTiempo()
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                Thread.Sleep(Intervalo);
                if(TiempoCumplido is not null)
                {
                    TiempoCumplido.Invoke();
                }
                    
            }
        }

        public void IniciarTemporizador()
        {
            if (hilo is null || hilo.IsCompleted)
            {
                cancellationTokenSource = new CancellationTokenSource();
                cancellationToken = cancellationTokenSource.Token;

                hilo = new Task(CorrerTiempo, cancellationToken);
            }

            if (!EstaActivo)
            {
                hilo.Start();
            }
        }

        public void DetenerTemporizador()
        {
            if (hilo is not null && !hilo.IsCompleted)
            {
                cancellationTokenSource.Cancel();
            }
        }
    }
}
