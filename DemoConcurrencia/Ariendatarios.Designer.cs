namespace DemoConcurrencia
{
    partial class Ariendatarios
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
            btnCancelado = new Button();
            btnPorCancelar = new Button();
            lblActualizar = new Label();
            splitContainer1 = new SplitContainer();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelado
            // 
            btnCancelado.Location = new Point(68, 50);
            btnCancelado.Name = "btnCancelado";
            btnCancelado.Size = new Size(75, 23);
            btnCancelado.TabIndex = 0;
            btnCancelado.Text = "Cancelado";
            btnCancelado.UseVisualStyleBackColor = true;
            // 
            // btnPorCancelar
            // 
            btnPorCancelar.Location = new Point(37, 79);
            btnPorCancelar.Name = "btnPorCancelar";
            btnPorCancelar.Size = new Size(139, 39);
            btnPorCancelar.TabIndex = 1;
            btnPorCancelar.Text = "Por Cancelar";
            btnPorCancelar.UseVisualStyleBackColor = true;
            // 
            // lblActualizar
            // 
            lblActualizar.AutoSize = true;
            lblActualizar.Location = new Point(68, 167);
            lblActualizar.Name = "lblActualizar";
            lblActualizar.Size = new Size(59, 15);
            lblActualizar.TabIndex = 2;
            lblActualizar.Text = "Actualizar";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 12);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnCancelado);
            splitContainer1.Panel1.Controls.Add(lblActualizar);
            splitContainer1.Panel1.Controls.Add(btnPorCancelar);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(textBox1);
            splitContainer1.Size = new Size(716, 412);
            splitContainer1.SplitterDistance = 238;
            splitContainer1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(474, 412);
            textBox1.TabIndex = 0;
            // 
            // Ariendatarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 436);
            Controls.Add(splitContainer1);
            Name = "Ariendatarios";
            Text = "Ariendatarios";
            Load += Ariendatarios_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnCancelado;
        private Button btnPorCancelar;
        private Label lblActualizar;
        private SplitContainer splitContainer1;
        private TextBox textBox1;
    }
}