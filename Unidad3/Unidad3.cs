using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Analisis_Numerico;

namespace AnalisisNumerico.Unidad3
{
    public partial class Unidad3 : Form
    {
        public List<double[]> PuntosCargados { get; set; } = new List<double[]>();
        public Graficador graficador { get; set; }
        private double tolerancia => double.TryParse(txtTolerancia.Text, out double t) ? t : 0.8;
        public Unidad3()
        {
            InitializeComponent();
        }
        private (string funcion, double r, string efectividad) Calcular()
        {
            int n = PuntosCargados.Count;
            if (n < 2)
                return ("", 0, "No hay suficientes puntos");

            string metodo = cBoxMetodo.SelectedItem?.ToString();
            if (metodo == "Regresión Polinomial")
            {
                if (!int.TryParse(txtGrado.Text, out int grado) || grado < 2 || grado > 10)
                    return ("", 0, "Grado inválido. Ingrese un número entre 2 y 10.");

                var matriz = GenerarMatrizPolinomial(grado, PuntosCargados);
                var vector = ResolverGaussJordan(matriz);
                var funcion = ArmarFuncionPolinomial(vector);
                var r = CalcularCorrelacion(vector, PuntosCargados);
                var efectividad = r >= tolerancia * 100
                    ? "El ajuste es aceptable."
                    : "El ajuste no es aceptable.";
                return (funcion, r, efectividad);
            }

            // Caso por defecto: regresión lineal
            if (PuntosCargados.Select(p => p[0]).Distinct().Count() == 1)
                return ("", 0, "Todos los valores de X son iguales. No se puede calcular una regresión lineal.");

            double sumX = 0, sumY = 0, sumXY = 0, sumX2 = 0;
            foreach (var p in PuntosCargados)
            {
                sumX += p[0]; sumY += p[1];
                sumXY += p[0] * p[1];
                sumX2 += p[0] * p[0];
            }

            double a1 = (n * sumXY - sumX * sumY) / (n * sumX2 - sumX * sumX);
            double a0 = (sumY / n) - a1 * (sumX / n);

            double st = 0, sr = 0;
            foreach (var p in PuntosCargados)
            {
                st += Math.Pow(p[1] - (sumY / n), 2);
                sr += Math.Pow((a1 * p[0] + a0) - p[1], 2);
            }

            double rLinear = Math.Sqrt((st - sr) / st) * 100;
            if (double.IsNaN(rLinear)) rLinear = 0;

            var efectividadLineal = double.IsNaN(rLinear)
                ? "Varianza de Y nula. No se puede calcular el coeficiente de correlación, pero el ajuste es válido."
                : (rLinear >= tolerancia * 100 ? "El ajuste es aceptable." : "El ajuste no es aceptable.");

            string funcionLineal = $"{a1:0.###}*x+{a0:0.###}";
            return (funcionLineal, rLinear, efectividadLineal);
        }
        private double[,] GenerarMatrizPolinomial(int grado, List<double[]> puntos)
        {
            int dim = grado + 1;
            double[,] matriz = new double[dim, dim + 1];

            foreach (var punto in puntos)
            {
                double x = punto[0], y = punto[1];
                for (int fila = 0; fila < dim; fila++)
                {
                    for (int col = 0; col < dim; col++)
                        matriz[fila, col] += Math.Pow(x, fila + col);
                    matriz[fila, dim] += y * Math.Pow(x, fila);
                }
            }

            return matriz;
        }

        private double[] ResolverGaussJordan(double[,] matriz)
        {
            int n = matriz.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                double diag = matriz[i, i];
                for (int j = 0; j <= n; j++)
                    matriz[i, j] /= diag;

                for (int k = 0; k < n; k++)
                {
                    if (i == k) continue;
                    double factor = matriz[k, i];
                    for (int j = 0; j <= n; j++)
                        matriz[k, j] -= factor * matriz[i, j];
                }
            }

            double[] resultado = new double[n];
            for (int i = 0; i < n; i++)
                resultado[i] = matriz[i, n];

            return resultado;
        }

        private string ArmarFuncionPolinomial(double[] coef)
        {
            string funcion = "", signo = "";
            for (int i = 0; i < coef.Length; i++)
            {
                double a = Math.Round(coef[i], 4);
                if (a == 0) continue;
                string termino = i switch
                {
                    0 => $"{a}",
                    1 => $"{a}x",
                    _ => $"{a}x^{i}"
                };
                funcion = termino + (signo + funcion);
                signo = a > 0 ? "+" : "";
            }
            return "y = " + funcion;
        }

        private double CalcularCorrelacion(double[] coef, List<double[]> puntos)
        {
            double sumY = puntos.Sum(p => p[1]);
            double mediaY = sumY / puntos.Count;
            double sr = 0, st = 0;

            foreach (var punto in puntos)
            {
                double estimado = 0;
                for (int i = 0; i < coef.Length; i++)
                    estimado += coef[i] * Math.Pow(punto[0], i);

                sr += Math.Pow(estimado - punto[1], 2);
                st += Math.Pow(mediaY - punto[1], 2);
            }

            return Math.Sqrt((st - sr) / st) * 100;
        }
        private void btnCargarPuntos_Click(object sender, EventArgs e)
        {

        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }
        private void SetPanelGrafica()
        {
            panelGrafica.Controls.Clear();
            graficador = new Graficador();
            panelGrafica.Controls.Add(graficador);
            graficador.Dock = DockStyle.Fill;
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            var (funcion, r, mensaje) = Calcular();
            labelFuncionObtenida.Text = funcion;
            labelCorrelacion.Text = $"{r:0.##}%";
            labelEfectividadAjuste.Text = mensaje;

            SetPanelGrafica();
            graficador.Graficar(PuntosCargados, funcion);
        }

        private void btnCargarPuntos_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCargarPuntos_Click_2(object sender, EventArgs e)
        {
            if (double.TryParse(txtPuntoX.Text, out double x) && double.TryParse(txtPuntoY.Text, out double y))
            {
                double[] punto = { x, y };
                PuntosCargados.Add(punto);

                Label lbl = new Label();
                lbl.Text = $"({x}, {y})";
                lbl.Location = new Point(0, (PuntosCargados.Count - 1) * 20);
                lbl.AutoSize = true;
                panelPuntos.Controls.Add(lbl);

                txtPuntoX.Clear(); txtPuntoY.Clear();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            txtTolerancia.Text = "0.8"; // Valor por defecto de tolerancia
            cBoxMetodo.Items.Add("Regresión Lineal");
            cBoxMetodo.Items.Add("Regresión Polinomial");
        }

        private void cBoxMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
