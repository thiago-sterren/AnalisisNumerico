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
    public partial class Secante : Form
    {
        public Secante()
        {
            InitializeComponent();
        }

        private void Secante_Load(object sender, EventArgs e)
        {
            txtIteraciones.Text = "100";
            txtTolerancia.Text = "0.0001";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calculo analizadorDeFunciones = new Calculo();
            string funcion = txtFuncion.Text;
            double xi = double.Parse(txtXI.Text);
            double xd = double.Parse(txtXD.Text);
            double tolerancia = double.Parse(txtTolerancia.Text);
            int iteraciones = int.Parse(txtIteraciones.Text);

            if (analizadorDeFunciones.Sintaxis(funcion, 'x')) //pasamos la funcion con la variable a evaluar
            {
                if (Math.Abs(analizadorDeFunciones.EvaluaFx(xi)) < tolerancia)
                {
                    MessageBox.Show($"La raíz es {xi}");
                }
                else if (Math.Abs(analizadorDeFunciones.EvaluaFx(xd)) < tolerancia)
                {
                    MessageBox.Show($"La raíz es {xd}");
                }
                else
                {
                    double xr = 0;
                    double xrAnterior = 0;
                    double error = 0;
                    for (int i = 1; i <= iteraciones; i++)
                    {
                        xr = (analizadorDeFunciones.EvaluaFx(xd) * xi - analizadorDeFunciones.EvaluaFx(xi) * xd) / (analizadorDeFunciones.EvaluaFx(xd) - analizadorDeFunciones.EvaluaFx(xi));
                        error = Math.Abs((xr - xrAnterior) / xr);
                        if (xr == double.NaN)
                        {
                            MessageBox.Show($"El método diverge. No encuentra raíz");
                            break;
                        }
                        if (Math.Abs(analizadorDeFunciones.EvaluaFx(xr)) < tolerancia || error < tolerancia)
                        {
                            MessageBox.Show($"La raíz es {xr}, con un error de {error}, encontrada en la iteración {i}");
                            break;
                        }
                        else
                        {
                            xi = xd;
                            xd = xr;
                            xrAnterior = xr;
                        }
                    }
                    if (Math.Abs(analizadorDeFunciones.EvaluaFx(xr)) >= tolerancia && error >= tolerancia)
                    {
                        MessageBox.Show($"No se encontró la raíz en {iteraciones} iteraciones. XR final: {xr}");
                    }
                }
            }
        }
    }
}
