namespace DemoConcurrencia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            btnIniciarTarea = new Button();
            btnIniciarHilo = new Button();
            btnIniciarSecuencial = new Button();
            txtResultado = new TextBox();
            btnCancelarHilo = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnCancelarHilo);
            splitContainer1.Panel1.Controls.Add(btnIniciarTarea);
            splitContainer1.Panel1.Controls.Add(btnIniciarHilo);
            splitContainer1.Panel1.Controls.Add(btnIniciarSecuencial);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtResultado);
            splitContainer1.Size = new Size(795, 442);
            splitContainer1.SplitterDistance = 265;
            splitContainer1.TabIndex = 0;
            // 
            // btnIniciarTarea
            // 
            btnIniciarTarea.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnIniciarTarea.Location = new Point(12, 172);
            btnIniciarTarea.Name = "btnIniciarTarea";
            btnIniciarTarea.Size = new Size(235, 50);
            btnIniciarTarea.TabIndex = 2;
            btnIniciarTarea.Text = "Iniciar Tarea";
            btnIniciarTarea.UseVisualStyleBackColor = true;
            btnIniciarTarea.Click += btnIniciarTarea_Click;
            // 
            // btnIniciarHilo
            // 
            btnIniciarHilo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnIniciarHilo.Location = new Point(12, 99);
            btnIniciarHilo.Name = "btnIniciarHilo";
            btnIniciarHilo.Size = new Size(235, 52);
            btnIniciarHilo.TabIndex = 1;
            btnIniciarHilo.Text = "Iniciar Hilo";
            btnIniciarHilo.UseVisualStyleBackColor = true;
            btnIniciarHilo.Click += btnIniciarHilo_Click_1;
            // 
            // btnIniciarSecuencial
            // 
            btnIniciarSecuencial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnIniciarSecuencial.Location = new Point(12, 24);
            btnIniciarSecuencial.Name = "btnIniciarSecuencial";
            btnIniciarSecuencial.Size = new Size(235, 51);
            btnIniciarSecuencial.TabIndex = 0;
            btnIniciarSecuencial.Text = "Iniciar Secuencial";
            btnIniciarSecuencial.UseVisualStyleBackColor = true;
            btnIniciarSecuencial.Click += btnIniciarSecuencial_Click;
            // 
            // txtResultado
            // 
            txtResultado.Dock = DockStyle.Fill;
            txtResultado.Location = new Point(0, 0);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(526, 442);
            txtResultado.TabIndex = 0;
            // 
            // btnCancelarHilo
            // 
            btnCancelarHilo.Location = new Point(12, 246);
            btnCancelarHilo.Name = "btnCancelarHilo";
            btnCancelarHilo.Size = new Size(235, 35);
            btnCancelarHilo.TabIndex = 3;
            btnCancelarHilo.Text = "Cancelar Hilo";
            btnCancelarHilo.UseVisualStyleBackColor = true;
            btnCancelarHilo.Click += btnCancelarHilo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 442);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnIniciarTarea;
        private Button btnIniciarHilo;
        private Button btnIniciarSecuencial;
        private TextBox txtResultado;
        private Button btnCancelarHilo;
    }
}
