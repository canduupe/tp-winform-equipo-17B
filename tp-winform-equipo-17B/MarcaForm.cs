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
using Dominio;

namespace tp_winform_equipo_17B
{
    public partial class MarcaForm : Form
    {

        public MarcaForm()
        {
            InitializeComponent();
        }

        private void btnAgregarMa_Click(object sender, EventArgs e)
        {
            MarcaNegocio datos = new MarcaNegocio();
            Marca marca = new Marca();

            try
            {
                marca.Descripcion = txtMarcaADd.Text;
                datos.Agregar(marca);
                MessageBox.Show("Agregado Exitosamente");
                Close();    
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }



        }

        private void MarcaForm_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            try
            {
                cboMarcass.DataSource = marcaNegocio.listar();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }


        }

        private void btnEliminarMa_Click(object sender, EventArgs e)
        {
            MarcaNegocio Marneg = new MarcaNegocio();
            
            if(cboMarcass.SelectedItem != null)
            {
                string Marcaa = cboMarcass.SelectedItem.ToString();

                Marneg.Eliminar(Marcaa);

                MessageBox.Show("La MARCA ha sido eliminada.", "Categoria eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Por favor, selecciona una MARCA para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void btnCancearMa_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
