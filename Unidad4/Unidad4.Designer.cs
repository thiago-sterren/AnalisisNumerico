namespace AnalisisNumericoTP4
{
    partial class Unidad4
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
            textBoxFunction = new TextBox();
            textBoxXi = new TextBox();
            textBoxXd = new TextBox();
            textBoxN = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            CalculateTrapezoidalSimple = new Button();
            CalculateTrapezoidalMultiple = new Button();
            CalculateSimpson13Simple = new Button();
            CalculateSimpson13Multiple = new Button();
            CalculateSimpson38 = new Button();
            CalculateCombined = new Button();
            SuspendLayout();
            // 
            // textBoxFunction
            // 
            textBoxFunction.Location = new Point(67, 54);
            textBoxFunction.Margin = new Padding(3, 4, 3, 4);
            textBoxFunction.Name = "textBoxFunction";
            textBoxFunction.Size = new Size(228, 27);
            textBoxFunction.TabIndex = 0;
            // 
            // textBoxXi
            // 
            textBoxXi.Location = new Point(307, 54);
            textBoxXi.Margin = new Padding(3, 4, 3, 4);
            textBoxXi.Name = "textBoxXi";
            textBoxXi.Size = new Size(114, 27);
            textBoxXi.TabIndex = 1;
            // 
            // textBoxXd
            // 
            textBoxXd.Location = new Point(433, 54);
            textBoxXd.Margin = new Padding(3, 4, 3, 4);
            textBoxXd.Name = "textBoxXd";
            textBoxXd.Size = new Size(114, 27);
            textBoxXd.TabIndex = 2;
            // 
            // textBoxN
            // 
            textBoxN.Location = new Point(558, 54);
            textBoxN.Margin = new Padding(3, 4, 3, 4);
            textBoxN.Name = "textBoxN";
            textBoxN.Size = new Size(114, 27);
            textBoxN.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 28);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 4;
            label1.Text = "Funcion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 28);
            label2.Name = "label2";
            label2.Size = new Size(22, 20);
            label2.TabIndex = 5;
            label2.Text = "Xi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(433, 28);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 6;
            label3.Text = "Xd";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(558, 28);
            label4.Name = "label4";
            label4.Size = new Size(20, 20);
            label4.TabIndex = 7;
            label4.Text = "N";
            // 
            // CalculateTrapezoidalSimple
            // 
            CalculateTrapezoidalSimple.Location = new Point(50, 133);
            CalculateTrapezoidalSimple.Margin = new Padding(3, 4, 3, 4);
            CalculateTrapezoidalSimple.Name = "CalculateTrapezoidalSimple";
            CalculateTrapezoidalSimple.Size = new Size(171, 53);
            CalculateTrapezoidalSimple.TabIndex = 8;
            CalculateTrapezoidalSimple.Text = "Calcular Integral Trapecio Simple";
            CalculateTrapezoidalSimple.UseVisualStyleBackColor = true;
            CalculateTrapezoidalSimple.Click += CalculateTrapezoidalSimple_Click;
            // 
            // CalculateTrapezoidalMultiple
            // 
            CalculateTrapezoidalMultiple.Location = new Point(285, 133);
            CalculateTrapezoidalMultiple.Margin = new Padding(3, 4, 3, 4);
            CalculateTrapezoidalMultiple.Name = "CalculateTrapezoidalMultiple";
            CalculateTrapezoidalMultiple.Size = new Size(171, 53);
            CalculateTrapezoidalMultiple.TabIndex = 9;
            CalculateTrapezoidalMultiple.Text = "Calcular Integral Trapecio Multiple";
            CalculateTrapezoidalMultiple.UseVisualStyleBackColor = true;
            CalculateTrapezoidalMultiple.Click += CalculateTrapezoidalMultiple_Click_1;
            // 
            // CalculateSimpson13Simple
            // 
            CalculateSimpson13Simple.Location = new Point(514, 133);
            CalculateSimpson13Simple.Margin = new Padding(3, 4, 3, 4);
            CalculateSimpson13Simple.Name = "CalculateSimpson13Simple";
            CalculateSimpson13Simple.Size = new Size(171, 53);
            CalculateSimpson13Simple.TabIndex = 10;
            CalculateSimpson13Simple.Text = "Calcular Integral Simpson 1-3 Simple";
            CalculateSimpson13Simple.UseVisualStyleBackColor = true;
            CalculateSimpson13Simple.Click += CalculateSimpson13Simple_Click_1;
            // 
            // CalculateSimpson13Multiple
            // 
            CalculateSimpson13Multiple.Location = new Point(50, 200);
            CalculateSimpson13Multiple.Margin = new Padding(3, 4, 3, 4);
            CalculateSimpson13Multiple.Name = "CalculateSimpson13Multiple";
            CalculateSimpson13Multiple.Size = new Size(171, 53);
            CalculateSimpson13Multiple.TabIndex = 11;
            CalculateSimpson13Multiple.Text = "Calcular Integral Simpson 1-3 Multiple";
            CalculateSimpson13Multiple.UseVisualStyleBackColor = true;
            CalculateSimpson13Multiple.Click += CalculateSimpson13Multiple_Click_1;
            // 
            // CalculateSimpson38
            // 
            CalculateSimpson38.Location = new Point(285, 200);
            CalculateSimpson38.Margin = new Padding(3, 4, 3, 4);
            CalculateSimpson38.Name = "CalculateSimpson38";
            CalculateSimpson38.Size = new Size(171, 53);
            CalculateSimpson38.TabIndex = 12;
            CalculateSimpson38.Text = "Calcular Integral Simpson 3-8";
            CalculateSimpson38.UseVisualStyleBackColor = true;
            CalculateSimpson38.Click += CalculateSimpson38_Click_1;
            // 
            // CalculateCombined
            // 
            CalculateCombined.Location = new Point(514, 200);
            CalculateCombined.Margin = new Padding(3, 4, 3, 4);
            CalculateCombined.Name = "CalculateCombined";
            CalculateCombined.Size = new Size(171, 53);
            CalculateCombined.TabIndex = 13;
            CalculateCombined.Text = "Calcular Combinado (Simpson 1-3 and 3-8)";
            CalculateCombined.UseVisualStyleBackColor = true;
            CalculateCombined.Click += CalculateCombined_Click_1;
            // 
            // Unidad4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 748);
            Controls.Add(CalculateCombined);
            Controls.Add(CalculateSimpson38);
            Controls.Add(CalculateSimpson13Multiple);
            Controls.Add(CalculateSimpson13Simple);
            Controls.Add(CalculateTrapezoidalMultiple);
            Controls.Add(CalculateTrapezoidalSimple);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxN);
            Controls.Add(textBoxXd);
            Controls.Add(textBoxXi);
            Controls.Add(textBoxFunction);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Unidad4";
            Text = "Unidad4";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFunction;
        private TextBox textBoxXi;
        private TextBox textBoxXd;
        private TextBox textBoxN;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button CalculateTrapezoidalSimple;
        private Button CalculateTrapezoidalMultiple;
        private Button CalculateSimpson13Simple;
        private Button CalculateSimpson13Multiple;
        private Button CalculateSimpson38;
        private Button CalculateCombined;
    }
}