using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteDAO
{
   public class Articulo
    {
        public string Nombre { get; set; }
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public string Imagen { get; set; }
        public int CategoriaId  { get; set; }
        public Categoria Categoria { get; set; }
    }
}
