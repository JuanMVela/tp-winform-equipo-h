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
    public partial class frmMarcas : Form
    {
        public frmMarcas()
        {
            InitializeComponent();
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                dgvMarcas.DataSource = negocio.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Marca nueva = new Marca();
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                nueva.Descripcion = txtDescripcion.Text;

                negocio.agregar(nueva);

                MessageBox.Show("Marca agregada exitosamente");

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
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                if (txtDescripcion.Text == "")
                {
                    MessageBox.Show("Ingresá una descripción para la marca.");
                    return;
                }

                if (dgvMarcas.CurrentRow != null &&
                    dgvMarcas.CurrentRow.DataBoundItem != null)
                {
                    Marca seleccionada;

                    seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;

                    seleccionada.Descripcion = txtDescripcion.Text;

                    negocio.modificar(seleccionada);

                    MessageBox.Show("Marca modificada exitosamente");

                    txtDescripcion.Clear();

                    cargar();
                }
                else
                {
                    MessageBox.Show("Seleccioná una marca para modificar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
