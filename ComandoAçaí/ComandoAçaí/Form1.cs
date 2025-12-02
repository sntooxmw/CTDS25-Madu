using System.Diagnostics.Eventing.Reader;

namespace ComandoAçaí
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxItensePedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxItensPedido.Items.Clear();

            if (radioButton300mL.Checked)
                listBoxItensPedido.Items.Add("Tamanho: 300mL - R$ 13,00");
            else if (radioButton500mL.Checked)
                listBoxItensPedido.Items.Add("Tamanho: 500mL - R$ 19,00");
            else if (radioButton700mL.Checked)
                listBoxItensPedido.Items.Add("Tamanho: 700mL - R$ 24,00");
            else if (radioButton1L.Checked)
                listBoxItensPedido.Items.Add("Tamanho: 1L - R$ 32,00");
            else if (radioButtonLitroeMeio.Checked)
                listBoxItensPedido.Items.Add("Tamanho: 1,5L - 44,00");
            else if (radioButton2L.Checked)
                listBoxItensPedido.Items.Add("Tamanho: 2L - 55,00");
        }

        private void listBoxComplementos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void listBoxCorberturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxCorberturas.Items.Clear();

            if (radioButtonAmora.Checked)
                listBoxCorberturas.
        }
    }
}