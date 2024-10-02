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

    public partial class CategoriasForm : Form
    {
    private  List <Categoria> listaCategoria;
        public CategoriasForm()
        {
            InitializeComponent();
        }

        private void btnCancelarCa_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarCa_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                categoria.Descripcion = txtCatAdd.Text;
                negocio.Agregar(categoria);
                MessageBox.Show("Agrgado exitosamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void CategoriasForm_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cboCate.DataSource = categoriaNegocio.listar();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negoci = new CategoriaNegocio();

            if(cboCate.SelectedItem != null) //si hay seleccionado un item
            {
                string MarcaSelec = cboCate.SelectedItem.ToString();
                negoci.Eliminar(MarcaSelec);

                MessageBox.Show("La Categoria ha sido eliminada.", "Categoria eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Por favor, selecciona una Categoria para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnModificarMar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio catneg = new CategoriaNegocio();

            if(cboCate.SelectedItem != null)
            {
                string cateSelec = cboCate.SelectedItem.ToString();
                string cateNew = txtModCat.Text;

                catneg.Modificar(cateNew, cateSelec);

                MessageBox.Show("Modificado");
               
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una Categoria para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

       


        



    }
}
