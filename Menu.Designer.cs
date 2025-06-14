namespace AnalisisNumerico
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnUnidad1 = new Button();
            btnUnidad2 = new Button();
            btnUnidad3 = new Button();
            btnUnidad4 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnUnidad1
            // 
            btnUnidad1.Location = new Point(227, 156);
            btnUnidad1.Name = "btnUnidad1";
            btnUnidad1.Size = new Size(336, 29);
            btnUnidad1.TabIndex = 0;
            btnUnidad1.Text = "Unidad 1 - Raíces de funciones";
            btnUnidad1.UseVisualStyleBackColor = true;
            btnUnidad1.Click += button1_Click;
            // 
            // btnUnidad2
            // 
            btnUnidad2.Location = new Point(227, 191);
            btnUnidad2.Name = "btnUnidad2";
            btnUnidad2.Size = new Size(336, 29);
            btnUnidad2.TabIndex = 1;
            btnUnidad2.Text = "Unidad 2 - Sistemas de ecuaciones";
            btnUnidad2.UseVisualStyleBackColor = true;
            btnUnidad2.Click += btnUnidad2_Click;
            // 
            // btnUnidad3
            // 
            btnUnidad3.Location = new Point(227, 226);
            btnUnidad3.Name = "btnUnidad3";
            btnUnidad3.Size = new Size(336, 29);
            btnUnidad3.TabIndex = 2;
            btnUnidad3.Text = "Unidad 3 - Ajustes de curvas";
            btnUnidad3.UseVisualStyleBackColor = true;
            btnUnidad3.Click += btnUnidad3_Click;
            // 
            // btnUnidad4
            // 
            btnUnidad4.Location = new Point(227, 261);
            btnUnidad4.Name = "btnUnidad4";
            btnUnidad4.Size = new Size(336, 29);
            btnUnidad4.TabIndex = 3;
            btnUnidad4.Text = "Unidad 4 - Integración numérica";
            btnUnidad4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(282, 89);
            label1.Name = "label1";
            label1.Size = new Size(220, 20);
            label1.TabIndex = 4;
            label1.Text = "Sistema Análisis Numérico 2025";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnUnidad4);
            Controls.Add(btnUnidad3);
            Controls.Add(btnUnidad2);
            Controls.Add(btnUnidad1);
            Name = "Menu";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUnidad1;
        private Button btnUnidad2;
        private Button btnUnidad3;
        private Button btnUnidad4;
        private Label label1;
    }
}
