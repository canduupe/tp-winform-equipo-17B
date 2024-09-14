using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tp_winform_equipo_17B
{
    class ImagenBussines
    {

        public List<Imagen> listar()
        {

        List<Imagen> lista = new List<Imagen>();
        SqlConnection conexion = new SqlConnection();
        SqlCommand comando = new SqlCommand();
        SqlDataReader lector;

            try
            {

                conexion.ConnectionString = "server=.\\SQLEXPRESS01; database=CATALOGO_P3_DB; integrated security=true;";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Id, IdArticulo, ImagenUrl FROM IMAGENES";
                comando.Connection = conexion;


                conexion.Open();


                lector = comando.ExecuteReader();


                while (lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.IdImagen = (int) lector["Id"];
                    aux.UrlImagenes = (string) lector["ImagenUrl"];
                    aux.IdArti = (int)lector["IdArticulo"];
                    

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
