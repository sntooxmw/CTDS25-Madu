namespace Calculadora_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Madu(object sender, EventArgs e)
        {

        }

        private void enterPeso(object sender, EventArgs e)
        {
            txtPeso.BackColor = Color.LightPink;
            txtAltura.BackColor = Color.White;
        }

        private void enterAltura(object sender, EventArgs e)
        {
            txtAltura.BackColor = Color.LightPink;
            txtPeso.BackColor = Color.White;
        }

        private void gerarNumeros(object sender, EventArgs e)
        {
            if ((sender as Button).Text == ",")
            {
                if (txtPeso.BackColor == Color.LightPink)
                {
                    if (!txtPeso.Text.Contains(","))
                    {
                        txtPeso.Text += (sender as Button).Text;
                    }
                }
                if (txtAltura.BackColor == Color.LightPink)
                {
                    if (!txtAltura.Text.Contains(","))
                    {
                        txtAltura.Text += (sender as Button).Text;
                    }
                }
            }
            else
            {
                if (txtPeso.BackColor == Color.LightPink)
                {
                    txtPeso.Text += (sender as Button).Text;
                }
                if (txtAltura.BackColor == Color.LightPink)
                {
                    txtAltura.Text += (sender as Button).Text;
                }
            }
        }
    }
}