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
using static System.Net.Mime.MediaTypeNames;


namespace tp_winform_equipo_17B
{
    public partial class AgregarArticulo : Form
    {
        public Articulo arti;

        private Articulo articulo = null;

        public AgregarArticulo()
        {
            InitializeComponent();
            Articulo arti = new Articulo();
        }
        public AgregarArticulo(Articulo articulo)
        {
            InitializeComponent();
            Text = "Modificar Articulo";
            this.articulo = articulo;
        }


        private void AgregarArticulo_Load(object sender, EventArgs e)
        {
           
            MarcaNegocio mar = new MarcaNegocio();
            CategoriaNegocio cat = new CategoriaNegocio();

            try
            {
                
               cbMarca.DataSource = mar.listar();
               cbMarca.ValueMember = "MarcaID";        
               cbMarca.DisplayMember = "Descripcion";  

               cbCategoria.DataSource = cat.listar();
               cbCategoria.ValueMember = "IdCategoria";
               cbCategoria.DisplayMember = "Descripcion";

                
                if(articulo!= null)
                {
                    txtCodigo.Text = articulo.CodArticulo;
                    txtNombre.Text = articulo.NombreArticulo;
                    txtDescripcion.Text = articulo.DescripcionArticulo;
                    cbMarca.SelectedValue = articulo.Marca.MarcaID;
                    cbCategoria.SelectedValue = articulo.Categoria.IdCategoria;
                    txtPrecio.Text = articulo.PrecioArticulo.ToString();
                    CargarImagen(articulo.Imagen.URlImagen);
                   
                }

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
                    if (precio > 0)
                    {
                        arti.PrecioArticulo = precio;
                    }
                    else
                    {
                        MessageBox.Show("El PRECIO es NEGATIVO, Porfavor cargue un precio de nuevo");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("El formato del precio no es correcto. Ingrese un valor numérico.");
                    return;
                }

             
                negocio.agregar(arti);
                MessageBox.Show("Artículo agregado correctamente");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtURLimagen_Leave(object sender, EventArgs e)
        {
            CargarImagen(txtURLimagen.Text);
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                pictureBoxAgrego.Load(imagen);
            }
            catch (Exception ex)
            {
                pictureBoxAgrego.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }

    }
}
