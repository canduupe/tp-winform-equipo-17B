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

            try
            {
                List<Marca> marcas = DataHelper.ObtenerMarcas();
                List<Categoria> categorias = DataHelper.ObtenerCategorias();

                cbMarca.DataSource = marcas;
                cbMarca.ValueMember = "MarcaID";//esto es como un alias que le doy
                cbMarca.DisplayMember = "Descripcion";
                cbCategoria.DataSource = categorias;
                cbCategoria.ValueMember = "IdCategoria";
                cbCategoria.DisplayMember = "Descripcion";

                if (arti != null)
                {
                    txtCodigo.Text = arti.CodArticulo;
                    txtNombre.Text = arti.NombreArticulo;
                    txtDescripcion.Text = arti.DescripcionArticulo;
                    txtPrecio.Text = arti.PrecioArticulo.ToString();
                    cbMarca.SelectedValue = arti.Marca.MarcaID;//aca uso el alias 
                    cbCategoria.SelectedValue = arti.Categoria.IdCategoria;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }
        
        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Articulo art = new Articulo();
            Negocio negocio = new Negocio();
            try
            {
                if(arti == null)
                arti = new Articulo();

                arti.CodArticulo = txtCodigo.Text;
                arti.NombreArticulo = txtNombre.Text;
                arti.DescripcionArticulo = txtDescripcion.Text;
                arti.PrecioArticulo = Convert.ToDecimal(txtPrecio.Text);

                arti.IdMarca = (int)cbMarca.SelectedValue;
                arti.IdCategoria = (int)cbCategoria.SelectedValue;

                
                if(arti.Id != 0)//Si hay un ID significa que lo quiero modificar, si no, estoy modificando(esto lo hago porque estoy reutilizando la form de AGREGAR ARTICULO
                {
                    negocio.Modificar(arti);
                    MessageBox.Show("Se modificó correctamente");
                }
                else
                {

                negocio.agregar(arti);// SI NO TIENE ID SIGNIFICA QUE ESTOY AGREGANDO/DANDO DE ALTA 
                    MessageBox.Show("Se agregó correctamente");
                }

                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
