namespace Atletas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button2_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem.ToString() == "Ciclista")
            {
                Atleta ciclista = new Ciclista();
                ciclista.nome = textBox1.Text;
                ciclista.VerHabilidades();

            }
            else if (comboBox1.SelectedItem.ToString() == "Corredor")
            {
                Atleta corredor = new Corredor();
                corredor.nome = textBox1.Text;
                corredor.VerHabilidades();
            }
            else if (comboBox1.SelectedItem.ToString() == "Nadador")
            {
                Atleta nadador = new Nadador();
                nadador.nome = textBox1.Text;
                nadador.VerHabilidades();
            }
            else if (comboBox1.SelectedItem.ToString() == "Triatleta")
            {
                Atleta triatleta = new Triatleta();
                triatleta.nome = textBox1.Text;
                triatleta.VerHabilidades();
            }

        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Ciclista")
            {
                Atleta ciclista = new Ciclista();
                ciclista.nome = textBox1.Text;
                ciclista.VerAcao();

            }
            else if (comboBox1.SelectedItem.ToString() == "Corredor")
            {
                Atleta corredor = new Corredor();
                corredor.nome = textBox1.Text;
                corredor.VerAcao();
            }
            else if (comboBox1.SelectedItem.ToString() == "Nadador")
            {
                Atleta nadador = new Nadador();
                nadador.nome = textBox1.Text;
                nadador.VerAcao();
            }
            else if (comboBox1.SelectedItem.ToString() == "Triatleta")
            {
                Atleta triatleta = new Triatleta();
                triatleta.nome = textBox1.Text;
                triatleta.VerAcao();
            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}