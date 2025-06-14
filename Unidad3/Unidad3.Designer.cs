namespace AnalisisNumerico.Unidad3
{
    partial class Unidad3
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
            groupBox2 = new GroupBox();
            panelGrafica = new Panel();
            labelEfectividadAjuste = new Label();
            label8 = new Label();
            labelCorrelacion = new Label();
            label6 = new Label();
            labelFuncionObtenida = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            panelPuntos = new Panel();
            label4 = new Label();
            btnCalcular = new Button();
            cBoxMetodo = new ComboBox();
            label3 = new Label();
            txtTolerancia = new TextBox();
            label2 = new Label();
            btnCargarPuntos = new Button();
            txtPuntoY = new TextBox();
            txtPuntoX = new TextBox();
            label1 = new Label();
            label7 = new Label();
            txtGrado = new TextBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panelGrafica);
            groupBox2.Controls.Add(labelEfectividadAjuste);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(labelCorrelacion);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(labelFuncionObtenida);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(747, 17);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(612, 472);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos de salida";
            // 
            // panelGrafica
            // 
            panelGrafica.Location = new Point(70, 176);
            panelGrafica.Name = "panelGrafica";
            panelGrafica.Size = new Size(381, 250);
            panelGrafica.TabIndex = 7;
            // 
            // labelEfectividadAjuste
            // 
            labelEfectividadAjuste.AutoSize = true;
            labelEfectividadAjuste.Location = new Point(185, 97);
            labelEfectividadAjuste.Name = "labelEfectividadAjuste";
            labelEfectividadAjuste.Size = new Size(157, 20);
            labelEfectividadAjuste.TabIndex = 6;
            labelEfectividadAjuste.Text = "labelEfectividadAjuste";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 97);
            label8.Name = "label8";
            label8.Size = new Size(156, 20);
            label8.TabIndex = 5;
            label8.Text = "Efectividad del Ajuste:";
            // 
            // labelCorrelacion
            // 
            labelCorrelacion.AutoSize = true;
            labelCorrelacion.Location = new Point(183, 68);
            labelCorrelacion.Name = "labelCorrelacion";
            labelCorrelacion.Size = new Size(118, 20);
            labelCorrelacion.TabIndex = 4;
            labelCorrelacion.Text = "labelCorrelacion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(70, 68);
            label6.Name = "label6";
            label6.Size = new Size(107, 20);
            label6.TabIndex = 3;
            label6.Text = "Correlación (r):";
            // 
            // labelFuncionObtenida
            // 
            labelFuncionObtenida.AutoSize = true;
            labelFuncionObtenida.Location = new Point(183, 40);
            labelFuncionObtenida.Name = "labelFuncionObtenida";
            labelFuncionObtenida.Size = new Size(155, 20);
            labelFuncionObtenida.TabIndex = 2;
            labelFuncionObtenida.Text = "labelFuncionObtenida";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 40);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 1;
            label5.Text = "Función Obtenida:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtGrado);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(panelPuntos);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnCalcular);
            groupBox1.Controls.Add(cBoxMetodo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTolerancia);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnCargarPuntos);
            groupBox1.Controls.Add(txtPuntoY);
            groupBox1.Controls.Add(txtPuntoX);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(106, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(635, 472);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de entrada";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // panelPuntos
            // 
            panelPuntos.AutoScroll = true;
            panelPuntos.BackColor = SystemColors.ButtonShadow;
            panelPuntos.Location = new Point(186, 206);
            panelPuntos.Name = "panelPuntos";
            panelPuntos.Size = new Size(120, 250);
            panelPuntos.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 201);
            label4.Name = "label4";
            label4.Size = new Size(132, 20);
            label4.TabIndex = 9;
            label4.Text = "Puntos Ingresados:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(398, 125);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click_1;
            // 
            // cBoxMetodo
            // 
            cBoxMetodo.FormattingEnabled = true;
            cBoxMetodo.Location = new Point(186, 126);
            cBoxMetodo.Name = "cBoxMetodo";
            cBoxMetodo.Size = new Size(206, 28);
            cBoxMetodo.TabIndex = 7;
            cBoxMetodo.SelectedIndexChanged += cBoxMetodo_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 129);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 6;
            label3.Text = "Método a utilizar:";
            // 
            // txtTolerancia
            // 
            txtTolerancia.Location = new Point(186, 81);
            txtTolerancia.Name = "txtTolerancia";
            txtTolerancia.Size = new Size(65, 27);
            txtTolerancia.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 84);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 4;
            label2.Text = "Tolerancia:";
            // 
            // btnCargarPuntos
            // 
            btnCargarPuntos.Location = new Point(398, 37);
            btnCargarPuntos.Name = "btnCargarPuntos";
            btnCargarPuntos.Size = new Size(94, 29);
            btnCargarPuntos.TabIndex = 3;
            btnCargarPuntos.Text = "Cargar";
            btnCargarPuntos.UseVisualStyleBackColor = true;
            btnCargarPuntos.Click += btnCargarPuntos_Click_2;
            // 
            // txtPuntoY
            // 
            txtPuntoY.Location = new Point(257, 37);
            txtPuntoY.Name = "txtPuntoY";
            txtPuntoY.Size = new Size(65, 27);
            txtPuntoY.TabIndex = 2;
            // 
            // txtPuntoX
            // 
            txtPuntoX.Location = new Point(186, 37);
            txtPuntoX.Name = "txtPuntoX";
            txtPuntoX.Size = new Size(65, 27);
            txtPuntoX.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 40);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingresar Punto (X, Y):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 166);
            label7.Name = "label7";
            label7.Size = new Size(128, 20);
            label7.TabIndex = 12;
            label7.Text = "Grado (de 2 a 10):";
            // 
            // txtGrado
            // 
            txtGrado.Location = new Point(186, 163);
            txtGrado.Name = "txtGrado";
            txtGrado.Size = new Size(65, 27);
            txtGrado.TabIndex = 13;
            // 
            // Unidad3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1464, 502);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Unidad3";
            Text = "Unidad3";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Label labelEfectividadAjuste;
        private Label label8;
        private Label labelCorrelacion;
        private Label label6;
        private Label labelFuncionObtenida;
        private Label label5;
        private GroupBox groupBox1;
        private Label label4;
        private Button btnCalcular;
        private ComboBox cBoxMetodo;
        private Label label3;
        private TextBox txtTolerancia;
        private Label label2;
        private Button btnCargarPuntos;
        private TextBox txtPuntoY;
        private TextBox txtPuntoX;
        private Label label1;
        private Panel panelGrafica;
        private Panel panelPuntos;
        private Label label7;
        private TextBox txtGrado;
    }
}