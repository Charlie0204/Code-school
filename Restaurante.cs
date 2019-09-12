using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteDAO
{
    public class Restaurante
    {
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public int Id { get; set; }
        public string Logo { get; set; }
        public string PaginaWeb { get; set; }
        public IEnumerable<Categoria> Categorias { get; set; }
        
    }
}
