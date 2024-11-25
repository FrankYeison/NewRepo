namespace DemoConcurrencia
{
    partial class FrmBloqueos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIncrementar = new Button();
            lblContador = new Label();
            btnDisminuir = new Button();
            splitContainer1 = new SplitContainer();
            txtResutado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // btnIncrementar
            // 
            btnIncrementar.Location = new Point(19, 14);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(90, 31);
            btnIncrementar.TabIndex = 0;
            btnIncrementar.Text = "Incrementar";
            btnIncrementar.UseVisualStyleBackColor = true;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Location = new Point(59, 203);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(16, 15);
            lblContador.TabIndex = 1;
            lblContador.Text = "O";
            // 
            // btnDisminuir
            // 
            btnDisminuir.Location = new Point(19, 51);
            btnDisminuir.Name = "btnDisminuir";
            btnDisminuir.Size = new Size(90, 29);
            btnDisminuir.TabIndex = 2;
            btnDisminuir.Text = "Disminuir";
            btnDisminuir.UseVisualStyleBackColor = true;
            btnDisminuir.Click += btnDisminuir_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 12);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnIncrementar);
            splitContainer1.Panel1.Controls.Add(lblContador);
            splitContainer1.Panel1.Controls.Add(btnDisminuir);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtResutado);
            splitContainer1.Size = new Size(486, 247);
            splitContainer1.SplitterDistance = 162;
            splitContainer1.TabIndex = 3;
            // 
            // txtResutado
            // 
            txtResutado.Dock = DockStyle.Fill;
            txtResutado.Location = new Point(0, 0);
            txtResutado.Multiline = true;
            txtResutado.Name = "txtResutado";
            txtResutado.Size = new Size(320, 247);
            txtResutado.TabIndex = 0;
            txtResutado.TextChanged += txtResutado_TextChanged;
            // 
            // FrmBloqueos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 271);
            Controls.Add(splitContainer1);
            Name = "FrmBloqueos";
            Text = "Gestion de Bloqueos";
            Load += Form2_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnIncrementar;
        private Label lblContador;
        private Button btnDisminuir;
        private SplitContainer splitContainer1;
        private TextBox txtResutado;
    }
}