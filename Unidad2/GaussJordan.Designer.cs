namespace AnalisisNumerico.Unidad2
{
    partial class GaussJordan
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
            groupBoxMatriz = new GroupBox();
            btnGenerarMatriz = new Button();
            txtDimension = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(304, 97);
            btnCalcular.Margin = new Padding(3, 4, 3, 4);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(86, 31);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // groupBoxMatriz
            // 
            groupBoxMatriz.Location = new Point(304, 145);
            groupBoxMatriz.Margin = new Padding(3, 4, 3, 4);
            groupBoxMatriz.Name = "groupBoxMatriz";
            groupBoxMatriz.Padding = new Padding(3, 4, 3, 4);
            groupBoxMatriz.Size = new Size(709, 404);
            groupBoxMatriz.TabIndex = 8;
            groupBoxMatriz.TabStop = false;
            groupBoxMatriz.Text = "Matriz";
            // 
            // btnGenerarMatriz
            // 
            btnGenerarMatriz.Location = new Point(775, 58);
            btnGenerarMatriz.Margin = new Padding(3, 4, 3, 4);
            btnGenerarMatriz.Name = "btnGenerarMatriz";
            btnGenerarMatriz.Size = new Size(86, 31);
            btnGenerarMatriz.TabIndex = 7;
            btnGenerarMatriz.Text = "Generar";
            btnGenerarMatriz.UseVisualStyleBackColor = true;
            btnGenerarMatriz.Click += btnGenerarMatriz_Click;
            // 
            // txtDimension
            // 
            txtDimension.Location = new Point(559, 60);
            txtDimension.Margin = new Padding(3, 4, 3, 4);
            txtDimension.Name = "txtDimension";
            txtDimension.Size = new Size(114, 27);
            txtDimension.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(304, 65);
            label1.Name = "label1";
            label1.Size = new Size(249, 20);
            label1.TabIndex = 5;
            label1.Text = "Cantidad de elementos de la matriz:";
            // 
            // GaussJordan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1321, 477);
            Controls.Add(btnCalcular);
            Controls.Add(groupBoxMatriz);
            Controls.Add(btnGenerarMatriz);
            Controls.Add(txtDimension);
            Controls.Add(label1);
            Name = "GaussJordan";
            Text = "GaussJordan";
            Load += GaussJordan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private GroupBox groupBoxMatriz;
        private Button btnGenerarMatriz;
        private TextBox txtDimension;
        private Label label1;
    }
}