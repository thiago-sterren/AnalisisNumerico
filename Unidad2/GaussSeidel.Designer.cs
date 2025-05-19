namespace AnalisisNumerico.Unidad2
{
    partial class GaussSeidel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            label2 = new Label();
            txtTolerancia = new TextBox();
            txtIteraciones = new TextBox();
            btnCalcular = new Button();
            groupBoxMatriz = new GroupBox();
            btnGenerar = new Button();
            txtDimension = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 61);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 17;
            label3.Text = "Tolerancia:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(404, 61);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 16;
            label2.Text = "Iteraciones:";
            // 
            // txtTolerancia
            // 
            txtTolerancia.Location = new Point(188, 57);
            txtTolerancia.Margin = new Padding(3, 4, 3, 4);
            txtTolerancia.Name = "txtTolerancia";
            txtTolerancia.Size = new Size(114, 27);
            txtTolerancia.TabIndex = 15;
            // 
            // txtIteraciones
            // 
            txtIteraciones.Location = new Point(487, 57);
            txtIteraciones.Margin = new Padding(3, 4, 3, 4);
            txtIteraciones.Name = "txtIteraciones";
            txtIteraciones.Size = new Size(114, 27);
            txtIteraciones.TabIndex = 14;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(84, 138);
            btnCalcular.Margin = new Padding(3, 4, 3, 4);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(86, 31);
            btnCalcular.TabIndex = 13;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // groupBoxMatriz
            // 
            groupBoxMatriz.Location = new Point(81, 186);
            groupBoxMatriz.Margin = new Padding(3, 4, 3, 4);
            groupBoxMatriz.Name = "groupBoxMatriz";
            groupBoxMatriz.Padding = new Padding(3, 4, 3, 4);
            groupBoxMatriz.Size = new Size(650, 357);
            groupBoxMatriz.TabIndex = 12;
            groupBoxMatriz.TabStop = false;
            groupBoxMatriz.Text = "Matriz";
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(542, 103);
            btnGenerar.Margin = new Padding(3, 4, 3, 4);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(86, 31);
            btnGenerar.TabIndex = 11;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // txtDimension
            // 
            txtDimension.Location = new Point(339, 105);
            txtDimension.Margin = new Padding(3, 4, 3, 4);
            txtDimension.Name = "txtDimension";
            txtDimension.Size = new Size(114, 27);
            txtDimension.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 108);
            label1.Name = "label1";
            label1.Size = new Size(249, 20);
            label1.TabIndex = 9;
            label1.Text = "Cantidad de elementos de la matriz:";
            // 
            // GaussSeidel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTolerancia);
            Controls.Add(txtIteraciones);
            Controls.Add(btnCalcular);
            Controls.Add(groupBoxMatriz);
            Controls.Add(btnGenerar);
            Controls.Add(txtDimension);
            Controls.Add(label1);
            Name = "GaussSeidel";
            Text = "GaussSeidel";
            Load += GaussSeidel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private TextBox txtTolerancia;
        private TextBox txtIteraciones;
        private Button btnCalcular;
        private GroupBox groupBoxMatriz;
        private Button btnGenerar;
        private TextBox txtDimension;
        private Label label1;
    }
}