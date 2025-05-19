using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalisisNumerico.Unidad2
{
    public partial class GaussSeidel : Form
    {
        private double[,] GuardarMatriz(int dimension)
        {
            double[,] matriz = new double[dimension, dimension + 1];

            for (int row = 0; row < dimension; row++)
            {
                for (int col = 0; col < dimension + 1; col++)
                {
                    Control textBox = groupBoxMatriz.Controls.Find($"({row},{col})", true).First();
                    if (!double.TryParse((textBox as TextBox).Text, out double numero))
                    {
                        MessageBox.Show($"Error en la entrada ({row},{col}): no es un número válido", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                    matriz[row, col] = numero;
                }
            }
            return matriz;
        }

        private double[] MetodoGaussSeidel(int dimension, double[,] matriz, double tolerancia, int iteracionesMaximas)
        {
            bool esSolucion = false;
            int contador = 0;
            vectorResultado = new double[dimension];
            vectorAnterior = new double[dimension];

            while (contador < iteracionesMaximas && !esSolucion)
            {
                if (contador > 0)
                {
                    vectorResultado.CopyTo(vectorAnterior, 0);
                }

                for (int row = 0; row < dimension; row++)
                {
                    double resultado = matriz[row, dimension];
                    for (int col = 0; col < dimension; col++)
                    {
                        if (row != col)
                        {
                            resultado -= matriz[row, col] * vectorResultado[col];
                        }
                    }
                    double coeficienteIncognita = resultado / matriz[row, row];
                    vectorResultado[row] = coeficienteIncognita;
                }

                int contadorMismoResultado = 0;
                for (int i = 0; i < dimension; i++)
                {
                    double errorRelativo = (vectorResultado[i] != 0)
                        ? Math.Abs((vectorResultado[i] - vectorAnterior[i]) / vectorResultado[i])
                        : Math.Abs(vectorResultado[i] - vectorAnterior[i]);
                    if (errorRelativo < tolerancia)
                    {
                        contadorMismoResultado++;
                    }
                }

                esSolucion = (contadorMismoResultado == dimension);
                contador++;
            }

            if (contador >= iteracionesMaximas)
            {
                MessageBox.Show("Se superó el número de iteraciones máximas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return vectorResultado;
        }
        private int dimension;
        private double[,] matriz;
        private double[] vectorResultado;
        private double[] vectorAnterior;
        public GaussSeidel()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDimension.Text, out dimension))
            {
                MessageBox.Show("Indique una dimensión válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            groupBoxMatriz.Controls.Clear();
            int puntoX = 30, puntoY = 30;

            for (int row = 0; row < dimension; row++)
            {
                for (int col = 0; col < dimension + 1; col++)
                {
                    string nombre = $"({row},{col})";
                    TextBox textBox = new TextBox { Name = nombre, Location = new Point(puntoX, puntoY), Size = new Size(60, 30) };
                    ToolTip toolTip = new ToolTip();
                    toolTip.SetToolTip(textBox, nombre);
                    groupBoxMatriz.Controls.Add(textBox);
                    puntoX += 110;
                }
                puntoX = 30;
                puntoY += 30;
            }

            groupBoxMatriz.Show();
            btnCalcular.Enabled = true;
        }

        private void GaussSeidel_Load(object sender, EventArgs e)
        {
            txtDimension.Text = "3";
            txtTolerancia.Text = "0.0001";
            txtIteraciones.Text = "100";

            groupBoxMatriz.Controls.Clear();

            txtDimension.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {

                if (!double.TryParse(txtTolerancia.Text, out double tolerancia) || tolerancia <= 0)
                {
                    MessageBox.Show("Indique una tolerancia válida mayor que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (!int.TryParse(txtIteraciones.Text, out int iteracionesMaximas) || iteracionesMaximas <= 0)
                {
                    MessageBox.Show("Indique un número válido de iteraciones máximas mayor que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                matriz = GuardarMatriz(dimension);
                if (matriz == null)
                {
                    MessageBox.Show("Error en los datos de entrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                vectorResultado = MetodoGaussSeidel(dimension, matriz, tolerancia, iteracionesMaximas);


                string resultados = "";
                for (int i = 0; i < dimension; i++)
                {
                    resultados += $"x{i + 1} = {vectorResultado[i]:F6}\n";
                }
                MessageBox.Show(resultados, "Resultados Gauss-Seidel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
