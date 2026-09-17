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
    public partial class frmDetalleArticulo : Form
    {
        private Articulo articulo;
        private List<Imagen> imagenes;
        private int indiceImagen = 0;
        public frmDetalleArticulo()
        {
            InitializeComponent();
        }
        public frmDetalleArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }
        private void frmDetalleArticulo_Load(object sender, EventArgs e)
        {
            lblCodigoValor.Text = articulo.Codigo;
            lblNombreValor.Text = articulo.Nombre;
            lblDescripcionValor.Text = articulo.Descripcion;
            lblMarcaValor.Text = articulo.Marca.Descripcion;
            lblCategoriaValor.Text = articulo.Categoria.Descripcion;
            lblPrecioValor.Text = articulo.Precio.ToString();

            ImagenNegocio imagenNegocio = new ImagenNegocio();

            imagenes = imagenNegocio.listarPorArticulo(articulo.Id);

            if (imagenes.Count > 0)
            {
                cargarImagen(imagenes[0].ImagenUrl);
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (imagenes.Count > 0)
            {
                indiceImagen++;

                if (indiceImagen >= imagenes.Count)
                {
                    indiceImagen = 0;
                }

                cargarImagen(imagenes[indiceImagen].ImagenUrl);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (imagenes.Count > 0)
            {
                indiceImagen--;

                if (indiceImagen < 0)
                {
                    indiceImagen = imagenes.Count - 1;
                }

                cargarImagen(imagenes[indiceImagen].ImagenUrl);
            }
        }
    }
}
