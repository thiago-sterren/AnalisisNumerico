namespace AnalisisNumerico.Unidad1
{
    partial class Biseccion
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
            btnCalcular = new Button();
            txtFuncion = new TextBox();
            txtXI = new TextBox();
            txtXD = new TextBox();
            txtTolerancia = new TextBox();
            txtIteraciones = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(285, 305);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtFuncion
            // 
            txtFuncion.Location = new Point(172, 48);
            txtFuncion.Name = "txtFuncion";
            txtFuncion.Size = new Size(240, 27);
            txtFuncion.TabIndex = 1;
            // 
            // txtXI
            // 
            txtXI.Location = new Point(172, 110);
            txtXI.Name = "txtXI";
            txtXI.Size = new Size(125, 27);
            txtXI.TabIndex = 2;
            // 
            // txtXD
            // 
            txtXD.Location = new Point(332, 110);
            txtXD.Name = "txtXD";
            txtXD.Size = new Size(125, 27);
            txtXD.TabIndex = 3;
            // 
            // txtTolerancia
            // 
            txtTolerancia.Location = new Point(172, 174);
            txtTolerancia.Name = "txtTolerancia";
            txtTolerancia.Size = new Size(125, 27);
            txtTolerancia.TabIndex = 4;
            // 
            // txtIteraciones
            // 
            txtIteraciones.Location = new Point(172, 235);
            txtIteraciones.Name = "txtIteraciones";
            txtIteraciones.Size = new Size(125, 27);
            txtIteraciones.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 25);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 6;
            label1.Text = "Función:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 87);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 7;
            label2.Text = "Límite izquierdo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(332, 87);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 8;
            label3.Text = "Límite derecho:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(172, 151);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 9;
            label4.Text = "Tolerancia:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(172, 212);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 10;
            label5.Text = "Iteraciones:";
            // 
            // Biseccion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtIteraciones);
            Controls.Add(txtTolerancia);
            Controls.Add(txtXD);
            Controls.Add(txtXI);
            Controls.Add(txtFuncion);
            Controls.Add(btnCalcular);
            Name = "Biseccion";
            Text = "Biseccion";
            Load += Biseccion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private TextBox txtFuncion;
        private TextBox txtXI;
        private TextBox txtXD;
        private TextBox txtTolerancia;
        private TextBox txtIteraciones;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}