namespace FormularioContacto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) ||
        string.IsNullOrEmpty(textBox2.Text) ||
        string.IsNullOrEmpty(textBox3.Text))
            {
                label4.Text = "Falta información. Por favor, complete todos los campos.";
                label4.ForeColor = Color.Red;
            }
            else
            {
                label4.Text = "Formulario enviado correctamente.";
                label4.ForeColor = Color.Green;
            }
        }
    }
}
