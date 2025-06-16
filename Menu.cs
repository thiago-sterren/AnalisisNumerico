using AnalisisNumericoTP4;

namespace AnalisisNumerico
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Unidad1.Unidad1 unidad1 = new Unidad1.Unidad1();
            unidad1.Show();
            this.Hide();
        }

        private void btnUnidad2_Click(object sender, EventArgs e)
        {
            Unidad2.Unidad2 unidad2 = new Unidad2.Unidad2();
            unidad2.Show();
            this.Hide();
        }

        private void btnUnidad3_Click(object sender, EventArgs e)
        {
            Unidad3.Unidad3 unidad3 = new Unidad3.Unidad3();
            unidad3.Show();
            this.Hide();
        }

        private void btnUnidad4_Click(object sender, EventArgs e)
        {
            Unidad4 unidad4 = new Unidad4();
            unidad4.Show();
            this.Hide();
        }
    }
}
