using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Muebles.Models
{
   
    
        public class Mesa : Producto
        {
            public double Largo { get; }

            public Mesa(string descripcion, double precioBase, double largo, TipoMaterial material)
                : base(descripcion, precioBase, material)
            {
                Largo = largo;
            }

            public override double CalcularPrecio()
            {
                return (PrecioBase * Largo) * (1 + (int)Material * 0.33);
            }

            public override string VerDetalle()
            {
                return $"Mesa {Descripcion} {Material}  {PrecioBase:F2}, {Largo:F2}  Mesa({(int)Material}, {Largo})  {CalcularPrecio():F2}";
            }
        }
    
}
