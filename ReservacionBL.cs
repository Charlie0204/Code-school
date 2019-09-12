using RestauranteDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteBL
{
    public class ReservacionBL
    {
        public int InsertarProducto(Reservacion res)
        {
            var Reservaciones = new List<Reservacion>();
            Reservaciones.Add(res);
            //UpdateDatabase()
            return res.Id;
        }
        public bool Edit(Reservacion Reservacion)
        {
            try
            {
                var Reservaciones = new List<Reservacion>();
                var r = ConsultarReservacion(Reservacion.Id, Reservaciones);
                r.MesaId = Reservacion.MesaId;
                r.Id = Reservacion.Id;
                r.ClienteId = Reservacion.ClienteId;
                r.FechaInicio = Reservacion.FechaInicio;
                r.FechaFin = Reservacion.FechaFin;
                r.Estado = Reservacion.Estado;
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
                var Reservaciones = new List<Reservacion>();
                var r = ConsultarReservacion(Id, Reservaciones);
                Reservaciones.Remove(r);
                return true;
            }
            catch (Exception err)
            {
                return false;
            }
        }

        //public IEnumerable<Reservacion> ConsultarReservaciones(string nombre)
        //{
        //    var Reservacions = new List<Reservacion>();
        //    var tmpList = new List<Reservacion>();
        //    foreach (var r in Reservacions)
        //    {
        //        if (r.Nombre.Contains(nombre.ToLower()))
        //        {
        //            tmpList.Add(r);
        //        }
        //    }
        //    return tmpList;
        //}
        public Reservacion ConsultarReservacion(int id, List<Reservacion> context = null)
        {                                     //if      //else
            var reservaciones = context != null ? context : new List<Reservacion>();
            var reservacion = new Reservacion();
            foreach (var r in reservaciones)
            {
                if (r.Id == id)
                {
                    reservacion = r;
                    break;
                }

            }
            return reservacion;
        }
    }
}
