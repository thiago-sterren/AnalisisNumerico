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
    public partial class Tangente : Form
    {
        public Tangente()
        {
            InitializeComponent();
        }

        private void Tangente_Load(object sender, EventArgs e)
        {
            txtIteraciones.Text = "100";
            txtTolerancia.Text = "0.0001";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calculo analizadorDeFunciones = new Calculo();
            string funcion = txtFuncion.Text;
            double xi = double.Parse(txtXI.Text);
            double tolerancia = double.Parse(txtTolerancia.Text);
            int iteraciones = int.Parse(txtIteraciones.Text);

            if (analizadorDeFunciones.Sintaxis(funcion, 'x')) //pasamos la funcion con la variable a evaluar
            {
                if (Math.Abs(analizadorDeFunciones.EvaluaFx(xi)) < tolerancia)
                {
                    MessageBox.Show($"La raíz es {xi}");
                }
                else
                {
                    double xr = 0;
                    double xrAnterior = 0;
                    double error = 0;
                    for (int i = 1; i <= iteraciones; i++)
                    {
                        double derivada = analizadorDeFunciones.Dx(xi);
                        if (derivada < tolerancia || derivada == double.NaN)
                        {
                            MessageBox.Show($"El método diverge. No encuentra raíz");
                            break;
                        }
                        else
                        {
                            xr = xi - (analizadorDeFunciones.EvaluaFx(xi) / derivada);
                        }
                        if (xr == double.NaN)
                        {
                            MessageBox.Show($"El método diverge. No encuentra raíz");
                            break;
                        }
                        error = Math.Abs((xr - xrAnterior) / xr);
                        if (Math.Abs(analizadorDeFunciones.EvaluaFx(xr)) < tolerancia || error < tolerancia)
                        {
                            MessageBox.Show($"La raíz es {xr}, con un error de {error}, encontrada en la iteración {i}");
                            break;
                        }
                        else
                        {
                            xi = xr;
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
