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
    public partial class BuscarArticulo : Form
    {
        public BuscarArticulo()
        {
            InitializeComponent();
        }

        private void BuscarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio mar = new MarcaNegocio();
            CategoriaNegocio cat = new CategoriaNegocio();

            try
            {
                cmbMarcas.DataSource = mar.listar();
                cmbCategorias.DataSource = cat.listar();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
