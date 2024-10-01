using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocioo;
using static System.Net.Mime.MediaTypeNames;


namespace tp_winform_equipo_17B
{
    public partial class ListarArtículos : Form
    {
        private List<Articulo> listaArticulos;
        public ListarArtículos()
        {
            InitializeComponent();
        }

        private void Listar_Artículos_Load(object sender, EventArgs e)
        {
            Negocio negocio = new Negocio();

            listaArticulos = negocio.listar();
            dgNegocio.DataSource = listaArticulos;
            pictureBoxArti.Load(listaArticulos[0].Imagen.URlImagen);
            ocultarColumnas();
        }

        private void dgNegocio_SelectionChanged(object sender, EventArgs e)
        {
            if (dgNegocio.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgNegocio.CurrentRow.DataBoundItem;

             
                if (seleccionado.Imagenes != null && seleccionado.Imagenes.Count > 0)
                {
                    imagenes = seleccionado.Imagenes; 
                    imagenActual = 0; 
                    CargarImagen(imagenes[imagenActual].URlImagen); 
                }
                else
                {
                 
                    pictureBoxArti.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
                }
            }
        }

        private List<Imagen> imagenes; 
       private int imagenActual = 0; 

        private void CargarImagen(string imagen)
        {
            try
            {
                pictureBoxArti.Load(imagen);
            }
            catch (Exception ex)
            {
                pictureBoxArti.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }
        private void ocultarColumnas()
        {
            dgNegocio.Columns["IdMarca"].Visible = false;
            dgNegocio.Columns["IdCategoria"].Visible = false;
            dgNegocio.Columns["Imagen"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Articulo articuloSeleccionado;
            articuloSeleccionado = (Articulo)dgNegocio.CurrentRow.DataBoundItem;

            AgregarArticulo ventanaModificar = new AgregarArticulo (articuloSeleccionado);
            ventanaModificar.ShowDialog();
            cargar();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            Negocio negocio = new Negocio();
            Articulo seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("ESTAS SEGURO DE ELIMINAR ESTE ARTICULO", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgNegocio.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

     
       

        private void txtFiltrar2_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltroMarca;
            string filtroMarca = txtFiltrar2.Text;

            if (filtroMarca.Length >=3)
            {
                listaFiltroMarca = listaArticulos.FindAll(y => y.Marca.Descripcion.ToLower().Contains(filtroMarca.ToLower()));

            }
            else
            {
                listaFiltroMarca = listaArticulos;
            }

            dgNegocio.DataSource = null;
            dgNegocio.DataSource = listaFiltroMarca;
            ocultarColumnas();

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltro.Text;

            if (filtro.Length >=3)
            {
                listaFiltrada = listaArticulos.FindAll(x => x.NombreArticulo.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }

            dgNegocio.DataSource = null;
            dgNegocio.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void txtFiltrarCate_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltroCate;
            string filtroCate = txtFiltrarCate.Text;

            if (filtroCate.Length >= 3)
            {

                listaFiltroCate = listaArticulos.FindAll(z => z.Categoria.Descripcion.ToLower().Contains(filtroCate.ToLower()));
            }
            else
            {
                listaFiltroCate = listaArticulos;
            }

            dgNegocio.DataSource = null;
            dgNegocio.DataSource= listaFiltroCate;
            ocultarColumnas();

        }

        private void btnModifi_Click(object sender, EventArgs e)
        {
            Articulo artiSeleccionado;
            artiSeleccionado = (Articulo)dgNegocio.CurrentRow.DataBoundItem;
            
            AgregarArticulo modificarArti = new AgregarArticulo(artiSeleccionado);
            modificarArti.ShowDialog();
            cargar();
        }

        private void cargar()
        {
            Negocio negocio = new Negocio();
            try
            {
            listaArticulos = negocio.listar();
            dgNegocio.DataSource = listaArticulos;
            pictureBoxArti.Load(listaArticulos[0].Imagen.URlImagen);
            ocultarColumnas();

            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.ToString());
            }

        }
        //botones para CARROUSEL
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (imagenes != null && imagenes.Count > 0)
            {
                imagenActual = (imagenActual + 1) % imagenes.Count; 
                CargarImagen(imagenes[imagenActual].URlImagen);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (imagenes != null && imagenes.Count > 0)
            {
                imagenActual = (imagenActual - 1 + imagenes.Count) % imagenes.Count; 
                CargarImagen(imagenes[imagenActual].URlImagen); 
            }
        }
    }
   
}