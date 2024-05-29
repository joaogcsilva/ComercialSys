namespace ComercialSys
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.MdiParent = this;
            frmCliente.StartPosition = FormStartPosition.CenterScreen;
            frmCliente.Show();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario();
            frmUsuario.MdiParent = this;
            frmUsuario.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria frmCategorias = new FrmCategoria();
            frmCategorias.MdiParent = this;
            frmCategorias.StartPosition = FormStartPosition.CenterScreen;
            frmCategorias.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //FrmLogin login = new();
            //login.MdiParent = this;
            //login.StartPosition = FormStartPosition.CenterScreen;
            //this.Hide();
            //login.ShowDialog();
            //if(Program.Usuario.Nivel != null)
            //tslUsuario.Text = Program.Usuario.Nome + " - " + Program.Usuario.Nivel.Nome;
        }

    }
}
