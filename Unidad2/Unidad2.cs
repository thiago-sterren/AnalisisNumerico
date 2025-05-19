using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalisisNumerico.Unidad2
{
    public partial class Unidad2 : Form
    {
        public Unidad2()
        {
            InitializeComponent();
        }

        private void btnGenerarMatriz_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAplicarMetodo_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GaussJordan gj = new GaussJordan();
            gj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GaussSeidel gs = new GaussSeidel();
            gs.Show();
            this.Hide();
        }
    }
}
