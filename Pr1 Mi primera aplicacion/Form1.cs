using Microsoft.VisualBasic.Logging;

namespace WinFormsApp1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Hola, Anass!","Bienvenido");

        }

        private void btnDespedir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Hasta pronto, Anass!","Ciao");
        }
    }
}
