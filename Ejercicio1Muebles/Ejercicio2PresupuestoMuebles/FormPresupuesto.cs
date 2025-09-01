using Ejercicio2PresupuestoMuebles.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2PresupuestoMuebles
{
    public partial class FormPresupuesto : Form
    {
        private Presupuesto presupuesto;
        public FormPresupuesto()
        {
            InitializeComponent();
            this.presupuesto = presupuesto;




            MostrarPresupuesto();
        }
        private void MostrarPresupuesto()
        {
            if (presupuesto == null)
            {
                lbPresupuesto.Items.Add("No hay un presupuesto disponible.");
                return;
            }

            // Obtener la información del presupuesto formateada
            string presupuestoTexto = presupuesto.VerPresupuesto();

            // Dividir el texto por líneas y añadir cada línea al ListBox
            string[] lineas = presupuestoTexto.Split(new[] { "\n" }, StringSplitOptions.None);
            foreach (string linea in lineas)
            {
                lbPresupuesto.Items.Add(linea);
            }
        }

        private void FormPresupuesto_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }
    }
}
