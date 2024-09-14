using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocioo;

namespace tp_winform_equipo_17B
{
    public partial class ListarArtículos : Form
    {
        private List<Imagen> imag;

        public ListarArtículos()
        {
            InitializeComponent();
        }

        private void Listar_Artículos_Load(object sender, EventArgs e)
        {
            Negocio negocio = new Negocio();

            dgNegocio.AutoGenerateColumns = true;
            dgNegocio.DataSource = negocio.listar();

            ImagenBussines Imagn = new ImagenBussines();
            imag = Imagn.listar();
            dataGridView1.DataSource = imag;
            CargarImagen(imag[0].UrlImagenes);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Imagen imagenSeleccionada = (Imagen) dataGridView1.CurrentRow.DataBoundItem;
            CargarImagen(imagenSeleccionada.UrlImagenes);
        }
    private void CargarImagen (string imagen)
    {
        try
        {
            pictureBox1.Load(imagen);
        }
        catch (Exception ex)
        {
                pictureBox1.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
        }
    }

        private void button1_Click(object sender, EventArgs e)
        {
            Articulo articuloSeleccionado;
            articuloSeleccionado = (Articulo)dgNegocio.CurrentRow.DataBoundItem;

            AgregarArticulo ventanaModificar = new AgregarArticulo (articuloSeleccionado);
            ventanaModificar.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}