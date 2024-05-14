using CeleryAPI;

namespace KotoPlex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CeleryAPI.ByfronPlayer.Inject();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CeleryAPI.ByfronPlayer.execute(richTextBox1.Text);
        }
    }
}
