using Ejercicio1Muebles.Models;

namespace Ejercicio1Muebles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPrueba_Click(object sender, EventArgs e)
        {
            
            Mesa mesaComedor = new Mesa("Comedor", 10.1, 1, TipoMaterial.Algarrobo);
            Silla sillaEscritorio = new Silla("Escritorio", 12.2, TipoMaterial.Caoba);

       
            string resultadoMesa = mesaComedor.VerDetalle();
            string resultadoSilla = sillaEscritorio.VerDetalle();

           
            textBoxResultados.Text = "Prueba de concepto\r\n";
            textBoxResultados.Text += "------------------\r\n";
            textBoxResultados.Text += resultadoMesa + "\r\n";
            textBoxResultados.Text += resultadoSilla;
        }
    }
}
