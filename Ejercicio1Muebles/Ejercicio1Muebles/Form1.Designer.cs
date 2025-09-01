namespace Ejercicio1Muebles
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
            buttonPrueba = new Button();
            textBoxResultados = new TextBox();
            SuspendLayout();
            // 
            // buttonPrueba
            // 
            buttonPrueba.Location = new Point(552, 109);
            buttonPrueba.Name = "buttonPrueba";
            buttonPrueba.Size = new Size(111, 75);
            buttonPrueba.TabIndex = 0;
            buttonPrueba.Text = "Prueba";
            buttonPrueba.UseVisualStyleBackColor = true;
            buttonPrueba.Click += buttonPrueba_Click;
            // 
            // textBoxResultados
            // 
            textBoxResultados.Location = new Point(29, 49);
            textBoxResultados.Multiline = true;
            textBoxResultados.Name = "textBoxResultados";
            textBoxResultados.Size = new Size(433, 353);
            textBoxResultados.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxResultados);
            Controls.Add(buttonPrueba);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public TextBox textBoxResultados;
        public Button buttonPrueba;
    }
}
