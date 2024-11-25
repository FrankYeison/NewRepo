namespace DemoConcurrencia
{
    partial class frmDemostracionDelPatronSingleton
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
            btnAsignar = new Button();
            btnRecuperar = new Button();
            txtCadenadeConexion = new TextBox();
            label1 = new Label();
            lblCadenaConexionRecuperada = new Label();
            SuspendLayout();
            // 
            // btnAsignar
            // 
            btnAsignar.Location = new Point(27, 105);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(113, 68);
            btnAsignar.TabIndex = 0;
            btnAsignar.Text = "Asignar Cadena de Conexion";
            btnAsignar.UseVisualStyleBackColor = true;
            btnAsignar.Click += btnAsignar_Click;
            // 
            // btnRecuperar
            // 
            btnRecuperar.Location = new Point(27, 190);
            btnRecuperar.Name = "btnRecuperar";
            btnRecuperar.Size = new Size(113, 66);
            btnRecuperar.TabIndex = 1;
            btnRecuperar.Text = "Obtener Cadena de Conexion";
            btnRecuperar.UseVisualStyleBackColor = true;
            btnRecuperar.Click += button1_Click;
            // 
            // txtCadenadeConexion
            // 
            txtCadenadeConexion.Location = new Point(27, 76);
            txtCadenadeConexion.Multiline = true;
            txtCadenadeConexion.Name = "txtCadenadeConexion";
            txtCadenadeConexion.Size = new Size(204, 23);
            txtCadenadeConexion.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 41);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 3;
            label1.Text = "Cadena de Conexion";
            // 
            // lblCadenaConexionRecuperada
            // 
            lblCadenaConexionRecuperada.AutoSize = true;
            lblCadenaConexionRecuperada.Location = new Point(176, 216);
            lblCadenaConexionRecuperada.Name = "lblCadenaConexionRecuperada";
            lblCadenaConexionRecuperada.Size = new Size(19, 15);
            lblCadenaConexionRecuperada.TabIndex = 4;
            lblCadenaConexionRecuperada.Text = " ...";
            // 
            // frmDemostracionDelPatronSingleton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 282);
            Controls.Add(lblCadenaConexionRecuperada);
            Controls.Add(label1);
            Controls.Add(txtCadenadeConexion);
            Controls.Add(btnRecuperar);
            Controls.Add(btnAsignar);
            Name = "frmDemostracionDelPatronSingleton";
            Text = "Demostracion del Patron Singleton";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAsignar;
        private Button btnRecuperar;
        private TextBox txtCadenadeConexion;
        private Label label1;
        private Label lblCadenaConexionRecuperada;
    }
}