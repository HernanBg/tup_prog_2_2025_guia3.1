using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Muebles.Models
{
   
    
        public enum TipoMaterial
        {
            Algarrobo = 1,
            Caoba = 2
        }

        
        public abstract class Producto
        {
            public string Descripcion { get; }
            public double PrecioBase { get; }
            public TipoMaterial Material { get; }

            protected Producto(string descripcion, double precioBase, TipoMaterial material)
            {
                Descripcion = descripcion;
                PrecioBase = precioBase;
                Material = material;
            }

            public abstract double CalcularPrecio();
            public abstract string VerDetalle();
        }

    
}
