using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2PresupuestoMuebles.Models
{
    public abstract class Producto
    {
        
        protected string descripcion;
        protected double precioBase;
        protected string tipoMaterial;

        public Producto(string descripcion, double precioBase, string tipoMaterial)
        {
            this.descripcion = descripcion;
            this.precioBase = precioBase;
            this.tipoMaterial = tipoMaterial;
        }

       
        public abstract double calcularPrecio();
        public abstract string verDetalle();
    }


}
