namespace AnalisisNumericoTP4
{
    using Calculus; 

    public partial class Unidad4 : Form
    {
        private Calculo analizador; 

        public Unidad4()
        {
            InitializeComponent();
            analizador = new Calculo(); 
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        private double EvaluateFunction(string func, double x)
        {
            try
            {
                if (!analizador.Sintaxis(func, 'x'))
                {
                    throw new Exception("Error en la sintaxis de la función.");
                }
                double result = analizador.EvaluaFx(x);
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Function mal ingresada or invalid input: " + ex.Message);
                return 0;
            }
        }

        private void CalculateTrapezoidalSimple_Click(object sender, EventArgs e)
        {
            try
            {
                string func = textBoxFunction.Text;
                double xi = Convert.ToDouble(textBoxXi.Text);
                double xd = Convert.ToDouble(textBoxXd.Text);

            
                if (!analizador.Sintaxis(func, 'x'))
                {
                    throw new Exception("Error en la sintaxis de la función.");
                }

                double result = (EvaluateFunction(func, xi) + EvaluateFunction(func, xd)) * (xd - xi) / 2;
                MessageBox.Show($"Result: {result}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Function mal ingresada or invalid input: " + ex.Message);
            }
        }

        private void CalculateTrapezoidalMultiple_Click_1(object sender, EventArgs e)
        {
            try
            {
                string func = textBoxFunction.Text;
                double xi = Convert.ToDouble(textBoxXi.Text);
                double xd = Convert.ToDouble(textBoxXd.Text);
                int n = Convert.ToInt32(textBoxN.Text);

               
                if (!analizador.Sintaxis(func, 'x'))
                {
                    throw new Exception("Error en la sintaxis de la función.");
                }

                double h = (xd - xi) / n;
                double sum = 0;
                for (int i = 1; i < n; i++)
                {
                    sum += EvaluateFunction(func, xi + i * h);
                }
                double result = (h / 2) * (EvaluateFunction(func, xi) + 2 * sum + EvaluateFunction(func, xd));
                MessageBox.Show($"Result: {result}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Function mal ingresada or invalid input: " + ex.Message);
            }
        }

        private void CalculateSimpson13Simple_Click_1(object sender, EventArgs e)
        {
            try
            {
                string func = textBoxFunction.Text;
                double xi = Convert.ToDouble(textBoxXi.Text);
                double xd = Convert.ToDouble(textBoxXd.Text);

                // Verificar sintaxis
                if (!analizador.Sintaxis(func, 'x'))
                {
                    throw new Exception("Error en la sintaxis de la función.");
                }

                double h = (xd - xi) / 2;
                double result = (h / 3) * (EvaluateFunction(func, xi) + 4 * EvaluateFunction(func, xi + h) + EvaluateFunction(func, xd));
                MessageBox.Show($"Result: {result}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Function mal ingresada or invalid input: " + ex.Message);
            }
        }

        private void CalculateSimpson13Multiple_Click_1(object sender, EventArgs e)
        {
            try
            {
                string func = textBoxFunction.Text;
                double xi = Convert.ToDouble(textBoxXi.Text);
                double xd = Convert.ToDouble(textBoxXd.Text);
                int n = Convert.ToInt32(textBoxN.Text);

              
                if (n % 2 != 0)
                {
                    throw new Exception("El número de intervalos (n) debe ser par para Simpson 1/3 múltiple.");
                }

               
                if (!analizador.Sintaxis(func, 'x'))
                {
                    throw new Exception("Error en la sintaxis de la función.");
                }

                double h = (xd - xi) / n;
                double sumPares = 0, sumImpares = 0;

                for (int i = 1; i < n; i++)
                {
                    double x = xi + i * h;
                    double fx = EvaluateFunction(func, x);
                    if (i % 2 == 0) sumPares += fx;
                    else sumImpares += fx;
                }

                double fx0 = EvaluateFunction(func, xi);
                double fxn = EvaluateFunction(func, xd);
                double result = (h / 3) * (fx0 + 4 * sumImpares + 2 * sumPares + fxn);
                MessageBox.Show($"Result: {result}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Function mal ingresada or invalid input: " + ex.Message);
            }
        }

        private void CalculateSimpson38_Click_1(object sender, EventArgs e)
        {
            try
            {
                string func = textBoxFunction.Text;
                double xi = Convert.ToDouble(textBoxXi.Text);
                double xd = Convert.ToDouble(textBoxXd.Text);

               
                if (!analizador.Sintaxis(func, 'x'))
                {
                    throw new Exception("Error en la sintaxis de la función.");
                }

                double h = (xd - xi) / 3;
                double result = (3 * h / 8) * (EvaluateFunction(func, xi) + 3 * EvaluateFunction(func, xi + h) +
                    3 * EvaluateFunction(func, xi + 2 * h) + EvaluateFunction(func, xd));
                MessageBox.Show($"Result: {result}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Function mal ingresada or invalid input: " + ex.Message);
            }
        }

        private void CalculateCombined_Click_1(object sender, EventArgs e)
        {
            try
            {
                string func = textBoxFunction.Text;
                double xi = Convert.ToDouble(textBoxXi.Text);
                double xd = Convert.ToDouble(textBoxXd.Text);
                int n = Convert.ToInt32(textBoxN.Text);

                
                if (!analizador.Sintaxis(func, 'x'))
                {
                    throw new Exception("Error en la sintaxis de la función.");
                }

                double h = (xd - xi) / n;
                double resultado = 0; 
                bool simpson3_8Hecho = false; 

                if (n % 2 == 1 && n >= 3)
                {
                    double x1 = xi + h;
                    double x2 = xi + 2 * h;
                    double x3 = xi + 3 * h;
                    resultado = (3 * h / 8) * (EvaluateFunction(func, xi) + 3 * EvaluateFunction(func, x1) +
                        3 * EvaluateFunction(func, x2) + EvaluateFunction(func, x3));
                    xi = x3; 
                    n -= 3; 
                    h = (xd - xi) / n; 
                    simpson3_8Hecho = true;
                }

               
                if (n > 0 && n % 2 == 0) 
                {
                    double sumImpares = 0, sumPares = 0;
                    for (int i = 1; i < n; i++)
                    {
                        double x = xi + i * h;
                        double fx = EvaluateFunction(func, x);
                        if (i % 2 == 0) sumPares += fx;
                        else sumImpares += fx;
                    }
                    resultado += (h / 3) * (EvaluateFunction(func, xi) + 4 * sumImpares + 2 * sumPares + EvaluateFunction(func, xd));
                }

                MessageBox.Show($"Result: {resultado}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Function mal ingresada or invalid input: " + ex.Message);
            }
        }
    }
}