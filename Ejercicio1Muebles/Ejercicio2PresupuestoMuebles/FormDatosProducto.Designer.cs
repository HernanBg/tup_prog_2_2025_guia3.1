namespace Ejercicio2PresupuestoMuebles
{
    partial class FormDatosProducto
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
            btnAceptar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbTipo = new ComboBox();
            cbMaterial = new ComboBox();
            tbLargo = new TextBox();
            tbDescripcion = new TextBox();
            tbPrecio = new TextBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(60, 322);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += button1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(271, 322);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 45);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 2;
            label1.Text = "Tipo de Producto";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 93);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 3;
            label2.Text = "Largo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 139);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 4;
            label3.Text = "Descripción";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 186);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 5;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 231);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 6;
            label5.Text = "Material";
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(150, 45);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(121, 23);
            cbTipo.TabIndex = 7;
            cbTipo.SelectedIndexChanged += cbTipo_SelectedIndexChanged;
            // 
            // cbMaterial
            // 
            cbMaterial.FormattingEnabled = true;
            cbMaterial.Location = new Point(150, 231);
            cbMaterial.Name = "cbMaterial";
            cbMaterial.Size = new Size(121, 23);
            cbMaterial.TabIndex = 8;
            cbMaterial.SelectedIndexChanged += cbMaterial_SelectedIndexChanged;
            // 
            // tbLargo
            // 
            tbLargo.Location = new Point(150, 90);
            tbLargo.Name = "tbLargo";
            tbLargo.Size = new Size(121, 23);
            tbLargo.TabIndex = 9;
            // 
            // tbDescripcion
            // 
            tbDescripcion.Location = new Point(150, 131);
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.Size = new Size(121, 23);
            tbDescripcion.TabIndex = 10;
            // 
            // tbPrecio
            // 
            tbPrecio.Location = new Point(150, 186);
            tbPrecio.Name = "tbPrecio";
            tbPrecio.Size = new Size(121, 23);
            tbPrecio.TabIndex = 11;
            // 
            // FormDatosProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbPrecio);
            Controls.Add(tbDescripcion);
            Controls.Add(tbLargo);
            Controls.Add(cbMaterial);
            Controls.Add(cbTipo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "FormDatosProducto";
            Text = "FormDatosProducto";
            Load += FormDatosProducto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbTipo;
        private ComboBox cbMaterial;
        private TextBox tbLargo;
        private TextBox tbDescripcion;
        private TextBox tbPrecio;
        public Button btnCancelar;
        public Button btnAceptar;
    }
}