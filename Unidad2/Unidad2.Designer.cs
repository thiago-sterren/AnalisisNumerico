namespace AnalisisNumerico.Unidad2
{
    partial class Unidad2
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
            btnGJ = new Button();
            btnGS = new Button();
            SuspendLayout();
            // 
            // btnGJ
            // 
            btnGJ.Location = new Point(354, 178);
            btnGJ.Name = "btnGJ";
            btnGJ.Size = new Size(135, 29);
            btnGJ.TabIndex = 0;
            btnGJ.Text = "Gauss Jordan";
            btnGJ.UseVisualStyleBackColor = true;
            btnGJ.Click += button1_Click;
            // 
            // btnGS
            // 
            btnGS.Location = new Point(588, 178);
            btnGS.Name = "btnGS";
            btnGS.Size = new Size(135, 29);
            btnGS.TabIndex = 1;
            btnGS.Text = "Gauss Seidel";
            btnGS.UseVisualStyleBackColor = true;
            btnGS.Click += button2_Click;
            // 
            // Unidad2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 498);
            Controls.Add(btnGS);
            Controls.Add(btnGJ);
            Name = "Unidad2";
            Text = "Unidad2";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGJ;
        private Button btnGS;
    }
}