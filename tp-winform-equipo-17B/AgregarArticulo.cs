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
        public AgregarArticulo()
        {
            InitializeComponent();
        }

        private void AgregarArticulo_Load(object sender, EventArgs e)
        {

            try
            {
                List<Marca> marcas = DataHelper.ObtenerMarcas();
                List<Categoria> categorias = DataHelper.ObtenerCategorias();

                cbMarca.DataSource = marcas;
                cbMarca.DisplayMember = "Descripcion";
                cbMarca.ValueMember = "MarcaID";
                cbCategoria.DataSource = categorias;
                cbCategoria.DisplayMember = "Descripcion";
                cbCategoria.ValueMember = "IdCategoria";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }
        
        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Articulo art = new Articulo();
            Negocio negocio = new Negocio();
            try
            {
                art.CodArticulo = txtCodigo.Text;
                art.NombreArticulo = txtNombre.Text;
                art.DescripcionArticulo = txtDescripcion.Text;
                art.PrecioArticulo = Convert.ToDecimal(txtPrecio.Text);

                art.IdMarca = (int)cbMarca.SelectedValue;
                art.IdCategoria = (int)cbCategoria.SelectedValue;

                
                negocio.agregar(art);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        
    }
}
