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
    public partial class GaussJordan : Form
    {
        private int dimension;
        private double[,] matriz;
        public GaussJordan()
        {
            InitializeComponent();
        }

        private void btnGenerarMatriz_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDimension.Text, out dimension))
            {
                MessageBox.Show("Error");
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
        }

        private void GaussJordan_Load(object sender, EventArgs e)
        {
            txtDimension.Text = "3";

            groupBoxMatriz.Controls.Clear();

            txtDimension.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            matriz = GuardarMatriz(dimension);
            if (matriz == null)
            {
                MessageBox.Show("Error");
                return;
            }

            double[] vectorResultado = MetodoGaussJordan(dimension, matriz);

            string resultados = "";
            for (int i = 0; i < dimension; i++)
            {
                resultados += $"x{i + 1} = {vectorResultado[i]:F6}\n";
            }
            MessageBox.Show(resultados, "Resultados Gauss-Jordan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private double[] MetodoGaussJordan(int dimension, double[,] matriz)
        {
            double[,] matrizAugmentada = (double[,])matriz.Clone();

            for (int diag = 0; diag < dimension; diag++)
            {
                double pivot = matrizAugmentada[diag, diag];
                for (int col = 0; col < dimension + 1; col++)
                {
                    matrizAugmentada[diag, col] /= pivot;
                }

                for (int row = 0; row < dimension; row++)
                {
                    if (row != diag)
                    {
                        double factor = matrizAugmentada[row, diag];
                        for (int col = 0; col < dimension + 1; col++)
                        {
                            matrizAugmentada[row, col] -= factor * matrizAugmentada[diag, col];
                        }
                    }
                }
            }

            double[] vectorResultado = new double[dimension];
            for (int i = 0; i < dimension; i++)
            {
                vectorResultado[i] = matrizAugmentada[i, dimension];
            }

            return vectorResultado;
        }
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
                        return null;
                    }
                    matriz[row, col] = numero;
                }
            }
            return matriz;
        }
    }
}
