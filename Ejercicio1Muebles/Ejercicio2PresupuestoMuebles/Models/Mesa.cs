using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2PresupuestoMuebles.Models
{
    public class Mesa : Producto
    {
        private double largo;

        public Mesa(string descripcion, double precioBase, string tipoMaterial, double largo)
            : base(descripcion, precioBase, tipoMaterial)
        {
            this.largo = largo;
        }

        public override double calcularPrecio()
        {
            // Ejemplo de cálculo: precio base + (largo * 500)
            return this.precioBase + (this.largo * 500);
        }

        public override string verDetalle()
        {
            return $"Mesa ({this.largo}m)\t {this.precioBase:F2}\n";
        }
    }


}

