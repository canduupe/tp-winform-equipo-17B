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
                conexion.ConnectionString = "server=.\\SQLEXPRESS01; database=CATALOGO_P3_DB; integrated security=true;";

                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select A.Id ,Codigo, Nombre, A.Descripcion, Precio,M.Id, C.Id, M.Descripcion as Marca, C.Descripcion as Categoria from ARTICULOS A, MARCAS M, CATEGORIAS C where A.IdMarca = M.Id and A.IdCategoria = C.Id \r\n";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)lector["Id"];
                    aux.CodArticulo = (string)lector["Codigo"];
                    aux.NombreArticulo = (string)lector["Nombre"];
                    aux.DescripcionArticulo = (string)lector["Descripcion"];
                    aux.PrecioArticulo = (decimal)lector["Precio"];
                    aux.Marca = new Marca();
                    aux.Marca.MarcaID = (int)lector["Id"]; 
                    aux.Marca.Descripcion = (string)lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)lector["Categoria"];
                    aux.Categoria.IdCategoria= (int) lector["Id"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los artículos: " + ex.Message);
            }
            finally
            { 
                conexion.Close();
            }
        }


        public void agregar(Articulo art)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            
            conexion.ConnectionString = "server=.\\SQLEXPRESS01; database=CATALOGO_P3_DB; integrated security=true;";

            
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) " +
                              "VALUES ('" + art.CodArticulo + "', '" + art.NombreArticulo + "', '" + art.DescripcionArticulo + "', " +
                              art.IdMarca + ", " + art.IdCategoria + ", " + art.PrecioArticulo + ")";
            comando.Connection = conexion;

            
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();  
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            finally
            {
                
                conexion.Close();
            }
        }

        public void Modificar(Articulo articulo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();


            conexion.ConnectionString = "server=.\\SQLEXPRESS01; database=CATALOGO_P3_DB; integrated security=true;";


            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "update ARTICULOS set Codigo = @cod, Nombre = @nombre, Descripcion = @desc, IdMarca = @IdMar, IdCategoria = @Idcate, Precio = @Prec where Id = @ID";
            comando.Connection = conexion;


            try
            {
                comando.Parameters.AddWithValue("@cod",articulo.CodArticulo);
                comando.Parameters.AddWithValue("@nombre",articulo.NombreArticulo);
                comando.Parameters.AddWithValue("@desc",articulo.DescripcionArticulo);
                comando.Parameters.AddWithValue("@IdMar",articulo.Marca.MarcaID);
                comando.Parameters.AddWithValue("@Idcate",articulo.Categoria.IdCategoria);
                comando.Parameters.AddWithValue("@Prec",articulo.PrecioArticulo); 
                comando.Parameters.AddWithValue("@ID",articulo.Id);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex ;
            }
            finally
            {
                conexion.Close();
            }


        }




    }
}

