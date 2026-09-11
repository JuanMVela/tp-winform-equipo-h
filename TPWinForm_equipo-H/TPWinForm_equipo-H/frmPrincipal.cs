namespace TPWinForm_equipo_H
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArticulos ventana = new frmArticulos();
            ventana.ShowDialog();
        }
    }
}
