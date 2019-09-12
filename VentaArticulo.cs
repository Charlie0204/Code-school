using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteDAO
{
    public class VentaArticulo
    {
        public int Id { get; set; }
        public int VentaId { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public int productoId { get; set; }
        public double Subtotal { get; set; }
        public Cuenta Venta { get; set; }
        public Articulo Articulo { get; set; }
    }

}
