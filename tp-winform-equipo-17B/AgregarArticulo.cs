using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dominio;
using Negocioo;


namespace tp_winform_equipo_17B
{
    public partial class AgregarArticulo : Form
    {
        private Articulo arti = null;
        public AgregarArticulo()
        {
            InitializeComponent();
        }
        public AgregarArticulo(Articulo articulo)
        {
            InitializeComponent();
            arti = articulo;
            Text = "Modificar Articulo";
        }


        private void AgregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio mar = new MarcaNegocio();
            CategoriaNegocio cat = new CategoriaNegocio();

            try
            {
                cbMarca.DataSource = mar.listar();
                cbCategoria.DataSource = cat.listar();
                //List<Marca> marcas = DataHelper.ObtenerMarcas();
                //List<Categoria> categorias = DataHelper.ObtenerCategorias();
                arti.CodArticulo = txtCodigo.Text;
                arti.NombreArticulo = txtNombre.Text;
                arti.DescripcionArticulo = txtDescripcion.Text;
                arti.Marca = (Marca)cbMarca.SelectedItem;
                arti.Categoria = (Categoria)cbCategoria.SelectedItem;
                arti.PrecioArticulo = decimal.Parse(txtPrecio.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }
        
        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           Negocio negocio = new Negocio();
           Articulo arti = new Articulo();

            try
            {
               if(arti == null)
                
                arti.CodArticulo = txtCodigo.Text;
                arti.NombreArticulo = txtNombre.Text;
                arti.DescripcionArticulo = txtDescripcion.Text;
                arti.Marca = (Marca)cbMarca.SelectedItem;
                arti.Categoria = (Categoria)cbCategoria.SelectedItem;
                arti.PrecioArticulo = decimal.Parse(txtPrecio.Text);

                
                if (arti.Id != 0)//Si hay un ID significa que lo quiero modificar, si no, estoy modificando(esto lo hago porque estoy reutilizando la form de AGREGAR ARTICULO
                {
                    negocio.modificar(arti);
                    MessageBox.Show("Se modifico correctamente");
                }
                else { 
                

                negocio.agregar(arti);// SI NO TIENE ID SIGNIFICA QUE ESTOY AGREGANDO/DANDO DE ALTA 
                    MessageBox.Show("Se agregó correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
