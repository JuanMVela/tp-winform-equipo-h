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
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        private List<Imagen> imagenes = new List<Imagen>();
        public frmAltaArticulo()
        {
            InitializeComponent();
        }
        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }
        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";

                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtPrecio.Text = articulo.Precio.ToString();

                    cboMarca.SelectedValue = articulo.Marca.Id;
                    cboCategoria.SelectedValue = articulo.Categoria.Id;

                    ImagenNegocio imagenNegocio = new ImagenNegocio();

                    imagenes = imagenNegocio.listarPorArticulo(articulo.Id);

                    lstImagenes.DataSource = imagenes;
                    lstImagenes.DisplayMember = "ImagenUrl";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecio.Text);

                if (articulo.Id != 0)
                {
                    negocio.modificar(articulo);

                    ImagenNegocio imagenNegocio = new ImagenNegocio();

                    imagenNegocio.eliminarPorArticulo(articulo.Id);

                    for (int i = 0; i < imagenes.Count; i++)
                    {
                        imagenes[i].IdArticulo = articulo.Id;
                        imagenNegocio.agregar(imagenes[i]);
                    }

                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(articulo);

                    ImagenNegocio imagenNegocio = new ImagenNegocio();

                    for (int i = 0; i < imagenes.Count; i++)
                    {
                        imagenes[i].IdArticulo = articulo.Id;
                        imagenNegocio.agregar(imagenes[i]);
                    }

                    MessageBox.Show("Agregado exitosamente");


                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void lstImagenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstImagenes.SelectedItem != null)
            {
                Imagen seleccionada = (Imagen)lstImagenes.SelectedItem;

                cargarImagen(seleccionada.ImagenUrl);
            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxImagen.Load(imagen);
            }
            catch
            {
                pbxImagen.Image = null;
            }
        }
        private void actualizarListaImagenes()
        {
            lstImagenes.DataSource = null;
            lstImagenes.DataSource = imagenes;
            lstImagenes.DisplayMember = "ImagenUrl";
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            if (txtImagenUrl.Text != "")
            {
                Imagen nueva = new Imagen();

                nueva.ImagenUrl = txtImagenUrl.Text;

                if (articulo != null)
                {
                    nueva.IdArticulo = articulo.Id;
                }

                imagenes.Add(nueva);

                actualizarListaImagenes();

                lstImagenes.SelectedIndex = imagenes.Count - 1;

                txtImagenUrl.Clear();
            }
        }

        private void btnQuitarImagen_Click(object sender, EventArgs e)
        {
            if (lstImagenes.SelectedItem != null)
            {
                Imagen seleccionada = (Imagen)lstImagenes.SelectedItem;

                imagenes.Remove(seleccionada);

                actualizarListaImagenes();

                pbxImagen.Image = null;
            }
        }
    }
}
