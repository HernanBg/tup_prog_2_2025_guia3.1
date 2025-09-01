using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Muebles.Models
{
    public class Silla : Producto
    {
        public Silla(string descripcion, double precioBase, TipoMaterial material)
            : base(descripcion, precioBase, material) { }

        public override double CalcularPrecio()
        {
            return PrecioBase * (1 + (int)Material * 0.25);
        }

        public override string VerDetalle()
        {
            return $"Silla {Descripcion} {Material}  {PrecioBase:F2}   Silla({(int)Material})  {CalcularPrecio():F2}";
        }
    }
}
