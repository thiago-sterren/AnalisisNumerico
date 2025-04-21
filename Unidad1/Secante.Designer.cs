namespace AnalisisNumerico.Unidad1
{
    partial class Secante
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtIteraciones = new TextBox();
            txtTolerancia = new TextBox();
            txtXD = new TextBox();
            txtXI = new TextBox();
            txtFuncion = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(258, 258);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 32;
            label5.Text = "Iteraciones:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(258, 197);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 31;
            label4.Text = "Tolerancia:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(418, 133);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 30;
            label3.Text = "Segundo punto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(258, 133);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 29;
            label2.Text = "Primer punto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(258, 71);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 28;
            label1.Text = "Función:";
            // 
            // txtIteraciones
            // 
            txtIteraciones.Location = new Point(258, 281);
            txtIteraciones.Name = "txtIteraciones";
            txtIteraciones.Size = new Size(125, 27);
            txtIteraciones.TabIndex = 27;
            // 
            // txtTolerancia
            // 
            txtTolerancia.Location = new Point(258, 220);
            txtTolerancia.Name = "txtTolerancia";
            txtTolerancia.Size = new Size(125, 27);
            txtTolerancia.TabIndex = 26;
            // 
            // txtXD
            // 
            txtXD.Location = new Point(418, 156);
            txtXD.Name = "txtXD";
            txtXD.Size = new Size(125, 27);
            txtXD.TabIndex = 25;
            // 
            // txtXI
            // 
            txtXI.Location = new Point(258, 156);
            txtXI.Name = "txtXI";
            txtXI.Size = new Size(125, 27);
            txtXI.TabIndex = 24;
            // 
            // txtFuncion
            // 
            txtFuncion.Location = new Point(258, 94);
            txtFuncion.Name = "txtFuncion";
            txtFuncion.Size = new Size(125, 27);
            txtFuncion.TabIndex = 23;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(371, 351);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 22;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Secante
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
            Name = "Secante";
            Text = "Secante";
            Load += Secante_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtIteraciones;
        private TextBox txtTolerancia;
        private TextBox txtXD;
        private TextBox txtXI;
        private TextBox txtFuncion;
        private Button btnCalcular;
    }
}