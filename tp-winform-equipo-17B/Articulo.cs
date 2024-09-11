using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace tp_winform_equipo_17B
{
    public class Articulo
    {
        public string CodArticulo { get; set; }
        public string   NombreArticulo { get; set; }
        public string   DescripcionArticulo { get; set; }
        public decimal  PrecioArticulo { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
    }
}
