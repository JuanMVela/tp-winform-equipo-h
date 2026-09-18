namespace TPWinForm_equipo_H
{
    partial class frmAltaArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCodigo = new Label();
            lblNombre = new Label();
            lblDescripción = new Label();
            lblPrecio = new Label();
            lblCategoría = new Label();
            lblMarca = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            cboMarca = new ComboBox();
            cboCategoria = new ComboBox();
            txtPrecio = new TextBox();
            lblImágenes = new Label();
            lstImagenes = new ListBox();
            txtImagenUrl = new TextBox();
            btnAgregarImagen = new Button();
            btnQuitarImagen = new Button();
            pbxImagen = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbxImagen).BeginInit();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(47, 21);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Codigo";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(47, 61);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblDescripción
            // 
            lblDescripción.AutoSize = true;
            lblDescripción.Location = new Point(47, 92);
            lblDescripción.Name = "lblDescripción";
            lblDescripción.Size = new Size(69, 15);
            lblDescripción.TabIndex = 2;
            lblDescripción.Text = "Descripción";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(47, 201);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "Precio";
            // 
            // lblCategoría
            // 
            lblCategoría.AutoSize = true;
            lblCategoría.Location = new Point(47, 166);
            lblCategoría.Name = "lblCategoría";
            lblCategoría.Size = new Size(58, 15);
            lblCategoría.TabIndex = 4;
            lblCategoría.Text = "Categoría";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(47, 129);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 3;
            lblMarca.Text = "Marca";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(99, 266);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(215, 266);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(128, 18);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(120, 23);
            txtCodigo.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(128, 53);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(120, 23);
            txtNombre.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(128, 89);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(121, 23);
            txtDescripcion.TabIndex = 10;
            // 
            // cboMarca
            // 
            cboMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMarca.FormattingEnabled = true;
            cboMarca.Location = new Point(128, 126);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(121, 23);
            cboMarca.TabIndex = 11;
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(128, 163);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(121, 23);
            cboCategoria.TabIndex = 12;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(128, 198);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(121, 23);
            txtPrecio.TabIndex = 13;
            // 
            // lblImágenes
            // 
            lblImágenes.AutoSize = true;
            lblImágenes.Location = new Point(400, 21);
            lblImágenes.Name = "lblImágenes";
            lblImágenes.Size = new Size(58, 15);
            lblImágenes.TabIndex = 14;
            lblImágenes.Text = "Imágenes";
            // 
            // lstImagenes
            // 
            lstImagenes.FormattingEnabled = true;
            lstImagenes.Location = new Point(465, 21);
            lstImagenes.Name = "lstImagenes";
            lstImagenes.Size = new Size(153, 94);
            lstImagenes.TabIndex = 15;
            lstImagenes.SelectedIndexChanged += lstImagenes_SelectedIndexChanged;
            // 
            // txtImagenUrl
            // 
            txtImagenUrl.Location = new Point(465, 126);
            txtImagenUrl.Name = "txtImagenUrl";
            txtImagenUrl.Size = new Size(153, 23);
            txtImagenUrl.TabIndex = 16;
            // 
            // btnAgregarImagen
            // 
            btnAgregarImagen.Location = new Point(465, 166);
            btnAgregarImagen.Name = "btnAgregarImagen";
            btnAgregarImagen.Size = new Size(153, 23);
            btnAgregarImagen.TabIndex = 17;
            btnAgregarImagen.Text = "Agregar Imagen";
            btnAgregarImagen.UseVisualStyleBackColor = true;
            btnAgregarImagen.Click += btnAgregarImagen_Click;
            // 
            // btnQuitarImagen
            // 
            btnQuitarImagen.Location = new Point(635, 166);
            btnQuitarImagen.Name = "btnQuitarImagen";
            btnQuitarImagen.Size = new Size(153, 23);
            btnQuitarImagen.TabIndex = 18;
            btnQuitarImagen.Text = "Quitar Imagen";
            btnQuitarImagen.UseVisualStyleBackColor = true;
            btnQuitarImagen.Click += btnQuitarImagen_Click;
            // 
            // pbxImagen
            // 
            pbxImagen.Location = new Point(635, 21);
            pbxImagen.Name = "pbxImagen";
            pbxImagen.Size = new Size(153, 139);
            pbxImagen.SizeMode = PictureBoxSizeMode.Zoom;
            pbxImagen.TabIndex = 19;
            pbxImagen.TabStop = false;
            // 
            // frmAltaArticulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pbxImagen);
            Controls.Add(btnQuitarImagen);
            Controls.Add(btnAgregarImagen);
            Controls.Add(txtImagenUrl);
            Controls.Add(lstImagenes);
            Controls.Add(lblImágenes);
            Controls.Add(txtPrecio);
            Controls.Add(cboCategoria);
            Controls.Add(cboMarca);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lblPrecio);
            Controls.Add(lblCategoría);
            Controls.Add(lblMarca);
            Controls.Add(lblDescripción);
            Controls.Add(lblNombre);
            Controls.Add(lblCodigo);
            Name = "frmAltaArticulo";
            Text = "frmAltaArticulo";
            Load += frmAltaArticulo_Load;
            ((System.ComponentModel.ISupportInitialize)pbxImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label lblNombre;
        private Label lblDescripción;
        private Label lblPrecio;
        private Label lblCategoría;
        private Label lblMarca;
        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private ComboBox cboMarca;
        private ComboBox cboCategoria;
        private TextBox txtPrecio;
        private Label lblImágenes;
        private ListBox lstImagenes;
        private TextBox txtImagenUrl;
        private Button btnAgregarImagen;
        private Button btnQuitarImagen;
        private PictureBox pbxImagen;
    }
}