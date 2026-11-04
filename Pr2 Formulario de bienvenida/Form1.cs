namespace practica2
{
    public partial class FormularioBienvenida : Form
    {
        public FormularioBienvenida()
        {
            InitializeComponent();
            ToolTip mensajeAyuda = new ToolTip();

            mensajeAyuda.SetToolTip(txtEdad, "la edad debe ser igual o mas que 0");

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string textoEdad = txtEdad.Text;
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Introduce tu nombre.", "Error");
                return;
            }
            if (!int.TryParse(textoEdad, out int edad) || edad < 0)
            {
                MessageBox.Show("Introduce una edad válida.", "Error");
                return;
            }
            if (edad < 18 && edad > 0)
            {
                lblResultado1.Text = $"Hola, {nombre} eres menor.";
                lblResultado2.Text = $"Tienes {edad} años.";
            }
            else if (edad >= 18)
            {
                lblResultado1.Text = $"Hola, {nombre} eres mayor.";
                lblResultado2.Text = $"Tienes {edad} años.";
            }
            else
            {
                lblResultado1.Text = $"Hola, {nombre} aun no has nacido.";
                lblResultado2.Text = $"Tienes {edad} años.";

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtEdad.Text = "";
            lblResultado1.Text = "Aquí aparecerá el resultado ";
        }

       
    }
}
