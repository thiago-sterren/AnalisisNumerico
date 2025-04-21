namespace AnalisisNumerico.Unidad1
{
    partial class Unidad1
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
            label1 = new Label();
            label2 = new Label();
            btnBiseccion = new Button();
            btnReglaFalsa = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(467, 146);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 0;
            label1.Text = "Métodos abiertos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 146);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 1;
            label2.Text = "Métodos cerrados";
            // 
            // btnBiseccion
            // 
            btnBiseccion.Location = new Point(133, 192);
            btnBiseccion.Name = "btnBiseccion";
            btnBiseccion.Size = new Size(94, 44);
            btnBiseccion.TabIndex = 2;
            btnBiseccion.Text = "Bisección";
            btnBiseccion.UseVisualStyleBackColor = true;
            btnBiseccion.Click += btnBiseccion_Click;
            // 
            // btnReglaFalsa
            // 
            btnReglaFalsa.Location = new Point(254, 192);
            btnReglaFalsa.Name = "btnReglaFalsa";
            btnReglaFalsa.Size = new Size(94, 44);
            btnReglaFalsa.TabIndex = 3;
            btnReglaFalsa.Text = "Regla falsa";
            btnReglaFalsa.UseVisualStyleBackColor = true;
            btnReglaFalsa.Click += btnReglaFalsa_Click;
            // 
            // button1
            // 
            button1.Location = new Point(450, 192);
            button1.Name = "button1";
            button1.Size = new Size(94, 44);
            button1.TabIndex = 4;
            button1.Text = "Tangente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(572, 192);
            button2.Name = "button2";
            button2.Size = new Size(94, 44);
            button2.TabIndex = 5;
            button2.Text = "Secante";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Unidad1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnReglaFalsa);
            Controls.Add(btnBiseccion);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Unidad1";
            Text = "Unidad1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnBiseccion;
        private Button btnReglaFalsa;
        private Button button1;
        private Button button2;
    }
}