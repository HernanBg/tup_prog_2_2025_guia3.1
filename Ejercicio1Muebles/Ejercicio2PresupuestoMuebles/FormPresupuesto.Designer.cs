namespace Ejercicio2PresupuestoMuebles
{
    partial class FormPresupuesto
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
            btn1 = new Button();
            lbPresupuesto = new ListBox();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(211, 366);
            btn1.Name = "btn1";
            btn1.Size = new Size(138, 32);
            btn1.TabIndex = 0;
            btn1.Text = "Cerrar";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // lbPresupuesto
            // 
            lbPresupuesto.FormattingEnabled = true;
            lbPresupuesto.ItemHeight = 15;
            lbPresupuesto.Location = new Point(56, 96);
            lbPresupuesto.Name = "lbPresupuesto";
            lbPresupuesto.Size = new Size(406, 229);
            lbPresupuesto.TabIndex = 1;
            // 
            // FormPresupuesto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbPresupuesto);
            Controls.Add(btn1);
            Name = "FormPresupuesto";
            Text = "FormPresupuesto";
            Load += FormPresupuesto_Load;
            ResumeLayout(false);
        }

        #endregion

        public Button btn1;
        private ListBox lbPresupuesto;
    }
}