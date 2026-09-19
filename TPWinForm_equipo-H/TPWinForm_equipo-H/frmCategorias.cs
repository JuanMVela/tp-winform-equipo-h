using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TPWinForm_equipo_H
{
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                dgvCategorias.DataSource = negocio.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Categoria nueva = new Categoria();
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                if (txtDescripcion.Text == "")
                {
                    MessageBox.Show("Ingresá una descripción para la categoría.");
                    return;
                }

                nueva.Descripcion = txtDescripcion.Text;

                negocio.agregar(nueva);

                MessageBox.Show("Categoría agregada exitosamente");

                txtDescripcion.Clear();

                cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                if (txtDescripcion.Text == "")
                {
                    MessageBox.Show("Ingresá una descripción para la categoría.");
                    return;
                }

                if (dgvCategorias.CurrentRow != null &&
                    dgvCategorias.CurrentRow.DataBoundItem != null)
                {
                    Categoria seleccionada;

                    seleccionada = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;

                    seleccionada.Descripcion = txtDescripcion.Text;

                    negocio.modificar(seleccionada);

                    MessageBox.Show("Categoría modificada exitosamente");

                    txtDescripcion.Clear();

                    cargar();
                }
                else
                {
                    MessageBox.Show("Seleccioná una categoría para modificar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                if (dgvCategorias.CurrentRow != null &&
                    dgvCategorias.CurrentRow.DataBoundItem != null)
                {
                    Categoria seleccionada;

                    seleccionada = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;

                    if (negocio.estaEnUso(seleccionada.Id))
                    {
                        MessageBox.Show(
                            "No se puede eliminar la categoría porque está siendo utilizada por un artículo."
                        );
                    }
                    else
                    {
                        DialogResult respuesta = MessageBox.Show(
                            "¿De verdad querés eliminar la categoría?",
                            "Eliminando",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning
                        );

                        if (respuesta == DialogResult.Yes)
                        {
                            negocio.eliminar(seleccionada.Id);

                            MessageBox.Show("Categoría eliminada exitosamente");

                            cargar();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Seleccioná una categoría para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
