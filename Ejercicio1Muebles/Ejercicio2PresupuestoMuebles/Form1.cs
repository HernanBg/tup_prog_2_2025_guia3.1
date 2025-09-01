using Ejercicio2PresupuestoMuebles.Models;

namespace Ejercicio2PresupuestoMuebles
{
    public partial class Form1 : Form
    {

        private Presupuesto _presupuestoActual;
        public Form1()
        {
            InitializeComponent();
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente();

           
            DialogResult resultado = formCliente.ShowDialog();

            
            if (resultado == DialogResult.OK)
            {
                
                string nombre = formCliente.NombreCliente;
                string direccion = formCliente.DireccionCliente;

           

                MessageBox.Show($"Presupuesto iniciado para: {nombre}, {direccion}");
            }
            else
            {
               
                MessageBox.Show("Iniciación de presupuesto cancelada.");
            }

         
            formCliente.Dispose();

        }
            
         
            

        private void btnPresupuesto_Click(object sender, EventArgs e)
        {
            // Asegurarse de que 'presupuestoActual' sea la instancia de la clase Presupuesto
            // que se ha estado usando para agregar productos.
            if (presupuestoActual == null)
            {
                MessageBox.Show("Primero debe iniciar un presupuesto y agregar productos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Crear una instancia del FormPresupuesto y pasar el presupuesto actual
            FormPresupuesto formPresupuesto = new FormPresupuesto(presupuestoActual);

            // Mostrar el formulario
            formPresupuesto.Show();


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormDatosProducto formProducto = new FormDatosProducto();

            if (formProducto.ShowDialog() == DialogResult.OK)
            {
                // Si el usuario acepta, el producto se ha creado en el formulario modal
                Producto nuevoProducto = formProducto.ProductoCreado;

                // Aquí se llama al método para agregar el producto al presupuesto actual
                // presupuestoActual.AgregarProducto(nuevoProducto);
                MessageBox.Show("Producto agregado con éxito al presupuesto.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            formProducto.Dispose();
        }
    }
}
