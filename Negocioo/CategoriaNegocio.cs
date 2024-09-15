using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocioo
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT id, Descripcion FROM CATEGORIAS");
                datos.realizarLectura();

                while (datos.Lector.Read())
                {
                    Categoria categoria = new Categoria
                    {
                        IdCategoria = (int)datos.Lector["id"],
                        Descripcion = (string)datos.Lector["Descripcion"]
                    };

                    lista.Add(categoria);
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
    }
}