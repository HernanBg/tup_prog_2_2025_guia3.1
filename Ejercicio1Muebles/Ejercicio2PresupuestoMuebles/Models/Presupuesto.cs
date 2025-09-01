using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2PresupuestoMuebles.Models
{
    public class Presupuesto
    {
        private readonly List<Producto> listaProductos;
        public int CantidadProductos { get; private set; }
        public double CostoTotal { get; private set; }
        public string Cliente { get; private set; }
        public string Direccion { get; private set; }

        public Presupuesto(string cliente, string direccion)
        {
            this.Cliente = cliente;
            this.Direccion = direccion;
            this.listaProductos = new List<Producto>();
            this.CantidadProductos = 0;
            this.CostoTotal = 0;
        }

        public void AgregarProducto(Producto producto)
        {
            this.listaProductos.Add(producto);
            this.CantidadProductos++;
            this.CostoTotal += producto.calcularPrecio();
        }

        public string VerPresupuesto()
        {
            string presupuestoTexto = $"Cliente: {this.Cliente}\nDirección: {this.Direccion}\n\nItems presupuestados:\n";
            foreach (var producto in this.listaProductos)
            {
                presupuestoTexto += $"{producto.verDetalle()}";
            }
            presupuestoTexto += $"\nTotal: {this.CostoTotal:F2}\n";
            return presupuestoTexto;
        }
    }
}
