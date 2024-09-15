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
                //NO TOQUEN LA CONSULTA
                datos.setearConsulta(@"
            SELECT A.Id, Codigo, Nombre, A.Descripcion, Precio, 
                   M.Descripcion AS Marca, C.Descripcion AS Categoria, 
                   I.ImagenUrl
            FROM ARTICULOS A
            INNER JOIN MARCAS M ON A.IdMarca = M.Id
            INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id
            LEFT JOIN IMAGENES I ON A.Id = I.IdArticulo
        ");
                datos.realizarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo
                    {
                        Id = (int)datos.Lector["Id"],
                        CodArticulo = (string)datos.Lector["Codigo"],
                        NombreArticulo = (string)datos.Lector["Nombre"],
                        DescripcionArticulo = (string)datos.Lector["Descripcion"],
                        PrecioArticulo = (decimal)datos.Lector["Precio"],
                        Marca = new Marca
                        {
                            Descripcion = (string)datos.Lector["Marca"]
                        },
                        Categoria = new Categoria
                        {
                            Descripcion = (string)datos.Lector["Categoria"]
                        },
                        Imagen = new Imagen
                        {
                            URlImagen = datos.Lector["ImagenUrl"] as string
                        }
                    };

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
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) " +
                                     "VALUES (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio)");

                datos.setearParametro("@Codigo", art.CodArticulo);
                datos.setearParametro("@Nombre", art.NombreArticulo);
                datos.setearParametro("@Descripcion", art.DescripcionArticulo);
                datos.setearParametro("@IdMarca", art.IdMarca); 
                datos.setearParametro("@IdCategoria", art.IdCategoria); 
                datos.setearParametro("@Precio", art.PrecioArticulo);

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


        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from ARTICULOS where id = @Id");
                datos.setearParametro("@Id", id);
                datos.realizarAccion();
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

    }
    

}

