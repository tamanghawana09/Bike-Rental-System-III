namespace bikeRental.User_Controls
{
    partial class helpUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            gradientPanel3 = new gradientPanel();
            gradientPanel2 = new gradientPanel();
            label11 = new Label();
            panel2.SuspendLayout();
            gradientPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(933, 57);
            panel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkTurquoise;
            label1.Location = new Point(272, 9);
            label1.Name = "label1";
            label1.Size = new Size(267, 40);
            label1.TabIndex = 0;
            label1.Text = "Bike Rental System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Yu Gothic UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkTurquoise;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(88, 45);
            label2.TabIndex = 9;
            label2.Text = "Help";
            // 
            // gradientPanel3
            // 
            gradientPanel3.Angle = 0F;
            gradientPanel3.BackColor = Color.White;
            gradientPanel3.BackgroundImageLayout = ImageLayout.None;
            gradientPanel3.BottomColor = Color.Empty;
            gradientPanel3.Location = new Point(22, 108);
            gradientPanel3.Name = "gradientPanel3";
            gradientPanel3.Size = new Size(200, 10);
            gradientPanel3.TabIndex = 11;
            gradientPanel3.TopColor = Color.Cyan;
            // 
            // gradientPanel2
            // 
            gradientPanel2.Angle = 0F;
            gradientPanel2.BottomColor = Color.White;
            gradientPanel2.Controls.Add(label11);
            gradientPanel2.Dock = DockStyle.Bottom;
            gradientPanel2.Location = new Point(0, 541);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(933, 39);
            gradientPanel2.TabIndex = 12;
            gradientPanel2.TopColor = Color.White;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Yu Gothic UI Semilight", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.DarkTurquoise;
            label11.Location = new Point(590, 10);
            label11.Name = "label11";
            label11.Size = new Size(262, 20);
            label11.TabIndex = 0;
            label11.Text = "All Rights Reserved. Bike Rental System";
            // 
            // helpUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            Controls.Add(gradientPanel2);
            Controls.Add(gradientPanel3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Name = "helpUC";
            Size = new Size(933, 580);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            gradientPanel2.ResumeLayout(false);
            gradientPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Label label2;
        private gradientPanel gradientPanel3;
        private gradientPanel gradientPanel2;
        private Label label11;
    }
}
