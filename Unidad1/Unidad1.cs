using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculus;

namespace AnalisisNumerico.Unidad1
{
    public partial class Unidad1 : Form
    {
        public Unidad1()
        {
            InitializeComponent();
        }

        private void btnBiseccion_Click(object sender, EventArgs e)
        {
            Biseccion biseccion = new Biseccion();
            biseccion.Show();
            this.Hide();
        }

        private void btnReglaFalsa_Click(object sender, EventArgs e)
        {
            ReglaFalsa reglaFalsa = new ReglaFalsa();
            reglaFalsa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tangente tangente = new Tangente();
            tangente.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Secante secante = new Secante();
            secante.Show();
            this.Hide();
        }
    }
}
