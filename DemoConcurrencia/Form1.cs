namespace DemoConcurrencia
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource _cts;
        public Form1()
        {
            InitializeComponent();
        }
        private void from1_load(object sender, EventArgs e)
        {

        }
        private void btnIniciarSecuencial_Click(object sender, EventArgs e)
        {
            ActualizarResultado("iniciando proceso secuencial...");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(2000);
                ActualizarResultado($" actividad - paso {i + 1}");
            }

            ActualizarResultado("fin del proceso secuencial.");
        }

        private void ActualizarResultado(string mensaje)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => ActualizarResultado(mensaje)));
                return;
            }
            txtResultado.AppendText($"{DateTime.Now: HH:MM:ss.FFF}:{mensaje}{Environment.NewLine}");
        }

        private void btnIniciarHilo_Click_1(object sender, EventArgs e)
        {
            _cts = new CancellationTokenSource();
            var token = _cts.Token;

            Thread hilo1 = new Thread(() =>
            {
                try
                {
                    ActualizarResultado($"iniciar nuevo theread {Thread.CurrentThread.ManagedThreadId}...");
                    for (int i = 0; i < 5; i++)
                    {
                        token.ThrowIfCancellationRequested();

                        Thread.Sleep(2000);
                        ActualizarResultado($" actividad en hilo {Thread.CurrentThread.ManagedThreadId} - paso {i + 1}");
                    }
                    ActualizarResultado($"thread {Thread.CurrentThread.ManagedThreadId} terminado.");
                }
                catch (OperationCanceledException)
                {
                    ActualizarResultado("hilo cancelado.");
                }
            });
            hilo1.Start();
        }

        private async void btnIniciarTarea_Click(object sender, EventArgs e)
        {
            _cts = new CancellationTokenSource();
            var token = _cts.Token;

            await Task.Run(() =>
            {
                try
                {
                    ActualizarResultado($"Iniciando task {Task.CurrentId}...");
                    for (int i = 0; i < 5; i++)
                    {
                        token.ThrowIfCancellationRequested();

                        Thread.Sleep(2000);
                        ActualizarResultado($" actividad en tarea {Task.CurrentId} - paso {i + 1}");
                    }
                    ActualizarResultado($"task {Task.CurrentId}completada");
                }
                catch (OperationCanceledException)
                {

                    ActualizarResultado("Tarea cancelada" +
                        ".");
                }
           
            });

        }

        private void btnCancelarHilo_Click(object sender, EventArgs e)
        {
            _cts.Cancel();
        }
    }
}
