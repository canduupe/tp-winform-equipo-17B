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
        public Articulo arti ;
        public AgregarArticulo()
        {
            InitializeComponent();
            arti = new Articulo();  
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
                cbMarca.DisplayMember = "Descripcion";  
                cbMarca.ValueMember = "MarcaID";        

                cbCategoria.DataSource = cat.listar();
                cbCategoria.DisplayMember = "Descripcion";
                cbCategoria.ValueMember = "IdCategoria";

                             
                    txtCodigo.Text = arti.CodArticulo;
                    txtNombre.Text = arti.NombreArticulo;
                    txtDescripcion.Text = arti.DescripcionArticulo;
                    cbMarca.SelectedValue = arti.IdMarca;
                    cbCategoria.SelectedValue = arti.IdCategoria;
                    txtPrecio.Text = arti.PrecioArticulo.ToString();
                
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
                arti.CodArticulo = txtCodigo.Text;
                arti.NombreArticulo = txtNombre.Text;
                arti.DescripcionArticulo = txtDescripcion.Text;

                
                arti.IdMarca = ((Marca)cbMarca.SelectedItem).MarcaID;
                arti.IdCategoria = ((Categoria)cbCategoria.SelectedItem).IdCategoria;

                decimal precio;
                if (decimal.TryParse(txtPrecio.Text, out precio))
                {
                    arti.PrecioArticulo = precio;
                }
                else
                {
                    MessageBox.Show("El formato del precio no es correcto. Ingrese un valor numérico.");
                    return;
                }

                negocio.agregar(arti);
                MessageBox.Show("Artículo agregado correctamente");

                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
