using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocioo
{
    public class Negocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos(); 

            try
            {
                datos.setearConsulta("select A.Id ,Codigo, Nombre, A.Descripcion, Precio, M.Descripcion as Marca, C.Descripcion as Categoria, ImagenUrl from ARTICULOS A, MARCAS M, CATEGORIAS C, IMAGENES I where A.IdMarca = M.Id and A.IdCategoria = C.Id and A.Id = I.Id");
                datos.realizarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.CodArticulo = (string)datos.Lector["Codigo"];
                    aux.NombreArticulo = (string)datos.Lector["Nombre"];
                    aux.DescripcionArticulo = (string)datos.Lector["Descripcion"];
                    aux.PrecioArticulo = (decimal)datos.Lector["Precio"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Imagen = new Imagen();
                    aux.Imagen.URlImagen = (string)datos.Lector["ImagenUrl"];

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
                datos.cerrarConexion();
            }
        }


        public void agregar(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) " + "VALUES ('" + art.CodArticulo + "', '" + art.NombreArticulo + "', '" + art.DescripcionArticulo + "', " + art.IdMarca + ",  @IdCategoria  ," + art.PrecioArticulo);
                datos.setearParametro("@IdCategoria", art.IdCategoria);
                datos.realizarAccion();
           
            }
            catch (Exception ex)
            { 
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }


        public void modificar(Articulo articulo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();


            conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true;";


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

