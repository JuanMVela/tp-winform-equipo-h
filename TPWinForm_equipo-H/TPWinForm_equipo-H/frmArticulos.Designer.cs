namespace TPWinForm_equipo_H
{
    partial class frmArticulos
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
            dgvArticulos = new DataGridView();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            lblFiltro = new Label();
            txtFiltro = new TextBox();
            lblCampo = new Label();
            lblCriterio = new Label();
            cboCampo = new ComboBox();
            cboCriterio = new ComboBox();
            lblFiltroArt = new Label();
            txtFiltroAvanzado = new TextBox();
            btnBuscar = new Button();
            btnDetalle = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(2, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(177, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Listado de Artículos";
            // 
            // dgvArticulos
            // 
            dgvArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticulos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvArticulos.Location = new Point(33, 108);
            dgvArticulos.MultiSelect = false;
            dgvArticulos.Name = "dgvArticulos";
            dgvArticulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArticulos.Size = new Size(612, 225);
            dgvArticulos.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(33, 391);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(124, 391);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(214, 391);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Location = new Point(36, 347);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(45, 15);
            lblFiltro.TabIndex = 5;
            lblFiltro.Text = "Buscar:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(87, 344);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(202, 23);
            txtFiltro.TabIndex = 6;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // lblCampo
            // 
            lblCampo.AutoSize = true;
            lblCampo.Location = new Point(386, 349);
            lblCampo.Name = "lblCampo";
            lblCampo.Size = new Size(49, 15);
            lblCampo.TabIndex = 7;
            lblCampo.Text = "Campo:";
            // 
            // lblCriterio
            // 
            lblCriterio.AutoSize = true;
            lblCriterio.Location = new Point(386, 386);
            lblCriterio.Name = "lblCriterio";
            lblCriterio.Size = new Size(49, 15);
            lblCriterio.TabIndex = 8;
            lblCriterio.Text = "Criterio:";
            // 
            // cboCampo
            // 
            cboCampo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCampo.FormattingEnabled = true;
            cboCampo.Location = new Point(441, 344);
            cboCampo.Name = "cboCampo";
            cboCampo.Size = new Size(121, 23);
            cboCampo.TabIndex = 9;
            cboCampo.SelectedIndexChanged += cboCampo_SelectedIndexChanged;
            // 
            // cboCriterio
            // 
            cboCriterio.FormattingEnabled = true;
            cboCriterio.Location = new Point(441, 383);
            cboCriterio.Name = "cboCriterio";
            cboCriterio.Size = new Size(121, 23);
            cboCriterio.TabIndex = 10;
            // 
            // lblFiltroArt
            // 
            lblFiltroArt.AutoSize = true;
            lblFiltroArt.Location = new Point(386, 428);
            lblFiltroArt.Name = "lblFiltroArt";
            lblFiltroArt.Size = new Size(37, 15);
            lblFiltroArt.TabIndex = 11;
            lblFiltroArt.Text = "Filtro:";
            // 
            // txtFiltroAvanzado
            // 
            txtFiltroAvanzado.Location = new Point(441, 425);
            txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            txtFiltroAvanzado.Size = new Size(121, 23);
            txtFiltroAvanzado.TabIndex = 12;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(593, 425);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 13;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnDetalle
            // 
            btnDetalle.Location = new Point(36, 514);
            btnDetalle.Name = "btnDetalle";
            btnDetalle.Size = new Size(75, 23);
            btnDetalle.TabIndex = 14;
            btnDetalle.Text = "Detalle";
            btnDetalle.UseVisualStyleBackColor = true;
            btnDetalle.Click += btnDetalle_Click;
            // 
            // frmArticulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 583);
            Controls.Add(btnDetalle);
            Controls.Add(btnBuscar);
            Controls.Add(txtFiltroAvanzado);
            Controls.Add(lblFiltroArt);
            Controls.Add(cboCriterio);
            Controls.Add(cboCampo);
            Controls.Add(lblCriterio);
            Controls.Add(lblCampo);
            Controls.Add(txtFiltro);
            Controls.Add(lblFiltro);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvArticulos);
            Controls.Add(lblTitulo);
            Name = "frmArticulos";
            Text = "frmArticulos";
            Load += frmArticulos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private DataGridView dgvArticulos;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Label lblFiltro;
        private TextBox txtFiltro;
        private Label lblCampo;
        private Label lblCriterio;
        private ComboBox cboCampo;
        private ComboBox cboCriterio;
        private Label lblFiltroArt;
        private TextBox txtFiltroAvanzado;
        private Button btnBuscar;
        private Button btnDetalle;
    }
}