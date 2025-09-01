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
    public partial class FormDatosProducto : Form
    {
        public Producto ProductoCreado { get; private set; }
        public FormDatosProducto()
        {
            InitializeComponent();
            InitializeComponent();

            // Cargar los ComboBox
            CargarTiposDeProductos();
            CargarMateriales();

            // Asignar manejadores de eventos
           
        }
        private void CargarTiposDeProductos()
        {
            cbTipo.Items.Add("Mesa");
            cbTipo.Items.Add("Silla");
            cbTipo.SelectedIndex = 0; // Selecciona "Mesa" por defecto
        }

        private void CargarMateriales()
        {
            cbMaterial.Items.Add("Pino");
            cbMaterial.Items.Add("Caoba");
            cbMaterial.Items.Add("Algarrobo");
            cbMaterial.SelectedIndex = 0; // Selecciona "Pino" por defecto
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormDatosProducto_Load(object sender, EventArgs e)
        {

        }

        private void cbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Habilitar o deshabilitar el campo "Largo" dependiendo del tipo de producto
            if (cbTipo.SelectedItem.ToString() == "Mesa")
            {
                tbLargo.Enabled = true;
            }
            else
            {
                tbLargo.Enabled = false;
                tbLargo.Clear(); // Limpiar el campo si se cambia a "Silla"
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbDescripcion.Text) || string.IsNullOrWhiteSpace(tbPrecio.Text))
            {
                MessageBox.Show("Por favor, complete la descripción y el precio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Intentar convertir el precio a un número
            if (!double.TryParse(tbPrecio.Text, out double precioBase))
            {
                MessageBox.Show("El precio debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear el objeto Producto basado en el tipo seleccionado
            string tipo = cbTipo.SelectedItem.ToString();
            string descripcion = tbDescripcion.Text;
            string material = cbMaterial.SelectedItem.ToString();

            try
            {
                if (tipo == "Mesa")
                {
                    if (!double.TryParse(tbLargo.Text, out double largo))
                    {
                        MessageBox.Show("El largo debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    ProductoCreado = new Mesa(descripcion, precioBase, material, largo);
                }
                else if (tipo == "Silla")
                {
                    ProductoCreado = new Silla(descripcion, precioBase, material);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al crear el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
