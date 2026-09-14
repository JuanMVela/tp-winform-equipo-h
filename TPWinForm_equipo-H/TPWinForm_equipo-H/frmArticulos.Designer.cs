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
            dgvArticulos.Location = new Point(33, 108);
            dgvArticulos.MultiSelect = false;
            dgvArticulos.Name = "dgvArticulos";
            dgvArticulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArticulos.Size = new Size(612, 225);
            dgvArticulos.TabIndex = 1;
            // 
            // frmArticulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}