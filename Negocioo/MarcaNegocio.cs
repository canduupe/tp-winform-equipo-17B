using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocioo;


namespace Negocioo
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT id, Descripcion FROM MARCAS");
                datos.realizarLectura();

                while (datos.Lector.Read())
                {
                    Marca marca = new Marca
                    {
                        MarcaID = (int)datos.Lector["id"],
                        Descripcion = (string)datos.Lector["Descripcion"]
                    };

                    lista.Add(marca);
                }

                return lista;
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

        public void Agregar( Marca marca)
        {
            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.setearConsulta(" insert into MARCAS (Descripcion) values ('" + marca.Descripcion + "')");
                datos.realizarAccion();

            }
            catch (Exception ex)
            {
  
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public void Eliminar (string mar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from MARCAS where Descripcion = @descripcion");
                datos.setearParametro("@descripcion", mar);
                datos.realizarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            


        }




    }
}