using System.Threading.Tasks;

namespace Practica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            int populationSize = int.Parse(textBox1.Text);
            int dimensions = int.Parse(textBox2.Text);
            int minRange = int.Parse(textBox3.Text);
            int maxRange = int.Parse(textBox4.Text);
            int maxGenerations = int.Parse(textBox5.Text);

            double[] result = DifferentualEvolution.OptimizeAckley(populationSize, dimensions, minRange, maxRange, maxGenerations);
            richTextBox1.Text = string.Join("\n", result);

        }
    }
}