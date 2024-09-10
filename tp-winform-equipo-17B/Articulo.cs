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
        private int CodigoArticulo;
        private string Nombre;
        private string Descripcion;
        private float Precio;

        public int CodArticulo { get; set; }
        public string   NombreArticulo { get; set; }
        public string   DescripcionArticulo { get; set; }
        public float   PrecioArticulo { get; set; }
    }
}
