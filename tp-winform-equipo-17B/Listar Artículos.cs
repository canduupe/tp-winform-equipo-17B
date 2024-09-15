﻿using System;
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
            Articulo seleccionado = (Articulo)dgNegocio.CurrentRow.DataBoundItem;
            CargarImagen(seleccionado.Imagen.URlImagen);
        }

        private void CargarImagen (string imagen)
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
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltro.Text;

            if(filtro != "")
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
    }
}