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
    public partial class Biseccion : Form
    {
        public Biseccion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                if (analizadorDeFunciones.EvaluaFx(xi) * analizadorDeFunciones.EvaluaFx(xd) > 0)
                {
                    MessageBox.Show($"El intervalo [{xi}, {xd}] no contiene a la raíz. Por favor, vuelva a ingresar xi y xd.");
                    txtXI.Clear();
                    txtXD.Clear();
                }
                else if (analizadorDeFunciones.EvaluaFx(xi) * analizadorDeFunciones.EvaluaFx(xd) == 0)
                {
                    if (analizadorDeFunciones.EvaluaFx(xi) == 0)
                    {
                        MessageBox.Show($"La raíz es {xi}");
                    }
                    else
                    {
                        MessageBox.Show($"La raíz es {xd}");
                    }
                }
                else
                {
                    double xr = 0;
                    double xrAnterior = 0;
                    double error = 0;
                    for (int i = 1; i <= iteraciones; i++)
                    {
                        xr = (xi + xd) / 2;
                        error = Math.Abs((xr - xrAnterior) / xr);
                        if (Math.Abs(analizadorDeFunciones.EvaluaFx(xr)) < tolerancia || error < tolerancia)
                        {
                            MessageBox.Show($"La raíz es {xr}, con un error de {error}, encontrada en la iteración {i}");
                            break;
                        }
                        else
                        {
                            if (analizadorDeFunciones.EvaluaFx(xi) * analizadorDeFunciones.EvaluaFx(xr) > 0)
                            {
                                xi = xr;
                            }
                            else
                            {
                                xd = xr;
                            }
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

        private void Biseccion_Load(object sender, EventArgs e)
        {
            txtIteraciones.Text = "100";
            txtTolerancia.Text = "0.0001";
        }
    }
}
