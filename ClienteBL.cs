using RestauranteDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteBL
{
    public class ClienteBL
    {
        public int InsertarCliente(Cliente clr)
        {
            var clientes = new List<Cliente>();
            clientes.Add(clr);
            //UpdateDatabase()
            return clr.Id;
        }
        public bool Edit(Cliente clr)
        {
            try
            {
                var clientes = new List<Cliente>();
                var r = ConsultarCliente(clr.Id, clientes);
                r.Nombre = clr.Nombre;
                r.Id = clr.Id;
                r.Rfc = clr.Rfc;
                r.RazonSocial = clr.RazonSocial;
                r.Email = clr.Email;
                r.DireccionFiscal = clr.DireccionFiscal;
                r.Telefono = clr.Telefono;
                return true;
            }
            catch (Exception err)
            {
                return false;
            }


        }
        public bool Eliminar(int Id)
        {
            try
            {
                var clientes = new List<Cliente>();
                var r = ConsultarCliente(Id, clientes);
                clientes.Remove(r);
                return true;
            }
            catch (Exception err)
            {
                return false;
            }
        }

        public IEnumerable<Cliente> ConsultarClientes(string nombre)
        {
            var clientes = new List<Cliente>();
            var tmpList = new List<Cliente>();
            foreach (var r in clientes)
            {
                if (r.Nombre.Contains(nombre.ToLower()))
                {
                    tmpList.Add(r);
                }
            }
            return tmpList;
        }
        public Cliente ConsultarCliente(int id, List<Cliente> context = null)
        {                                     //if      //else
            var clientes = context != null ? context : new List<Cliente>();
            var clr = new Cliente();
            foreach (var r in clientes)
            {
                if (r.Id == id)
                {
                    clr = r;
                    break;
                }

            }
            return clr;

        }
    }
}
