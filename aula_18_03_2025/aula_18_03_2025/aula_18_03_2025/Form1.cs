namespace aula_18_03_2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Resultado_Click(object sender, EventArgs e)
        {
            int totalVotos;
            int votosBrancos = Convert.ToInt32(txt_Votos_brancos.Text);
            int votosNulos = Convert.ToInt32(txt_Votos_Nulos.Text);
            int votosValidos = Convert.ToInt32(txt_Votos_Validos.Text);

            totalVotos = votosBrancos + votosNulos + votosValidos;

            lbl_resultado.Text = $"{votosBrancos * 100 / totalVotos}% de votos em branco\n";
            lbl_resultado.Text += $"{votosNulos * 100 / totalVotos}% de votos nulos\n";
            lbl_resultado.Text += $"{votosValidos * 100 / totalVotos}% de votos Válidos\n";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl__Click(object sender, EventArgs e)
        {

        }
    }
}
