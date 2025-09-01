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
    public partial class FormCliente : Form
    {
        public string NombreCliente { get; private set; }
        public string DireccionCliente { get; private set; }
        public FormCliente()
        {
            InitializeComponent();
        }

        private void FormDatos_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            NombreCliente = tbNombre.Text;
            DireccionCliente = tbDireccion.Text;


            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
