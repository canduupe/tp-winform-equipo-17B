using Dominio;
using Negocioo;
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
    public partial class VentPrincipal : Form
    {
        public VentPrincipal()
        {
            InitializeComponent();
        }

        private void VentPrincipal_Load(object sender, EventArgs e)
        {
            lblFecha.Text = "Fecha actual:  " + DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnListarArticulos_Click(object sender, EventArgs e)
        {
            ListarArtículos ventanaListar = new ListarArtículos();
            ventanaListar.ShowDialog();

        }
    }
}
