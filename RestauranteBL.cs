using RestauranteDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteBL
{
    public class RestauranteBL
    {
        //Simulacion insertar un restaurante

        public int InsertarRestaurante(Restaurante res)
        {
            var restaurantes = new List<Restaurante>();
            restaurantes.Add(res);
            //UpdateDatabase()
            return res.Id;
        }
        public bool Edit(Restaurante res)
        {
            try
            {
                var restaurantes = new List<Restaurante>();
                var r = ConsultarRestaurante(res.Id, restaurantes);
                r.Nombre = res.Nombre;
                r.Logo = res.Logo;
                r.PaginaWeb = res.PaginaWeb;
                r.Telefono = res.Telefono;
                r.Domicilio = res.Domicilio;
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
                var restaurantes = new List<Restaurante>();
                var r = ConsultarRestaurante(Id, restaurantes);
                restaurantes.Remove(r);
                return true;
            }
            catch (Exception err)
            {
                return false;
            }
        }

        public IEnumerable<Restaurante> ConsultarRestaurantes(string nombre)
        {
            var restaurantes = new List<Restaurante>();
            var tmpList = new List<Restaurante>();
            foreach (var r in restaurantes)
            {
                if (r.Nombre.Contains(nombre.ToLower()))
                {
                    tmpList.Add(r);
                }
            }
            return tmpList;
        }
        public Restaurante ConsultarRestaurante(int id, List<Restaurante> context = null)
        {                                     //if      //else
            var restaurantes = context != null ? context : new List<Restaurante>();
            var res = new Restaurante();
            foreach (var r in restaurantes)
            {
                if (r.Id == id)
                {
                    res = r;
                    break;
                }

            }
            return res;

        }
    }
}
