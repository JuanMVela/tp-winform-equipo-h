using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using dominio;

namespace TPWinForm_equipo_H
{
    public partial class frmDetalleArticulo : Form
    {
        private Articulo articulo;
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
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
