namespace TPWinForm_equipo_H
{
    partial class frmDetalleArticulo
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
            lblTitulo = new Label();
            lblCodigoValor = new Label();
            lblNombreValor = new Label();
            lblDescripcionValor = new Label();
            lblMarcaValor = new Label();
            lblCategoriaValor = new Label();
            lblPrecioValor = new Label();
            btnCerrar = new Button();
            pbxImagen = new PictureBox();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            ((System.ComponentModel.ISupportInitialize)pbxImagen).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(60, 38);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(141, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Detalle del Artículo";
            // 
            // lblCodigoValor
            // 
            lblCodigoValor.AutoSize = true;
            lblCodigoValor.Location = new Point(21, 84);
            lblCodigoValor.Name = "lblCodigoValor";
            lblCodigoValor.Size = new Size(49, 15);
            lblCodigoValor.TabIndex = 1;
            lblCodigoValor.Text = "Código:";
            // 
            // lblNombreValor
            // 
            lblNombreValor.AutoSize = true;
            lblNombreValor.Location = new Point(23, 113);
            lblNombreValor.Name = "lblNombreValor";
            lblNombreValor.Size = new Size(57, 15);
            lblNombreValor.TabIndex = 2;
            lblNombreValor.Text = "Nombre: ";
            // 
            // lblDescripcionValor
            // 
            lblDescripcionValor.AutoSize = true;
            lblDescripcionValor.Location = new Point(23, 143);
            lblDescripcionValor.Name = "lblDescripcionValor";
            lblDescripcionValor.Size = new Size(72, 15);
            lblDescripcionValor.TabIndex = 3;
            lblDescripcionValor.Text = "Descripción:";
            // 
            // lblMarcaValor
            // 
            lblMarcaValor.AutoSize = true;
            lblMarcaValor.Location = new Point(23, 174);
            lblMarcaValor.Name = "lblMarcaValor";
            lblMarcaValor.Size = new Size(46, 15);
            lblMarcaValor.TabIndex = 4;
            lblMarcaValor.Text = "Marca: ";
            // 
            // lblCategoriaValor
            // 
            lblCategoriaValor.AutoSize = true;
            lblCategoriaValor.Location = new Point(21, 202);
            lblCategoriaValor.Name = "lblCategoriaValor";
            lblCategoriaValor.Size = new Size(64, 15);
            lblCategoriaValor.TabIndex = 5;
            lblCategoriaValor.Text = "Categoría: ";
            // 
            // lblPrecioValor
            // 
            lblPrecioValor.AutoSize = true;
            lblPrecioValor.Location = new Point(23, 233);
            lblPrecioValor.Name = "lblPrecioValor";
            lblPrecioValor.Size = new Size(43, 15);
            lblPrecioValor.TabIndex = 6;
            lblPrecioValor.Text = "Precio:";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(20, 318);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 7;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // pbxImagen
            // 
            pbxImagen.Location = new Point(177, 75);
            pbxImagen.Name = "pbxImagen";
            pbxImagen.Size = new Size(175, 173);
            pbxImagen.SizeMode = PictureBoxSizeMode.Zoom;
            pbxImagen.TabIndex = 8;
            pbxImagen.TabStop = false;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(177, 262);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(75, 23);
            btnAnterior.TabIndex = 9;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(277, 262);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(75, 23);
            btnSiguiente.TabIndex = 10;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // frmDetalleArticulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 426);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAnterior);
            Controls.Add(pbxImagen);
            Controls.Add(btnCerrar);
            Controls.Add(lblPrecioValor);
            Controls.Add(lblCategoriaValor);
            Controls.Add(lblMarcaValor);
            Controls.Add(lblDescripcionValor);
            Controls.Add(lblNombreValor);
            Controls.Add(lblCodigoValor);
            Controls.Add(lblTitulo);
            Name = "frmDetalleArticulo";
            Text = "frmDetalleArticulo";
            Load += frmDetalleArticulo_Load;
            ((System.ComponentModel.ISupportInitialize)pbxImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblCodigoValor;
        private Label lblNombreValor;
        private Label lblDescripcionValor;
        private Label lblMarcaValor;
        private Label lblCategoriaValor;
        private Label lblPrecioValor;
        private Button btnCerrar;
        private PictureBox pbxImagen;
        private Button btnAnterior;
        private Button btnSiguiente;
    }
}