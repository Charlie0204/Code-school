using RestauranteDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteBL
{
    public class CategoriaBL
    {
        public int InsertarCategoria(Categoria cat)
        {
            var categorias = new List<Categoria>();
            categorias.Add(cat);
            //UpdateDatabase()
            return cat.Id;
        }
        public bool Edit(Categoria cat)
        {
            try
            {
                var categorias = new List<Categoria>();
                var r = ConsultarCategoria(cat.Id, categorias);
                r.Nombre = cat.Nombre;
                r.Id = cat.Id;
                r.Descripcion = cat.Descripcion;
                r.RestauranteId = cat.RestauranteId;
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
                var categorias = new List<Categoria>();
                var r = ConsultarCategoria(Id, categorias);
                categorias.Remove(r);
                return true;
            }
            catch (Exception err)
            {
                return false;
            }
        }

        public IEnumerable<Categoria> ConsultarCategorias(string nombre)
        {
            var categorias = new List<Categoria>();
            var tmpList = new List<Categoria>();
            foreach (var r in categorias)
            {
                if (r.Nombre.Contains(nombre.ToLower()))
                {
                    tmpList.Add(r);
                }
            }
            return tmpList;
        }
        public Categoria ConsultarCategoria(int id, List<Categoria> context = null)
        {                                     //if      //else
            var categorias = context != null ? context : new List<Categoria>();
            var cat = new Categoria();
            foreach (var r in categorias)
            {
                if (r.Id == id)
                {
                    cat = r;
                    break;
                }

            }
            return cat;

        }
    }
}
