namespace Ejercicio2PresupuestoMuebles
{
    partial class FormCliente
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
            label1 = new Label();
            label2 = new Label();
            tbNombre = new TextBox();
            tbDireccion = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 83);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 140);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Dirección";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(184, 78);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(159, 23);
            tbNombre.TabIndex = 2;
            // 
            // tbDireccion
            // 
            tbDireccion.Location = new Point(184, 132);
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new Size(159, 23);
            tbDireccion.TabIndex = 3;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(118, 216);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 48);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(333, 216);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 48);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(tbDireccion);
            Controls.Add(tbNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCliente";
            Text = "FormCliente";
            Load += FormDatos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        public TextBox tbNombre;
        public TextBox tbDireccion;
        public Button btnAceptar;
        public Button btnCancelar;
    }
}