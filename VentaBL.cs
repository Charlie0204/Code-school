using RestauranteDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteBL
{
    public class VentaBL
    {
        public int InsertarVenta(Cuenta Ven)
        {
            var cuentas = new List<Cuenta>();
            cuentas.Add(Ven);
            return Ven.Id;
        }
        public bool Edit(Cuenta Ven)
        {
            try
            {
                var ventas = new List<Cuenta>();
                var r = ConsultarCuenta(Ven.Id, ventas);
                r.Total = Ven.Total;
                r.TipoVenta = Ven.TipoVenta;
                r.EstadoVenta = Ven.EstadoVenta;
                r.Id = Ven.Id;
                r.Mesa = Ven.Mesa;
                r.Articulos = Ven.Articulos;
                return true;
            }
            catch (Exception err)
            {
                return false;
            }
        }
        public bool EliminarCuenta(int Id)
        {
            try
            {
                var cuentas = new List<Cuenta>();
                var r = ConsultarCuenta(Id, cuentas);
                cuentas.Remove(r);
                return true;
            }
            catch (Exception err)
            {
                return false;
            }
        }
        public Cuenta ConsultarCuenta(int Id, List<Cuenta> context = null)
        {
            var cuentas = context != null ? context : new List<Cuenta>();
            var cue = new Cuenta();
            foreach (var c in cuentas)
            {
                if (c.Id == Id)
                {
                    cue = c;
                    break;
                }

            }
            return cue;
        }
        public bool InsertarProductoVenta(VentaArticulo ventaArticulo)
        {
            try
            {
                var VentasProducto = new List<VentaArticulo>();
                var ContextVenta = new List<Cuenta>();
                var venta = new Cuenta();

                foreach (var v in ContextVenta)
                {
                    if (v.Id == ventaArticulo.VentaId)
                    {
                        venta = v;
                        break;
                    }
                }
                venta.Total += (ventaArticulo.Cantidad * ventaArticulo.Precio);
                return true;
            }
            catch
            {
                return false;
            }
           
        }
        public bool EliminarArticulo(VentaArticulo ventaArticulo)
        {
            var VentasProducto = new List<VentaArticulo>();
            var contextcuenta = new List<Cuenta>();
            var venta = new Cuenta();

            VentasProducto.Remove(ventaArticulo);
            try
            {
                foreach (var v in contextcuenta)
                {
                    if (v.Id == ventaArticulo.Id)
                    {
                        venta = v;
                        break;
                    }
                }
                venta.Total -= (ventaArticulo.Cantidad * ventaArticulo.Precio);
                return true;
            }
            catch
            {
                return false;
            }
            
        }
        public bool CambiarEstadoCuenta(Cuenta ven)
        {
            try
            {
                var ventas = new List<Cuenta>();
                var r = ConsultarCuenta(ven.Id, ventas);
                r.EstadoVenta = ven.EstadoVenta;
                return true;
                
            }
            catch
            {
                return false;
            }

        }
        public bool CambiarTipodeVenta(Cuenta ven)
        {
            try
            {
                var ventas = new List<Cuenta>();
                var r = ConsultarCuenta(ven.Id, ventas);
                r.TipoVenta = ven.TipoVenta;
                return true;

            }
            catch
            {
                return false;
            }
        }
        public Cliente BuscarVentasCliente(int ventaId)
        {
            var ventas= new List<Cuenta>();
            var cliente = new Cliente();
            foreach(var v in ventas)
            {
               if(v.Id == ventaId)
               {
                    cliente = v.VentaCliente != null ? v.VentaCliente.Cliente : null;
                    break;
                        
               }
            }
            return cliente;

        }

    }
}
