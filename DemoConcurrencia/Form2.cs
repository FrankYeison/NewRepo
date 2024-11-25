using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoConcurrencia
{
    public partial class FrmBloqueos : Form
    {
        private int contador = 0;
        private object bloqueo = new();
        private SemaphoreSlim semaforo = new SemaphoreSlim(2);
        public FrmBloqueos()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                semaforo.Wait();

                lock (bloqueo)
                {
                    

                        contador++;
                        Thread.Sleep(1000);

                        this.Invoke((MethodInvoker)delegate
                        {   
                         lblContador.Text = contador.ToString();
                        });

                     Monitor.Pulse(bloqueo);
                }
                semaforo.Release();
            });
        }

        private void btnDisminuir_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                lock (bloqueo)
                {
                    while (contador <= 0)
                    {
                        ActualizarResultado("Esperando...");
                        Monitor.Wait(bloqueo);
                    }
                    if (contador > 0)
                    {
                        contador--;
                        Thread.Sleep(1000);

                        this.Invoke((MethodInvoker)delegate
                        {
                            lblContador.Text = contador.ToString();
                        });
                    }
                    ActualizarResultado("Procesando...");
                }
            });
        }

        private void txtResutado_TextChanged(object sender, EventArgs e)
        {

        }
        private void ActualizarResultado(string mensaje)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => ActualizarResultado(mensaje)));
                return;
            }
            txtResutado.AppendText($"{DateTime.Now: HH:MM:ss.FFF}:{mensaje}{Environment.NewLine}");
        }
    }
}
