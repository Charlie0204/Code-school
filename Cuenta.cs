using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteDAO
{
    public class Cuenta
    {
        public int Id { get; set; }
        public int RestauranteId { get; set; }
        public double Total { get; set; }
        public DateTime Fecha { get; set; }
        public int? Mesa { get; set; }
        public int EmpleadoId { get; set; }
        public TipoVenta TipoVenta { get; set; }
        public EstadoVenta EstadoVenta { get; set; }
        public Empleado Cajero { get; set; }
        public IEnumerable<Articulo> Articulos { get; set; }
        public VentaCliente VentaCliente { get; set; }
    }

        public enum TipoVenta
        {
            OnSite,
            PickAndGo,
            Delivery
        }
        public enum EstadoVenta
        {
            Abierta,
            Finalizada,
            Cancelada
        }
    
}
