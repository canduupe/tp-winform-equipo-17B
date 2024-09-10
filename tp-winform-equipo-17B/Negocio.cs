using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace tp_winform_equipo_17B
{
    class Negocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {

                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true;";


                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Codigo, Nombre, Precio FROM ARTICULOS";
                comando.Connection = conexion;


                conexion.Open();


                lector = comando.ExecuteReader();


                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.CodArticulo = (string)lector["Codigo"];
                    aux.NombreArticulo = (string)lector["Nombre"];
                    // aux.PrecioArticulo = (float)lector["Precio"]; 

                    lista.Add(aux);
                }


                conexion.Close();

                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al listar los artículos: " + ex.Message);
            }

        }
    }
}

