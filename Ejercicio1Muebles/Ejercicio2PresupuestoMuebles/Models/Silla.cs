using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2PresupuestoMuebles.Models
{
    public class Silla : Producto
    {
        public Silla(string descripcion, double precioBase, string tipoMaterial)
            : base(descripcion, precioBase, tipoMaterial)
        {
        }

        public override double calcularPrecio()
        {
            // Ejemplo de cálculo: precio base con un recargo del 10%
            return this.precioBase * 1.10;
        }

        public override string verDetalle()
        {
            return $"Silla\t {this.precioBase:F2}\n";
        }
    }
}
