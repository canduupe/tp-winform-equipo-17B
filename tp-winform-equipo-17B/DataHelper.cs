using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace tp_winform_equipo_17B
{
    public class DataHelper
    {
        public static List<Marca> ObtenerMarcas()
        {
            List<Marca> marcas = new List<Marca>();

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS01; database=CATALOGO_P3_DB; integrated security=true;";
                conexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Id, Descripcion FROM MARCAS";
                comando.Connection = conexion;
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    marcas.Add(new Marca
                    {
                        MarcaID = lector.GetInt32(0),
                        Descripcion = lector.GetString(1)
                    });
                }

                lector.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("marca no encontrada", ex);
            }
            finally
            {
                conexion.Close();
            }

            return marcas;
        }

        public static List<Categoria> ObtenerCategorias()
        {
            List<Categoria> categorias = new List<Categoria>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true;";
                conexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Id, Descripcion FROM CATEGORIAS";
                comando.Connection = conexion;
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    categorias.Add(new Categoria
                    {
                        IdCategoria = lector.GetInt32(0),
                        Descripcion = lector.GetString(1)
                    });
                }

                lector.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener categorías", ex);
            }
            finally
            {
                conexion.Close();
            }

            return categorias;
        }
    }
}
