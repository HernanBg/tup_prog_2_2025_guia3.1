namespace Ejercicio2PresupuestoMuebles
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
            btnIniciar = new Button();
            btnAgregarProducto = new Button();
            btnVerPresupuesto = new Button();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(123, 65);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(185, 45);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar Presupuesto";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(123, 140);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(185, 43);
            btnAgregarProducto.TabIndex = 1;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregar_Click;
            // 
            // btnVerPresupuesto
            // 
            btnVerPresupuesto.Location = new Point(123, 208);
            btnVerPresupuesto.Name = "btnVerPresupuesto";
            btnVerPresupuesto.Size = new Size(185, 45);
            btnVerPresupuesto.TabIndex = 2;
            btnVerPresupuesto.Text = "Ver Presupuesto";
            btnVerPresupuesto.UseVisualStyleBackColor = true;
            btnVerPresupuesto.Click += btnPresupuesto_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(123, 270);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(185, 46);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 396);
            Controls.Add(btnCerrar);
            Controls.Add(btnVerPresupuesto);
            Controls.Add(btnAgregarProducto);
            Controls.Add(btnIniciar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        public Button btnIniciar;
        private Button button3;
        public Button btnAgregarProducto;
        public Button btnVerPresupuesto;
        public Button btnCerrar;
    }
}
