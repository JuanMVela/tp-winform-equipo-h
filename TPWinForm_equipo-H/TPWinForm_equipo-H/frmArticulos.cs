using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TPWinForm_equipo_H
{
    public partial class frmArticulos : Form
    {
        private List<Articulo> listaArticulos;
        public frmArticulos()
        {
            InitializeComponent();
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                listaArticulos = negocio.listar();
                dgvArticulos.DataSource = listaArticulos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //Se creo por error el FILL-----------------------------
        private void fill(object sender, DataGridViewAutoSizeColumnsModeEventArgs e)
        {

        }
        //Se creo por error el FILL-----------------------------
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargar();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;

            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();

            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show(
                    "¿Quieres eliminar el artículo seleccionado?",
                    "Eliminando",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                    negocio.eliminar(seleccionado.Id);

                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltro.Text;

            if (filtro.Length >= 3)
            {
                listaFiltrada = listaArticulos.FindAll(
                    x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) ||
                         x.Codigo.ToUpper().Contains(filtro.ToUpper()) ||
                         x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()) ||
                         x.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper())
                );
            }
            else
            {
                listaFiltrada = listaArticulos;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;

        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;

            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            frmDetalleArticulo detalle = new frmDetalleArticulo(seleccionado);
            detalle.ShowDialog();
        }
    }
}
