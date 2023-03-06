namespace bikeRental
{
    partial class perHourPayment
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
            gradientPanel1 = new gradientPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            gradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.Angle = 70F;
            gradientPanel1.BackColor = Color.FromArgb(0, 0, 192);
            gradientPanel1.BottomColor = Color.Empty;
            gradientPanel1.Controls.Add(label4);
            gradientPanel1.Controls.Add(label3);
            gradientPanel1.Controls.Add(label2);
            gradientPanel1.Controls.Add(label1);
            gradientPanel1.Dock = DockStyle.Left;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(240, 391);
            gradientPanel1.TabIndex = 0;
            gradientPanel1.TopColor = Color.Cyan;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Yu Gothic UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 115);
            label1.Name = "label1";
            label1.Size = new Size(210, 50);
            label1.TabIndex = 0;
            label1.Text = "Bike Rental";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Yu Gothic UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(52, 165);
            label2.Name = "label2";
            label2.Size = new Size(124, 45);
            label2.TabIndex = 0;
            label2.Text = "System";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 347);
            label3.Name = "label3";
            label3.Size = new Size(208, 15);
            label3.TabIndex = 0;
            label3.Text = "Contact No : 9808691807, 9851196592  ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 367);
            label4.Name = "label4";
            label4.Size = new Size(191, 15);
            label4.TabIndex = 0;
            label4.Text = "Email : hawanatamang@gmail.com";
            // 
            // perHourPayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(684, 391);
            Controls.Add(gradientPanel1);
            Name = "perHourPayment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "perHourPayment";
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private gradientPanel gradientPanel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
    }
}