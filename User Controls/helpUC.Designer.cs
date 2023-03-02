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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gradientPanel3 = new bikeRental.gradientPanel();
            this.gradientPanel2 = new bikeRental.gradientPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.gradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 57);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bike Rental System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 45);
            this.label2.TabIndex = 9;
            this.label2.Text = "Help";
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.Angle = 0F;
            this.gradientPanel3.BackColor = System.Drawing.Color.White;
            this.gradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gradientPanel3.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanel3.Location = new System.Drawing.Point(22, 108);
            this.gradientPanel3.Name = "gradientPanel3";
            this.gradientPanel3.Size = new System.Drawing.Size(200, 10);
            this.gradientPanel3.TabIndex = 11;
            this.gradientPanel3.TopColor = System.Drawing.Color.Cyan;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Angle = 0F;
            this.gradientPanel2.BottomColor = System.Drawing.Color.White;
            this.gradientPanel2.Controls.Add(this.label11);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 541);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(883, 39);
            this.gradientPanel2.TabIndex = 12;
            this.gradientPanel2.TopColor = System.Drawing.Color.White;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label11.Location = new System.Drawing.Point(590, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(262, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "All Rights Reserved. Bike Rental System";
            // 
            // helpUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.gradientPanel2);
            this.Controls.Add(this.gradientPanel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Name = "helpUC";
            this.Size = new System.Drawing.Size(883, 580);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gradientPanel2.ResumeLayout(false);
            this.gradientPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
