using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_winform_equipo_17B
{
    public partial class Listar_Artículos : Form
    {
        private List<Imagen> imag;

        public Listar_Artículos()
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
            //dataGridView1.AutoGenerateColumns = true;
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
                pictureBox1.Load("https://www.bing.com/images/search?view=detailV2&ccid=R%2b2OxDXm&id=E3551B241DBEB3B8505B0B49F6FCD2C834DF3948&thid=OIP.R-2OxDXmafvmLXU57LFELQHaHa&mediaurl=https%3a%2f%2fwww.svgrepo.com%2fdownload%2f508699%2flandscape-placeholder.svg&cdnurl=https%3a%2f%2fth.bing.com%2fth%2fid%2fR.47ed8ec435e669fbe62d7539ecb1442d%3frik%3dSDnfNMjS%252fPZJCw%26pid%3dImgRaw%26r%3d0&exph=800&expw=800&q=image+placeholder&simid=608033306888901722&FORM=IRPRST&ck=23B10A508BE07E926B5AF3F90026936F&selectedIndex=9&itb=0");
              
        }
    }
    }
}